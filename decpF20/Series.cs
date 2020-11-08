using System;

namespace decpF20
{
    abstract class Series
    {

        protected decimal[] CalculatedValues { get; set; }
        public decimal LowerBound { get; }
        public decimal HigherBound { get; }
        public decimal Step { get; protected set; }
        protected int StepsCalculated { get; set; } = 0;

        public Series(int step_count, decimal initial_value, decimal lower_bound, decimal higher_bound)
        {
            LowerBound = lower_bound;
            HigherBound = higher_bound;
            Step = (higher_bound - lower_bound) / step_count;
            // Values are indexed from 0, where 0th is an initial value; see getValue()
            CalculatedValues = new decimal[step_count + 1];
            CalculatedValues[0] = initial_value;
        }

        // Get the value of the series by the value of x (x must be in the bound of the series)
        protected decimal getValue(decimal x)
        {
            x = Math.Round(x, 5);
            if (x < LowerBound || x > HigherBound)
                throw new IndexOutOfRangeException($"Given value is not in the bounds of the variable ({LowerBound}, {HigherBound})");
            int index = (int)((x - LowerBound) / Step);
            return getValue(index);
        }

        // Get the value of the series by the step number (starting from 0, which is initial value)
        protected decimal getValue(int step_num)
        {
            if (step_num < 0 || step_num > CalculatedValues.Length)
                throw new IndexOutOfRangeException($"Given step number is negative or exceeds the step count ({CalculatedValues.Length}, given {step_num})");
            return step_num <= StepsCalculated ? CalculatedValues[step_num] : calculate(step_num);
        }

        // Calculate the value in the series (and the ones before it, if they were not calculated yet)
        protected decimal calculate(int step_num)
        {
            for (int i = StepsCalculated; i < step_num; i++)
            {
                decimal x_prev = LowerBound + i * Step, y_prev = CalculatedValues[i];
                CalculatedValues[i + 1] = getNext(x_prev, y_prev);
                StepsCalculated++;
            }
            return CalculatedValues[step_num];
        }

        // This method determines the way the value is calculated based on previous ones
        protected abstract decimal getNext(decimal x_prev, decimal y_prev);
    }

    class GlobalTruncationErrors : Series
    {
        private decimal max_error = 0;
        public Function Solution { get; }
        public NumericalMethod Method { get; }
        public decimal MaxError
        {
            get 
            {
                // Calculate the values till the last one and pick max_error after calculations
                calculate(CalculatedValues.Length - 1);
                return max_error;
            }
            private set => max_error = value;
        }

        public GlobalTruncationErrors(NumericalMethod method, Function solution, int step_count) :
            base(step_count, 0, method.LowerBound, method.HigherBound)
        {
            Solution = solution;
            Method = method;
        }

        protected override decimal getNext(decimal x_prev, decimal y_prev)
        {
            // GTE = | y_i_exact - y_i | (not depending on previous values); i == StepsCalculated
            decimal value = Math.Abs(Solution.getValue(x_prev + Step) - Method.getApproximation(StepsCalculated));
            if (value > max_error)
                MaxError = value;
            return value;
        }

        public decimal get(int step_num)
        {
            return getValue(step_num);
        }

        public decimal get(decimal x)
        {
            return getValue(x);
        }
    }

    class GlobalErrorsFromSteps : Series
    {
        // Solution and Method are used for creating GTE objects
        public Function Solution { get; }
        public NumericalMethod Method { get; }
        public GlobalErrorsFromSteps(GlobalTruncationErrors gte_0, int start_step, int end_step) :
            base(end_step - start_step + 1, gte_0.MaxError, start_step, end_step)
        {
            Step = 1;
            Solution = gte_0.Solution;
            Method = gte_0.Method;
        }

        protected override decimal getNext(decimal n_i, decimal gte_prev)
        {
            // Create GTE on the same method and error but with different step (grid) sizes
            return new GlobalTruncationErrors(Method, Solution, (int)n_i).MaxError;
        }

        public decimal get(int step_num)
        {
            return getValue(step_num);
        }

        public decimal get(decimal n)
        {
            return getValue(n);
        }
    }
}
