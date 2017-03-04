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
        
        private String Work(String strA, String strB, Char charC)
        {
            Int32 intA;
            Int32 intB;

            try
            {
                intA = Convert.ToInt32(strA);
                intB = Convert.ToInt32(strB);
            }
            catch (Exception ex)
            {
                return "Invalid Input";
            }

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

        private void Clear()
        {
            if (strOutput.Text != "")
            {
                strOutputRecord.Text += " " + strOutput.Text;
                strOutput.Text = "";
            }
        }
    }
}
