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

        //Booleans
        private Boolean Is0()
        {
            return (strOutput.Text == "0" || strOutput.Text == "");
        }

        private Boolean CapReached()
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

        private Double Divide(int a, int b)
        {
            return a / b;
        }

        private int Mod(int a, int b)
        {
            return a % b;
        }

        private void Clear()
        {
            if (strOutput.Text != "")
            {
                strOutput.Text = "";
                strOutputRecord.Text = "";
            }
        }

        //private void btn0_Click(object btn0, EventArgs e)
        //{
        //    if (!CapReached() && !Is0())
        //    {
        //        strOutput.Text += "0";
        //    }
        //}

        //private void btn1_Click(Trigger btn1_Clicked, EventArgs e)
        //{
        //    if (!CapReached())
        //    {
        //        if (Is0())
        //        {
        //            strOutput.Text = "1";
        //        }
        //        else
        //        {
        //            strOutput.Text += "1";
        //        }
        //    }
        //}

    }
}
