using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCalculadoraBueno.Core.Calculator;
using Microsoft.Practices.Unity;

namespace WpfCalculadoraBueno.App_Start
{
    public static class Unity_Config
    {
        public static IUnityContainer RegisterInstances(this IUnityContainer container)
        {
            container.RegisterType<ICalculator, ExpressionCalculator>();
            return container;
        }
    }
}
