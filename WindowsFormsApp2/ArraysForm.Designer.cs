namespace WindowsFormsApp2
{
    partial class ArraysForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.numToLocate = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Locate = new System.Windows.Forms.Button();
            this.smallestResult = new System.Windows.Forms.Label();
            this.largestResult = new System.Windows.Forms.Label();
            this.containsResult = new System.Windows.Forms.Label();
            this.sumResult = new System.Windows.Forms.Label();
            this.meanResult = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.headerLabel1 = new System.Windows.Forms.Label();
            this.headerLabel2 = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(125)))));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Array of numbers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter a number to locate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter a number:";
            // 
            // num
            // 
            this.num.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.Location = new System.Drawing.Point(169, 58);
            this.num.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(148, 31);
            this.num.TabIndex = 3;
            // 
            // numToLocate
            // 
            this.numToLocate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.numToLocate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numToLocate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numToLocate.Location = new System.Drawing.Point(239, 102);
            this.numToLocate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numToLocate.Name = "numToLocate";
            this.numToLocate.Size = new System.Drawing.Size(148, 31);
            this.numToLocate.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(348, 55);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(112, 35);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Locate
            // 
            this.Locate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Locate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Locate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Locate.ForeColor = System.Drawing.Color.White;
            this.Locate.Location = new System.Drawing.Point(410, 99);
            this.Locate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Locate.Name = "Locate";
            this.Locate.Size = new System.Drawing.Size(112, 35);
            this.Locate.TabIndex = 6;
            this.Locate.Text = "Locate";
            this.Locate.UseVisualStyleBackColor = false;
            this.Locate.Click += new System.EventHandler(this.Locate_Click);
            // 
            // smallestResult
            // 
            this.smallestResult.AutoSize = true;
            this.smallestResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smallestResult.Location = new System.Drawing.Point(20, 220);
            this.smallestResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.smallestResult.Name = "smallestResult";
            this.smallestResult.Size = new System.Drawing.Size(207, 25);
            this.smallestResult.TabIndex = 7;
            this.smallestResult.Text = "The smallest number is__";
            // 
            // largestResult
            // 
            this.largestResult.AutoSize = true;
            this.largestResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.largestResult.Location = new System.Drawing.Point(20, 185);
            this.largestResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.largestResult.Name = "largestResult";
            this.largestResult.Size = new System.Drawing.Size(196, 25);
            this.largestResult.TabIndex = 8;
            this.largestResult.Text = "The largest number is__";
            // 
            // containsResult
            // 
            this.containsResult.AutoSize = true;
            this.containsResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.containsResult.Location = new System.Drawing.Point(20, 150);
            this.containsResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.containsResult.Name = "containsResult";
            this.containsResult.Size = new System.Drawing.Size(417, 25);
            this.containsResult.TabIndex = 9;
            this.containsResult.Text = "Number__is an element/not an element of the array";
            // 
            // sumResult
            // 
            this.sumResult.AutoSize = true;
            this.sumResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumResult.Location = new System.Drawing.Point(404, 185);
            this.sumResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sumResult.Name = "sumResult";
            this.sumResult.Size = new System.Drawing.Size(206, 25);
            this.sumResult.TabIndex = 11;
            this.sumResult.Text = "The sum of the array is__";
            // 
            // meanResult
            // 
            this.meanResult.AutoSize = true;
            this.meanResult.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meanResult.Location = new System.Drawing.Point(404, 220);
            this.meanResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.meanResult.Name = "meanResult";
            this.meanResult.Size = new System.Drawing.Size(216, 25);
            this.meanResult.TabIndex = 10;
            this.meanResult.Text = "The mean of the array is__";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 193);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(345, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "_is an element/not an element of the array";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(404, 193);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(250, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "There are __ words in the array";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(389, 101);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Locate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(348, 55);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(218, 104);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 31);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(169, 58);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(148, 31);
            this.textBox4.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 58);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Enter a word:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 104);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 25);
            this.label12.TabIndex = 13;
            this.label12.Text = "Enter a word to locate:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(125)))));
            this.label13.Location = new System.Drawing.Point(20, 15);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 28);
            this.label13.TabIndex = 12;
            this.label13.Text = "Array of words";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(125)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(581, 699);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 38);
            this.button3.TabIndex = 21;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Calculate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.num);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numToLocate);
            this.panel1.Controls.Add(this.Locate);
            this.panel1.Controls.Add(this.containsResult);
            this.panel1.Controls.Add(this.largestResult);
            this.panel1.Controls.Add(this.smallestResult);
            this.panel1.Controls.Add(this.meanResult);
            this.panel1.Controls.Add(this.sumResult);
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 260);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.textBox4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(20, 360);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(680, 260);
            this.panel2.TabIndex = 24;
            // 
            // headerLabel1
            // 
            this.headerLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(125)))));
            this.headerLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel1.ForeColor = System.Drawing.Color.White;
            this.headerLabel1.Location = new System.Drawing.Point(0, 0);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.headerLabel1.Size = new System.Drawing.Size(716, 40);
            this.headerLabel1.TabIndex = 22;
            this.headerLabel1.Text = "Array Operations Dashboard";
            this.headerLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // headerLabel2
            // 
            this.headerLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(55)))), ((int)(((byte)(125)))));
            this.headerLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel2.ForeColor = System.Drawing.Color.White;
            this.headerLabel2.Location = new System.Drawing.Point(0, 0);
            this.headerLabel2.Name = "headerLabel2";
            this.headerLabel2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.headerLabel2.Size = new System.Drawing.Size(716, 40);
            this.headerLabel2.TabIndex = 22;
            this.headerLabel2.Text = "Word Operations";
            this.headerLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.ForeColor = System.Drawing.Color.White;
            this.Calculate.Location = new System.Drawing.Point(542, 140);
            this.Calculate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(112, 35);
            this.Calculate.TabIndex = 12;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // ArraysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(716, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.headerLabel1);
            this.Controls.Add(this.button3);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ArraysForm";
            this.Text = "Array Operations";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.TextBox numToLocate;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Locate;
        private System.Windows.Forms.Label smallestResult;
        private System.Windows.Forms.Label largestResult;
        private System.Windows.Forms.Label containsResult;
        private System.Windows.Forms.Label sumResult;
        private System.Windows.Forms.Label meanResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label headerLabel1;
        private System.Windows.Forms.Label headerLabel2;
        private System.Windows.Forms.Button Calculate;
    }
}