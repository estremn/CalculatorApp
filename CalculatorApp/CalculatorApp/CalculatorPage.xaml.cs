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

        public string strFirstInput = "";
        public string strSecondInput = "";
        public char charOperator;
        private bool postCalc = false;

        //Logic
        private string Calculate(string strA, string strB, char charC)
        {
            int intA;
            int intB;

            //Foolproofing
            try
            {
                intA = Convert.ToInt32(strA.Trim());
                intB = Convert.ToInt32(strB.Trim());
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
                            if (intB == 0)
                            {
                                return "Cannot Divide by 0";
                            }
                            else
                            {
                                return Divide(intA, intB).ToString();
                            }
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

        private void Process(bool newOperator)
        {
            if (strFirstInput.Length > 0 && charOperator.ToString().Length > 0 && strSecondInput.Length > 0)
            {
                string strCalcResult = Calculate(strFirstInput, strSecondInput, charOperator);
                strOutputRecord.Text = strFirstInput + " " + charOperator + " " + strSecondInput + " " + strCalcResult;

                if (newOperator)
                {
                    postCalc = false;
                }
                else
                {
                    postCalc = true;
                }
            }
            else
            {

            }

        }

        //Booleans
        private bool Is0()
        {
            return (strOutput.Text == "0" || strOutput.Text == "");
        }

        private bool CapReached()
        {
            int maxLength = 10;
            return strOutput.Text.Length < maxLength;
        }

        //Function Library
        private int Add(int a, int b)
        {
            return a + b;
        }

        private int Subtract(int a, int b)
        {
            return a - b;
        }

        private int Multiply(int a, int b)
        {
            return a * b;
        }

        private double Divide(int a, int b)
        {
            return a / b;
        }

        private int Mod(int a, int b)
        {
            return a % b;
        }

        private void Clear()
        {
            strOutput.Text = "";
            strFirstInput = "";
            strSecondInput = "";
        }

        //private void btn0_Click(object btn0, EventArgs e)
        //{
        //    if (!CapReached() && !Is0())
        //    {
        //        strOutput.Text += "0";
        //    }
        //}

        private void btn1_Click(BindableObject btn1, EventArgs e)
        {
            if (!CapReached() || postCalc)
            {
                if (Is0() || postCalc)
                {
                    strOutput.Text = "1";
                }
                else
                {
                    strOutput.Text += "1";
                }
            }
        }

    }
}
