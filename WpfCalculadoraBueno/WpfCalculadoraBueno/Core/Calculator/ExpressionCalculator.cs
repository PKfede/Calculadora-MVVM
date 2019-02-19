using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalculadoraBueno.Core.Calculator
{
    public class ExpressionCalculator : ICalculator
    {

        public double Calculate(string CalculateText)
        {
            var dataTable = new DataTable();
            var value = dataTable.Compute(CalculateText, "");
            return Convert.ToDouble(value);
        }

    }
}
