namespace TipCalculator
{
    partial class Form1
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
            this.Meal_Cst = new System.Windows.Forms.Label();
            this.Fifteen_Lbl = new System.Windows.Forms.Label();
            this.Twenty_Lbl = new System.Windows.Forms.Label();
            this.Input = new System.Windows.Forms.TextBox();
            this.FifteenTtl_Lbl = new System.Windows.Forms.Label();
            this.TwentyTtl_Lbl = new System.Windows.Forms.Label();
            this.Fifteen = new System.Windows.Forms.Label();
            this.Twenty = new System.Windows.Forms.Label();
            this.Fiftotal = new System.Windows.Forms.Label();
            this.Twentotal = new System.Windows.Forms.Label();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Meal_Cst
            // 
            this.Meal_Cst.AutoSize = true;
            this.Meal_Cst.Location = new System.Drawing.Point(7, 15);
            this.Meal_Cst.Name = "Meal_Cst";
            this.Meal_Cst.Size = new System.Drawing.Size(60, 13);
            this.Meal_Cst.TabIndex = 0;
            this.Meal_Cst.Text = "Meal Cost :";
            // 
            // Fifteen_Lbl
            // 
            this.Fifteen_Lbl.AutoSize = true;
            this.Fifteen_Lbl.Location = new System.Drawing.Point(8, 76);
            this.Fifteen_Lbl.Name = "Fifteen_Lbl";
            this.Fifteen_Lbl.Size = new System.Drawing.Size(66, 13);
            this.Fifteen_Lbl.TabIndex = 1;
            this.Fifteen_Lbl.Text = "15% of Cost:";
            this.Fifteen_Lbl.Click += new System.EventHandler(this.Fifteen_Lbl_Click);
            // 
            // Twenty_Lbl
            // 
            this.Twenty_Lbl.AutoSize = true;
            this.Twenty_Lbl.Location = new System.Drawing.Point(8, 117);
            this.Twenty_Lbl.Name = "Twenty_Lbl";
            this.Twenty_Lbl.Size = new System.Drawing.Size(66, 13);
            this.Twenty_Lbl.TabIndex = 2;
            this.Twenty_Lbl.Text = "20% of Cost:";
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(73, 12);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(50, 20);
            this.Input.TabIndex = 3;
            this.Input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            ///http://stackoverflow.com/questions/11984238/detect-enter-key-c-sharp 
            ///used to detect keypress to limit characters allowed in the textbox
            ///Stack Overflow
            ///1/24/2017
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_KeyPress);
            // 
            // FifteenTtl_Lbl
            // 
            this.FifteenTtl_Lbl.AutoSize = true;
            this.FifteenTtl_Lbl.Location = new System.Drawing.Point(153, 76);
            this.FifteenTtl_Lbl.Name = "FifteenTtl_Lbl";
            this.FifteenTtl_Lbl.Size = new System.Drawing.Size(37, 13);
            this.FifteenTtl_Lbl.TabIndex = 4;
            this.FifteenTtl_Lbl.Text = "Total :";
            // 
            // TwentyTtl_Lbl
            // 
            this.TwentyTtl_Lbl.AutoSize = true;
            this.TwentyTtl_Lbl.Location = new System.Drawing.Point(153, 117);
            this.TwentyTtl_Lbl.Name = "TwentyTtl_Lbl";
            this.TwentyTtl_Lbl.Size = new System.Drawing.Size(37, 13);
            this.TwentyTtl_Lbl.TabIndex = 5;
            this.TwentyTtl_Lbl.Text = "Total :";
            // 
            // Fifteen
            // 
            this.Fifteen.AutoSize = true;
            this.Fifteen.Location = new System.Drawing.Point(81, 76);
            this.Fifteen.Name = "Fifteen";
            this.Fifteen.Size = new System.Drawing.Size(34, 13);
            this.Fifteen.TabIndex = 6;
            this.Fifteen.Text = "$0.00";
            // 
            // Twenty
            // 
            this.Twenty.AutoSize = true;
            this.Twenty.Location = new System.Drawing.Point(81, 117);
            this.Twenty.Name = "Twenty";
            this.Twenty.Size = new System.Drawing.Size(34, 13);
            this.Twenty.TabIndex = 7;
            this.Twenty.Text = "$0.00";
            this.Twenty.Click += new System.EventHandler(this.label1_Click);
            // 
            // Fiftotal
            // 
            this.Fiftotal.AutoSize = true;
            this.Fiftotal.Location = new System.Drawing.Point(196, 76);
            this.Fiftotal.Name = "Fiftotal";
            this.Fiftotal.Size = new System.Drawing.Size(34, 13);
            this.Fiftotal.TabIndex = 8;
            this.Fiftotal.Text = "$0.00";
            // 
            // Twentotal
            // 
            this.Twentotal.AutoSize = true;
            this.Twentotal.Location = new System.Drawing.Point(196, 117);
            this.Twentotal.Name = "Twentotal";
            this.Twentotal.Size = new System.Drawing.Size(34, 13);
            this.Twentotal.TabIndex = 9;
            this.Twentotal.Text = "$0.00";
            // 
            // Calculate
            // 
            this.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Calculate.Location = new System.Drawing.Point(155, 12);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 10;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 170);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Twentotal);
            this.Controls.Add(this.Fiftotal);
            this.Controls.Add(this.Twenty);
            this.Controls.Add(this.Fifteen);
            this.Controls.Add(this.TwentyTtl_Lbl);
            this.Controls.Add(this.FifteenTtl_Lbl);
            this.Controls.Add(this.Input);
            this.Controls.Add(this.Twenty_Lbl);
            this.Controls.Add(this.Fifteen_Lbl);
            this.Controls.Add(this.Meal_Cst);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Meal_Cst;
        private System.Windows.Forms.Label Fifteen_Lbl;
        private System.Windows.Forms.Label Twenty_Lbl;
        private System.Windows.Forms.TextBox Input;
        private System.Windows.Forms.Label FifteenTtl_Lbl;
        private System.Windows.Forms.Label TwentyTtl_Lbl;
        private System.Windows.Forms.Label Fifteen;
        private System.Windows.Forms.Label Twenty;
        private System.Windows.Forms.Label Fiftotal;
        private System.Windows.Forms.Label Twentotal;
        private System.Windows.Forms.Button Calculate;
    }
}

