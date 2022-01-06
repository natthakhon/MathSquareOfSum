using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathSquareOfSumLib
{   
    public class MathSqSum : CodeActivity
    {
        [Category("Input")]
        [DisplayName("First Number")]
        [Description("Enter the first number")]
        [RequiredArgument]
        public InArgument<int> FirstNumber { get; set; }

        [Category("Input")]
        [DisplayName("Second Number")]
        [Description("Enter the second number")]
        [RequiredArgument]
        public InArgument<int> SecondNumber { get; set; }

        [Category("Output")]
        public OutArgument<double> ResultNumber { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var firstNumber = FirstNumber.Get(context);
            var secondNumber = SecondNumber.Get(context);

            var result = System.Math.Pow(firstNumber + secondNumber, 2);
            ResultNumber.Set(context, result);
        }
    }
}
