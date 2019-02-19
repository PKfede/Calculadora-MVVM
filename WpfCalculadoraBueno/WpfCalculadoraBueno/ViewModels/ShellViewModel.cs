using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfCalculadoraBueno.Core.Calculator;
using WpfCalculadoraBueno.ViewModels.Base;
using Prism;

namespace WpfCalculadoraBueno.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        private readonly ICalculator _calculator;
        private bool hasCalculated;
        public ShellViewModel(ICalculator calculator)
        {
            _calculator = calculator;
        }
        public string Title { get; } = "Calculadora";


        private string _calculatorText;

        public string CalculatorText
        {
            get => _calculatorText;
            set => SetProperty(ref _calculatorText, value);
        }

        public DelegateCommand<object> AddNumberCommand { get; set; }
        public DelegateCommand ClearCommmand { get; set; }
        public DelegateCommand EqualsCommand { get; set; }

        protected override void RegisterCommands()
        {
            AddNumberCommand = new DelegateCommand<object>(AddNumber);
            ClearCommmand = new DelegateCommand(Clear);
            EqualsCommand = new DelegateCommand(Calculate);
        }
        private void Calculate()
        {
            CalculatorText = _calculator.Calculate(CalculatorText).ToString("N2");
            hasCalculated = true;
        }
        private void AddNumber(object buttonValue)
        {
            if (hasCalculated)
            {
                Clear();
                hasCalculated = false;
            }
            CalculatorText += buttonValue.ToString();
        }
        private void Clear()
        {
            CalculatorText = string.Empty;
        }
    }
}
