using System;
using OxyPlot;

namespace decpF20
{
    abstract class Function
    {
        public string[] variables { get; }
        public virtual OxyColor PreferredPlotColor { get; } = OxyColor.FromRgb(0xFF, 0xFF, 0xFF);
        public Function(string[] variables)
        {
            this.variables = variables;
        }
        public abstract decimal getValue(params decimal[] var_values);
        protected int getIndex(string var_name)
        {
            return Array.IndexOf(variables, var_name);
        }
    }

    class Variant4Function : Function
    {
        public Variant4Function() : base(new string[] { "x", "y" }) { }
        public override decimal getValue(params decimal[] var_values)
        {
            // 2x^3 + 2y/x
            return 2 * (decimal)Math.Pow((double)var_values[getIndex("x")], 3) + 2 * var_values[getIndex("y")] / var_values[getIndex("x")];
        }
    }

    class Variant4Solution : Function
    {
        public Variant4Solution() : base(new string[] { "x" }) { }
        public override OxyColor PreferredPlotColor { get; } = OxyColor.FromRgb(0x33, 0xAA, 0x55);
        public override decimal getValue(params decimal[] var_values)
        {
            // x^4 + x^2
            return (decimal)(Math.Pow((double)var_values[getIndex("x")], 4) + Math.Pow((double)var_values[getIndex("x")], 2));
        }
    }
}
