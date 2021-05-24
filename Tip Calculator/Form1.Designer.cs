
namespace Tip_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.noOfPersonsTextBox = new System.Windows.Forms.TextBox();
            this.noOfPersonsIncrement = new System.Windows.Forms.Button();
            this.noOfPersonsDecrement = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tipPercentageTextBox = new System.Windows.Forms.TextBox();
            this.tipIncrement = new System.Windows.Forms.Button();
            this.tipDecrement = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.billAmountTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalPerPerson = new System.Windows.Forms.Label();
            this.tipPerPerson = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.splitContainer1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(25, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1000, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox3);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.billAmountTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.totalPerPerson);
            this.splitContainer1.Panel2.Controls.Add(this.tipPerPerson);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Size = new System.Drawing.Size(994, 443);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.noOfPersonsTextBox);
            this.groupBox3.Controls.Add(this.noOfPersonsIncrement);
            this.groupBox3.Controls.Add(this.noOfPersonsDecrement);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Location = new System.Drawing.Point(21, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(250, 75);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // noOfPersonsTextBox
            // 
            this.noOfPersonsTextBox.Location = new System.Drawing.Point(57, 33);
            this.noOfPersonsTextBox.Name = "noOfPersonsTextBox";
            this.noOfPersonsTextBox.Size = new System.Drawing.Size(143, 31);
            this.noOfPersonsTextBox.TabIndex = 2;
            this.noOfPersonsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.noOfPersonsTextBox.TextChanged += new System.EventHandler(this.noOfPersons_TextChanged);
            // 
            // noOfPersonsIncrement
            // 
            this.noOfPersonsIncrement.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.noOfPersonsIncrement.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.noOfPersonsIncrement.Location = new System.Drawing.Point(197, 31);
            this.noOfPersonsIncrement.Name = "noOfPersonsIncrement";
            this.noOfPersonsIncrement.Size = new System.Drawing.Size(41, 34);
            this.noOfPersonsIncrement.TabIndex = 1;
            this.noOfPersonsIncrement.Text = "+";
            this.noOfPersonsIncrement.UseVisualStyleBackColor = false;
            this.noOfPersonsIncrement.Click += new System.EventHandler(this.button3_Click);
            // 
            // noOfPersonsDecrement
            // 
            this.noOfPersonsDecrement.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.noOfPersonsDecrement.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.noOfPersonsDecrement.Location = new System.Drawing.Point(15, 31);
            this.noOfPersonsDecrement.Name = "noOfPersonsDecrement";
            this.noOfPersonsDecrement.Size = new System.Drawing.Size(45, 34);
            this.noOfPersonsDecrement.TabIndex = 0;
            this.noOfPersonsDecrement.Text = "-";
            this.noOfPersonsDecrement.UseVisualStyleBackColor = false;
            this.noOfPersonsDecrement.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.tipPercentageTextBox);
            this.groupBox2.Controls.Add(this.tipIncrement);
            this.groupBox2.Controls.Add(this.tipDecrement);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(21, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 75);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tipPercentageTextBox
            // 
            this.tipPercentageTextBox.Location = new System.Drawing.Point(57, 33);
            this.tipPercentageTextBox.Name = "tipPercentageTextBox";
            this.tipPercentageTextBox.Size = new System.Drawing.Size(143, 31);
            this.tipPercentageTextBox.TabIndex = 2;
            this.tipPercentageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tipPercentageTextBox.TextChanged += new System.EventHandler(this.tipPercentage_TextChanged);
            // 
            // tipIncrement
            // 
            this.tipIncrement.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tipIncrement.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tipIncrement.Location = new System.Drawing.Point(197, 31);
            this.tipIncrement.Name = "tipIncrement";
            this.tipIncrement.Size = new System.Drawing.Size(41, 34);
            this.tipIncrement.TabIndex = 1;
            this.tipIncrement.Text = "+";
            this.tipIncrement.UseVisualStyleBackColor = false;
            this.tipIncrement.Click += new System.EventHandler(this.tipIncrement_Click);
            // 
            // tipDecrement
            // 
            this.tipDecrement.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tipDecrement.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.tipDecrement.Location = new System.Drawing.Point(15, 31);
            this.tipDecrement.Name = "tipDecrement";
            this.tipDecrement.Size = new System.Drawing.Size(45, 34);
            this.tipDecrement.TabIndex = 0;
            this.tipDecrement.Text = "-\r\n";
            this.tipDecrement.UseVisualStyleBackColor = false;
            this.tipDecrement.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(21, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of people";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(21, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tip %";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // billAmountTextBox
            // 
            this.billAmountTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.billAmountTextBox.Location = new System.Drawing.Point(21, 67);
            this.billAmountTextBox.Name = "billAmountTextBox";
            this.billAmountTextBox.Size = new System.Drawing.Size(180, 31);
            this.billAmountTextBox.TabIndex = 1;
            this.billAmountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.billAmountTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(21, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(47, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 30);
            this.label9.TabIndex = 5;
            this.label9.Text = "per person";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(47, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 30);
            this.label8.TabIndex = 4;
            this.label8.Text = "per person";
            // 
            // totalPerPerson
            // 
            this.totalPerPerson.AutoSize = true;
            this.totalPerPerson.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalPerPerson.Location = new System.Drawing.Point(338, 252);
            this.totalPerPerson.Name = "totalPerPerson";
            this.totalPerPerson.Size = new System.Drawing.Size(0, 65);
            this.totalPerPerson.TabIndex = 3;
            // 
            // tipPerPerson
            // 
            this.tipPerPerson.AutoSize = true;
            this.tipPerPerson.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipPerPerson.Location = new System.Drawing.Point(338, 93);
            this.tipPerPerson.Name = "tipPerPerson";
            this.tipPerPerson.Size = new System.Drawing.Size(0, 65);
            this.tipPerPerson.TabIndex = 2;
            this.tipPerPerson.Click += new System.EventHandler(this.tipPerPerson_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(47, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 45);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(47, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tip\r\n";
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(387, 26);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 25);
            this.errorLabel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 595);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "Form1";
            this.Text = "Tip Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox billAmountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalPerPerson;
        private System.Windows.Forms.Label tipPerPerson;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tipPercentageTextBox;
        private System.Windows.Forms.Button tipIncrement;
        private System.Windows.Forms.Button tipDecrement;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox noOfPersonsTextBox;
        private System.Windows.Forms.Button noOfPersonsIncrement;
        private System.Windows.Forms.Button noOfPersonsDecrement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label errorLabel;
    }
}

