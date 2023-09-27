
namespace RemoteClient
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
            this.inputnum1 = new System.Windows.Forms.TextBox();
            this.inputnum2 = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.Enter_Number_1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnhighestnumber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputnum1
            // 
            this.inputnum1.Location = new System.Drawing.Point(382, 57);
            this.inputnum1.Name = "inputnum1";
            this.inputnum1.Size = new System.Drawing.Size(100, 20);
            this.inputnum1.TabIndex = 0;
            // 
            // inputnum2
            // 
            this.inputnum2.Location = new System.Drawing.Point(382, 135);
            this.inputnum2.Name = "inputnum2";
            this.inputnum2.Size = new System.Drawing.Size(100, 20);
            this.inputnum2.TabIndex = 1;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(382, 343);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 2;
            // 
            // Enter_Number_1
            // 
            this.Enter_Number_1.AutoSize = true;
            this.Enter_Number_1.Location = new System.Drawing.Point(283, 57);
            this.Enter_Number_1.Name = "Enter_Number_1";
            this.Enter_Number_1.Size = new System.Drawing.Size(81, 13);
            this.Enter_Number_1.TabIndex = 3;
            this.Enter_Number_1.Text = "Enter Number 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(283, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Number 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Result";
            // 
            // btnhighestnumber
            // 
            this.btnhighestnumber.Location = new System.Drawing.Point(391, 212);
            this.btnhighestnumber.Name = "btnhighestnumber";
            this.btnhighestnumber.Size = new System.Drawing.Size(75, 23);
            this.btnhighestnumber.TabIndex = 6;
            this.btnhighestnumber.Text = "Click_Me";
            this.btnhighestnumber.UseVisualStyleBackColor = true;
            this.btnhighestnumber.Click += new System.EventHandler(this.btnhighestnumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhighestnumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Enter_Number_1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.inputnum2);
            this.Controls.Add(this.inputnum1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputnum1;
        private System.Windows.Forms.TextBox inputnum2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label Enter_Number_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnhighestnumber;
    }
}

