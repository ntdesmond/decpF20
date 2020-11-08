using System;
using System.Drawing.Printing;
using OxyPlot;

namespace decpF20
{
    abstract class NumericalMethod : Series
    {
        public abstract string Name { get; }
        public Function Function { get; }
        public virtual OxyColor PreferredPlotColor { get; } = OxyColor.FromRgb(0x99, 0x99, 0x99);

        public NumericalMethod(Function function, int step_count, decimal exact_initial,  decimal from, decimal to) :
            base(step_count, exact_initial, from, to)
        {
            Function = function;
        }
        public decimal getApproximation(decimal x)
        {
            return getValue(x);
        }
        public decimal getApproximation(int step_num)
        {
            return getValue(step_num);
        }
    }

    class EulerMethod : NumericalMethod
    {
        public override string Name { get; } = "Euler's";
        public override OxyColor PreferredPlotColor { get; } = OxyColor.FromRgb(0x00, 0x55, 0xFF);
        public EulerMethod(Function function, int step_count, decimal y_start, decimal x_start, decimal x_end) :
            base(function, step_count, y_start, x_start, x_end) { }

        protected override decimal getNext(decimal x_prev, decimal y_prev)
        {
            return y_prev + Step * Function.getValue(x_prev, y_prev);
        }
    }

    class ImprovedEulerMethod : NumericalMethod
    {
        public override string Name { get; } = "Improved Euler's";
        public override OxyColor PreferredPlotColor { get; } = OxyColor.FromRgb(0x00, 0xAA, 0xFF);
        public ImprovedEulerMethod(Function function, int step_count, decimal y_start, decimal x_start, decimal x_end) :
            base(function, step_count, y_start, x_start, x_end) { }

        protected override decimal getNext(decimal x_prev, decimal y_prev)
        {
            decimal eulers_next = y_prev + Step * Function.getValue(x_prev, y_prev);
            return y_prev + Step * (
                Function.getValue(x_prev, y_prev) +            // k1
                Function.getValue(x_prev + Step, eulers_next)  // k2
            ) / 2;
        }
    }

    class RungeKuttaMethod : NumericalMethod
    {
        public override string Name { get; } = "Runge-Kutta";
        public override OxyColor PreferredPlotColor { get; } = OxyColor.FromRgb(0xDD, 0xAA, 0x33);
        public RungeKuttaMethod(Function function, int step_count, decimal y_start, decimal x_start, decimal x_end) :
            base(function, step_count, y_start, x_start, x_end) { }

        protected override decimal getNext(decimal x_prev, decimal y_prev)
        {
            decimal
                k1 = Function.getValue( x_prev, y_prev),
                k2 = Function.getValue(x_prev + Step / 2, y_prev + Step * k1 / 2),
                k3 = Function.getValue(x_prev + Step / 2, y_prev + Step * k2 / 2),
                k4 = Function.getValue(x_prev + Step, y_prev + Step * k3);
            return y_prev + Step * (k1 + 2 * k2 + 2 * k3 + k4) / 6;
        }
    }
}
