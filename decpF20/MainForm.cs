using System;
using System.Drawing;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;

namespace decpF20
{
    public partial class MainForm : Form
    {
        private Variant4Function derivative_function = new Variant4Function();
        private Variant4Solution exact_solution = new Variant4Solution();
        private int n0, N;
        private decimal y0, X, x0, step;
        public MainForm()
        {
            InitializeComponent();
            InitializeViews();
            PlotGraphs();
        }

        private void InitializeViews()
        {
            approximationsPlotView.Model = new PlotModel()
            {
                Title = "y(x) exact and numerical solutions",
                LegendPosition = LegendPosition.TopLeft
            };
            approximationsPlotView.Model.Axes.Add(new LinearAxis() { Title = "x", Position = AxisPosition.Bottom });
            approximationsPlotView.Model.Axes.Add(new LinearAxis() { Title = "y(x)", Position = AxisPosition.Left });

            globalErrorsPlotView.Model = new PlotModel()
            {
                Title = "Global trailing errors of the methods",
                LegendPosition = LegendPosition.TopLeft
            };
            globalErrorsPlotView.Model.Axes.Add(new LinearAxis() { Title = "x", Position = AxisPosition.Bottom });
            globalErrorsPlotView.Model.Axes.Add(new LinearAxis() {
                Title = "Global error", Position = AxisPosition.Left, AbsoluteMinimum = 0
            });

            maxGlobalErrorsPlotView.Model = new PlotModel()
            {
                Title = "Maximal error from grid size (step count) dependency",
                LegendPosition = LegendPosition.TopRight
            };
            maxGlobalErrorsPlotView.Model.Axes.Add(new LinearAxis() {
                Title = "Step count", Position = AxisPosition.Bottom, AbsoluteMinimum = 1
            });
            maxGlobalErrorsPlotView.Model.Axes.Add(new LinearAxis() {
                Title = "Maximal GTE", Position = AxisPosition.Left, AbsoluteMinimum = 0
            });
        }

        private void PlotGraphs()
        {
            n0 = (int)numControlN0.Value;
            N = (int)numControlN.Value;
            y0 = numControlY0.Value;
            X = numControlX.Value;
            x0 = numControlX0.Value;
            step = (X - x0) / N;

            NumericalMethod[] methods =
            {
                new EulerMethod(derivative_function, N, y0, x0, X),
                new ImprovedEulerMethod(derivative_function, N, y0, x0, X),
                new RungeKuttaMethod(derivative_function, N, y0, x0, X)
            };
            PlotSolutions(exact_solution, methods, x0, X, step);
            GlobalTruncationErrors[] globalErrors = new GlobalTruncationErrors[methods.Length];
            for (int i = 0; i < methods.Length; i++)
                globalErrors[i] = new GlobalTruncationErrors(methods[i], exact_solution);
            PlotGlobalErrors(globalErrors, x0, X, step);

            GlobalErrorsFromSteps[] maxGlobalErrors = new GlobalErrorsFromSteps[methods.Length];
            for (int i = 0; i < methods.Length; i++)
            {
                methods[i].setNewBounds(1, methods[i].LowerBound, methods[i].HigherBound);
                GlobalTruncationErrors initial_gte = new GlobalTruncationErrors(methods[i], exact_solution);
                maxGlobalErrors[i] = new GlobalErrorsFromSteps(initial_gte, n0, N);
            }
            PlotMaxGlobalErrors(maxGlobalErrors, n0, N);
        }

        private void PlotSolutions(Function exactSolution, NumericalMethod[] approximationMethods, decimal lower_bound, decimal higher_bound, decimal step)
        {
            approximationsPlotView.Model.Series.Clear();

            // Using lambdas since FunctionSeries accepts only double type
            var exactSolutionPlot = new FunctionSeries(x => (double)exactSolution.getValue((decimal)x), (double)lower_bound, (double)higher_bound, (double)step)
            {
                Title = "Exact solution", Color = exactSolution.PreferredPlotColor
            };
            approximationsPlotView.Model.Series.Add(exactSolutionPlot);

            foreach (var method in approximationMethods)
            {
                var approximationPlot = new FunctionSeries(x => (double)method.getApproximation((decimal)x), (double)method.LowerBound, (double)method.HigherBound, (double)method.Step)
                {
                    Title = method.Name, Color = method.PreferredPlotColor
                };
                approximationsPlotView.Model.Series.Add(approximationPlot);
            }
        }

        private void PlotGlobalErrors(GlobalTruncationErrors[] globalErrors, decimal lower_bound, decimal higher_bound, decimal step)
        {
            globalErrorsPlotView.Model.Series.Clear();

            foreach (var gte in globalErrors)
            {
                var globalErrorsPlot = new FunctionSeries(x => (double)gte.get((decimal)x), (double)lower_bound, (double)higher_bound, (double)step)
                {
                    Title = gte.Method.Name, Color = gte.Method.PreferredPlotColor
                };
                globalErrorsPlotView.Model.Series.Add(globalErrorsPlot);
            }
        }
        
        private void PlotMaxGlobalErrors(GlobalErrorsFromSteps[] maxGlobalErrors, decimal lower_bound, decimal higher_bound)
        {
            maxGlobalErrorsPlotView.Model.Series.Clear();

            foreach (var maxGTE in maxGlobalErrors)
            {
                var maxGlobalErrorsPlot = new FunctionSeries(x => (double)maxGTE.get((decimal)x), (double)lower_bound, (double)higher_bound, 1.0)
                {
                    Title = maxGTE.Method.Name, Color = maxGTE.Method.PreferredPlotColor
                };
                maxGlobalErrorsPlotView.Model.Series.Add(maxGlobalErrorsPlot);
            }
        }

        // Size the plot views properly
        private void solutionsPage_SizeChanged(object sender, EventArgs e)
        {
            approximationsPlotView.Size = new Size(
                approximationsPlotView.Size.Width,
                solutionsPage.Size.Height / 2 - 7
            );
            globalErrorsPlotView.Top = approximationsPlotView.Bottom + 2;
            globalErrorsPlotView.Size = new Size(
                globalErrorsPlotView.Size.Width,
                solutionsPage.Size.Height / 2 - 7
            );
        }

        private void tabSwitch_Selected(object sender, TabControlEventArgs e)
        {
            numControlN0.Enabled = e.TabPageIndex == 1;
            if (numControlN.Value == numControlN0.Value)
                numControlN.Value++;
        }

        private void numControlX0_ValueChanged(object sender, EventArgs e)
        {
            if (numControlX0.Value >= numControlX.Value)
            {
                numControlX0.Value = x0;
            }
            else
            {
                x0 = numControlX0.Value;
                numControlX0_2.Value = numControlX0.Value;
                showModifiedValuesTip(sender, e);
            }
        }

        private void numControlX_ValueChanged(object sender, EventArgs e)
        {
            if (numControlX.Value <= numControlX0.Value)
            {
                numControlX.Value = X;
            }
            else { 
                X = numControlX.Value;
                showModifiedValuesTip(sender, e);
            }
        }

        private void showModifiedValuesTip(object sender, EventArgs e)
        {
            labelChangedValues.Visible = true;
        }
        private void hideModifiedValuesTip(object sender, EventArgs e)
        {
            labelChangedValues.Visible = false;
        }

        private void showUsageTip(object sender, EventArgs e)
        {
            labelUsageTip.Visible = true;
        }
        private void hideUsageTip(object sender, EventArgs e)
        {
            labelUsageTip.Visible = false;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            PlotGraphs();
            approximationsPlotView.InvalidatePlot(false);
            globalErrorsPlotView.InvalidatePlot(false);
            maxGlobalErrorsPlotView.InvalidatePlot(false);
            hideModifiedValuesTip(sender, e);
        }

        private void numControlN0_ValueChanged(object sender, EventArgs e)
        {
            if (numControlN0.Value >= numControlN.Value)
            {
                numControlN0.Value = n0;
            }
            else 
            { 
                n0 = (int)numControlN0.Value;
                showModifiedValuesTip(sender, e);
            }
                
        }

        private void numControlN_ValueChanged(object sender, EventArgs e)
        {
            if (numControlN.Value <= numControlN0.Value && numControlN0.Value != 1)
            {
                numControlN.Value = N;
            }
            else
            {
                N = (int)numControlN.Value;
                showModifiedValuesTip(sender, e);
            }
        }
    }
}
