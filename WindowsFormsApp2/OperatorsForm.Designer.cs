﻿namespace WindowsFormsApp2
{
    partial class OperatorsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNum = new System.Windows.Forms.TextBox();
            this.secondNum = new System.Windows.Forms.TextBox();
            this.operators = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.secondWord = new System.Windows.Forms.TextBox();
            this.firstWord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.finalWord = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(104, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter first number:";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.result.ForeColor = System.Drawing.Color.RoyalBlue;
            this.result.Location = new System.Drawing.Point(104, 183);
            this.result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(197, 25);
            this.result.TabIndex = 1;
            this.result.Text = "Perform an Operation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(104, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select an Operator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(104, 92);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter second number:";
            // 
            // firstNum
            // 
            this.firstNum.BackColor = System.Drawing.Color.AliceBlue;
            this.firstNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstNum.Location = new System.Drawing.Point(285, 45);
            this.firstNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstNum.Name = "firstNum";
            this.firstNum.Size = new System.Drawing.Size(148, 26);
            this.firstNum.TabIndex = 4;
            // 
            // secondNum
            // 
            this.secondNum.BackColor = System.Drawing.Color.AliceBlue;
            this.secondNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondNum.Location = new System.Drawing.Point(311, 92);
            this.secondNum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secondNum.Name = "secondNum";
            this.secondNum.Size = new System.Drawing.Size(148, 26);
            this.secondNum.TabIndex = 5;
            // 
            // operators
            // 
            this.operators.BackColor = System.Drawing.Color.AliceBlue;
            this.operators.ForeColor = System.Drawing.Color.MidnightBlue;
            this.operators.FormattingEnabled = true;
            this.operators.Location = new System.Drawing.Point(285, 138);
            this.operators.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.operators.MaxDropDownItems = 5;
            this.operators.Name = "operators";
            this.operators.Size = new System.Drawing.Size(180, 28);
            this.operators.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(108, 255);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(108, 598);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 15;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // secondWord
            // 
            this.secondWord.BackColor = System.Drawing.Color.AliceBlue;
            this.secondWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondWord.Location = new System.Drawing.Point(295, 434);
            this.secondWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.secondWord.Name = "secondWord";
            this.secondWord.Size = new System.Drawing.Size(148, 26);
            this.secondWord.TabIndex = 13;
            // 
            // firstWord
            // 
            this.firstWord.BackColor = System.Drawing.Color.AliceBlue;
            this.firstWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstWord.Location = new System.Drawing.Point(269, 390);
            this.firstWord.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstWord.Name = "firstWord";
            this.firstWord.Size = new System.Drawing.Size(148, 26);
            this.firstWord.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(104, 435);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter second words:";
            // 
            // finalWord
            // 
            this.finalWord.AutoSize = true;
            this.finalWord.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.finalWord.ForeColor = System.Drawing.Color.RoyalBlue;
            this.finalWord.Location = new System.Drawing.Point(104, 482);
            this.finalWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.finalWord.Name = "finalWord";
            this.finalWord.Size = new System.Drawing.Size(113, 25);
            this.finalWord.TabIndex = 9;
            this.finalWord.Text = "Enter words";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(104, 388);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 25);
            this.label8.TabIndex = 8;
            this.label8.Text = "Enter first words:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(696, 639);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 16;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OperatorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(843, 703);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.secondWord);
            this.Controls.Add(this.firstWord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.finalWord);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.operators);
            this.Controls.Add(this.secondNum);
            this.Controls.Add(this.firstNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OperatorsForm";
            this.Text = "OperatorsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNum;
        private System.Windows.Forms.TextBox secondNum;
        private System.Windows.Forms.ComboBox operators;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox secondWord;
        private System.Windows.Forms.TextBox firstWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label finalWord;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
    }
}