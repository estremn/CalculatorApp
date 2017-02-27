using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace CalculatorApp
{
    public partial class CalculatorPage : ContentPage
    {

        public CalculatorPage()
        {
            InitializeComponent();
        }

        public String Work(String strA, String strB, Char charC)
        {
            Int32 intA = Convert.ToInt32(strA);
            Int32 intB = Convert.ToInt32(strB);

            if (charC == '+')
            {
                return Add(intA, intB).ToString();
            }
            else
            {
                if (charC == '-')
                {
                    return Subtract(intA, intB).ToString();
                }
                else
                {
                    if (charC == '*')
                    {
                        return Multiply(intA, intB).ToString();
                    }
                    else
                    {
                        if (charC == '/')
                        {
                            return Divide(intA, intB).ToString();
                        }
                        else
                        {
                            if (charC == '%')
                            {
                                return Mod(intA, intB).ToString();
                            }
                            else
                            {
                                return "Invalid Operator";
                            }
                        }
                    }
                }
            }
        }

        private Int32 Add(Int32 a, Int32 b)
        {
            return a + b;
        }

        private Int32 Subtract(Int32 a, Int32 b)
        {
            return a - b;
        }

        private Int32 Multiply(Int32 a, Int32 b)
        {
            return a * b;
        }

        private Double Divide(Int32 a, Int32 b)
        {
            return a / b;
        }

        private Int32 Mod(Int32 a, Int32 b)
        {
            return a % b;
        }


    }
}
