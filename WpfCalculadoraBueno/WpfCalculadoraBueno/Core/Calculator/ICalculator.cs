using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCalculadoraBueno.Core.Calculator
{
    public interface ICalculator
    {
        double Calculate(string CalculatorText);
    }
}
