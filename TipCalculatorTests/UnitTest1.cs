using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tip_Calculator;

namespace TipCalculatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calculate_BillAmountInteger_MatchesWithDoubleValue ()
        {
            // Arrange
            Form1 form = new Form1();
            form.SetBillAmount(100);
            form.SetTipPercentage(10);
            form.SetNumberOfPersons(3);
            double expectedTiPPerPerson = 3.333;
            double expectedTotalPerPerson = 36.666;

            // Act
            form.Calculate();
            double actualTipPerPerson = form.GetTipPerPerson();
            double actualTotalPerPerson = form.GetTotalPerPerson();

            // Assert
            Assert.AreEqual(expectedTiPPerPerson, actualTipPerPerson, 0.001);
            Assert.AreEqual(expectedTotalPerPerson, actualTotalPerPerson, 0.001);
        }

        [TestMethod]
        public void Calculate_BillAmountDouble_MatchesDoubleValue ()
        {
            // Arrange
            Form1 form = new Form1();
            form.SetBillAmount(500.30);
            form.SetTipPercentage(10);
            form.SetNumberOfPersons(3);
            double expectedTipPerPerson = 16.676;
            double expectedTotalPerPerson = 183.443;

            // Act
            form.Calculate();
            double actualTipPerPerson = form.GetTipPerPerson();
            double actualTotalPerPerson = form.GetTotalPerPerson();

            // Assert
            Assert.AreEqual(expectedTipPerPerson, actualTipPerPerson, 0.001);
            Assert.AreEqual(expectedTotalPerPerson, actualTotalPerPerson, 0.001);
        }

        [TestMethod]
        public void Calculate_BilAmountZeroOtherValuesNonZero_MatchesZero ()
        {
            // Arrange
            Form1 form = new Form1();
            form.SetBillAmount(0);
            form.SetNumberOfPersons(2);
            form.SetTipPercentage(10);
            double expectedTipPerPerson = 0.00;
            double expectedTotalPerPerson = 0.00;

            // Act
            form.Calculate();
            double actualTipPerPerson = form.GetTipPerPerson();
            double actualTotalPerPerson = form.GetTotalPerPerson();

            // Assert
            Assert.AreEqual(expectedTipPerPerson, actualTipPerPerson);
            Assert.AreEqual(expectedTotalPerPerson, actualTotalPerPerson);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BillAmountTextBox_NegativeValue_ThrowsArithmeticException ()
        {
            // Arrange
            Form1 form = new Form1();
            form.SetBillAmount(-10);


            // Act and Assert
            form.textBox1_TextChanged(new object(), new EventArgs());
        }
    }
}
