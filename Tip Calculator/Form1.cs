using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tipPercentageTextBox.Text = tipPercentage.ToString();
            noOfPersonsTextBox.Text = noOfPersons.ToString();
        }

        // Declaring Variables
        private double billAmount = 0.00;
        private int tipPercentage = 0;
        private double tipAmount = 0.00;
        private int noOfPersons = 1;
        private double tipPerPersonn = 0.00;
        private double billPerPerson = 0.00;
        private double totalPerPersonn = 0.00;
       
        // Get and set methods for variables
        public void SetBillAmount(double bill_amount)
        {
            this.billAmount = bill_amount;
        }

        public double GetBillAmount()
        {
            return this.billAmount;
        }

        public void SetTipPercentage(int tip_percentage)
        {
            this.tipPercentage = tip_percentage;
        }

        public int GetTipPercentage()
        {
            return this.tipPercentage;
        }

        public void SetNumberOfPersons(int no_of_persons)
        {
            this.noOfPersons = no_of_persons;
        }

        public int GetNumberOfPersons()
        {
            return this.noOfPersons;
        }

        public double GetTipPerPerson()
        {
            return this.tipPerPersonn;
        }

        public double GetTotalPerPerson()
        {
            return this.totalPerPersonn;
        }

        // Method to calculte bill per person and total per person
        public void Calculate()
        {
            tipAmount = (billAmount * tipPercentage) / 100;
            tipPerPersonn = tipAmount / noOfPersons;
            billPerPerson = billAmount / noOfPersons;
            totalPerPersonn = (billPerPerson + tipPerPersonn);
            return;
        }

        // Method to setoutput for form labels
        private void setOutput()
        {
            tipPerPerson.ForeColor = Color.Black;
            totalPerPerson.ForeColor = Color.Black;
            tipPerPerson.Text = ("$" + String.Format("{0:0.00}", tipPerPersonn));
            totalPerPerson.Text = ("$" + String.Format("{0:0.00}", totalPerPersonn));
            tipPercentageTextBox.Text = tipPercentage.ToString();
            noOfPersonsTextBox.Text = noOfPersons.ToString();
            errorLabel.Text = "".ToString();
            return;
        }

        // Method to generate error message when exception is thrown
        private void errorMessage()
        {
            tipPerPerson.ForeColor = Color.Red;
            totalPerPerson.ForeColor = Color.Red;
            tipPerPerson.Text = "Error!".ToString();
            totalPerPerson.Text = "Error!".ToString();
            return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        // Method called when text changed inside Bill TextBox
         public void textBox1_TextChanged(object sender, EventArgs e)
         {
            try
            {
                String billl = billAmountTextBox.Text;
                if (String.IsNullOrEmpty(billl))
                {
                    billAmount = 0.00;
                    tipPerPersonn = 0.00;
                    totalPerPersonn = 0.00;
                    billPerPerson = 0.00;
                    tipAmount = 0.00;
                    setOutput();
                }
                else
                {
                    billAmount = Convert.ToDouble(billl);
                    Type tp = billAmount.GetType();
                    if (tp.Equals(typeof(Double)))
                    {
                        if (billAmount < 0)
                        {
                            throw new Exception("Bill value should be positive.");
                        }
                        errorLabel.Text = "".ToString();
                        Calculate();
                        setOutput();
                    }
                    // If bill_amount type not equal to double, it will throw FormatException
                }
            }
            catch (FormatException)
            {
                errorLabel.Text = "Invalid input".ToString();
                errorMessage();
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message.ToString();
                errorMessage();
            } 
        }
        
        private void tipPerPerson_Click(object sender, EventArgs e)
        {

        }

        // When tip decrement button is clicked
        private void button1_Click(object sender, EventArgs e)
        {
            tipPercentage--;
            Calculate();
            setOutput();
        }

        // When tip increment button is clicked
        private void tipIncrement_Click(object sender, EventArgs e)
        {
            tipPercentage++;
            Calculate();
            setOutput();
        }

        // Called when text change inside Tip Percentage TextBox
        private void tipPercentage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String tip_percentage_string = tipPercentageTextBox.Text;
                if (String.IsNullOrEmpty(tip_percentage_string))
                {
                    tipPercentage = 0;
                    setOutput();
                    tipPercentageTextBox.SelectAll();
                }
                else
                {
                    tipPercentage = Convert.ToInt32(tipPercentageTextBox.Text);
                    Type tp = tipPercentage.GetType();
                    if (tp.Equals(typeof(Int32)))
                    {
                        if(tipPercentage < 0)
                        {
                            throw new Exception("Tip value should be positive.");
                        }
                        errorLabel.Text = "".ToString();
                        tipPercentageTextBox.SelectionStart = tipPercentageTextBox.Text.Length;
                        Calculate();
                        setOutput();
                    }
                    // If tip amount type not equal to int, it will throw Format Exception
                }
            }
            catch(FormatException)
            {
                errorLabel.Text = "Invalid tip value.".ToString();
                errorMessage();
            }

            catch (Exception ex)
            {
                errorLabel.Text = ex.Message.ToString();
                errorMessage();
            }
            finally
            {
                if (tipPercentage <= 0)
                {
                    tipDecrement.Enabled = false;
                }
                else
                {
                    tipDecrement.Enabled = true;
                }
            }
        }

        // Called when noOfPersonsDecrement is clicked
        private void button4_Click(object sender, EventArgs e)
        {
            noOfPersons--;
            noOfPersonsTextBox.Text = noOfPersons.ToString();
            Calculate();
            setOutput();
        }

        // Called when noOfPersonsIncrement is clicked
        private void button3_Click(object sender, EventArgs e)
        {
            noOfPersons++;
            noOfPersonsTextBox.Text = noOfPersons.ToString();
            Calculate();
            setOutput();
        }

        // Called when text inside noOfPersons Changed
        private void noOfPersons_TextChanged(object sender, EventArgs e)
        { 
            try
            {
                
                String no_of_persons_string = noOfPersonsTextBox.Text;
                if (String.IsNullOrEmpty(no_of_persons_string))
                {
                    noOfPersons = 1;
                    setOutput();
                    noOfPersonsTextBox.SelectAll();
                }
                else
                {
                    noOfPersons = Convert.ToInt32(noOfPersonsTextBox.Text);
                    Type tp = noOfPersons.GetType();
                    if (tp.Equals(typeof(Int32)))
                    {
                        if (noOfPersons < 0)
                        {
                            throw new Exception("Number of people should be positive.");
                        } 
                        else if(noOfPersons == 0) {
                            noOfPersons = 0;
                            throw new Exception("Number of people should not be 0.");
                        }
                         errorLabel.Text = "".ToString();
                         noOfPersonsTextBox.SelectionStart = noOfPersonsTextBox.Text.Length; 
                         Calculate();
                         setOutput();
                    }
                    // if no_of_persons type not equal to int, throws Format Exception.
                }
            }
            catch(FormatException)
            {
                errorLabel.Text = "Invalid number of people".ToString();
                errorMessage();
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message.ToString();
                errorMessage();
            }
            finally
            {
                if (noOfPersons < 2)
                {
                    noOfPersonsDecrement.Enabled = false;
                }
                else
                {
                    noOfPersonsDecrement.Enabled = true;
                }
            }
        }
    }
}
