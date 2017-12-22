namespace CalculatorApp
{
    partial class frmCalculator
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
            this.lblFirstInput = new System.Windows.Forms.Label();
            this.txtbox_FirstValue = new System.Windows.Forms.TextBox();
            this.txtbox_SecondValue = new System.Windows.Forms.TextBox();
            this.lblSecondValue = new System.Windows.Forms.Label();
            this.txtbox_Result = new System.Windows.Forms.TextBox();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Subtract = new System.Windows.Forms.Button();
            this.btn_Divide = new System.Windows.Forms.Button();
            this.btn_Multiply = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstInput
            // 
            this.lblFirstInput.AutoSize = true;
            this.lblFirstInput.Location = new System.Drawing.Point(12, 39);
            this.lblFirstInput.Name = "lblFirstInput";
            this.lblFirstInput.Size = new System.Drawing.Size(59, 13);
            this.lblFirstInput.TabIndex = 0;
            this.lblFirstInput.Text = "First Value:";
            // 
            // txtbox_FirstValue
            // 
            this.txtbox_FirstValue.Location = new System.Drawing.Point(88, 36);
            this.txtbox_FirstValue.Name = "txtbox_FirstValue";
            this.txtbox_FirstValue.Size = new System.Drawing.Size(268, 20);
            this.txtbox_FirstValue.TabIndex = 1;
            // 
            // txtbox_SecondValue
            // 
            this.txtbox_SecondValue.Location = new System.Drawing.Point(88, 81);
            this.txtbox_SecondValue.Name = "txtbox_SecondValue";
            this.txtbox_SecondValue.Size = new System.Drawing.Size(268, 20);
            this.txtbox_SecondValue.TabIndex = 3;
            // 
            // lblSecondValue
            // 
            this.lblSecondValue.AutoSize = true;
            this.lblSecondValue.Location = new System.Drawing.Point(12, 84);
            this.lblSecondValue.Name = "lblSecondValue";
            this.lblSecondValue.Size = new System.Drawing.Size(77, 13);
            this.lblSecondValue.TabIndex = 2;
            this.lblSecondValue.Text = "Second Value:";
            // 
            // txtbox_Result
            // 
            this.txtbox_Result.Location = new System.Drawing.Point(88, 117);
            this.txtbox_Result.Name = "txtbox_Result";
            this.txtbox_Result.Size = new System.Drawing.Size(268, 20);
            this.txtbox_Result.TabIndex = 5;
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(12, 120);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(43, 13);
            this.lbl_Result.TabIndex = 4;
            this.lbl_Result.Text = "Result :";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(88, 175);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Subtract
            // 
            this.btn_Subtract.Location = new System.Drawing.Point(179, 166);
            this.btn_Subtract.Name = "btn_Subtract";
            this.btn_Subtract.Size = new System.Drawing.Size(75, 23);
            this.btn_Subtract.TabIndex = 7;
            this.btn_Subtract.Text = "Subtract";
            this.btn_Subtract.UseVisualStyleBackColor = true;
            this.btn_Subtract.Click += new System.EventHandler(this.btn_Subtract_Click);
            // 
            // btn_Divide
            // 
            this.btn_Divide.Location = new System.Drawing.Point(179, 214);
            this.btn_Divide.Name = "btn_Divide";
            this.btn_Divide.Size = new System.Drawing.Size(75, 23);
            this.btn_Divide.TabIndex = 8;
            this.btn_Divide.Text = "Divide";
            this.btn_Divide.UseVisualStyleBackColor = true;
            this.btn_Divide.Click += new System.EventHandler(this.btn_Divide_Click);
            // 
            // btn_Multiply
            // 
            this.btn_Multiply.Location = new System.Drawing.Point(88, 214);
            this.btn_Multiply.Name = "btn_Multiply";
            this.btn_Multiply.Size = new System.Drawing.Size(75, 23);
            this.btn_Multiply.TabIndex = 9;
            this.btn_Multiply.Text = "Multiply";
            this.btn_Multiply.UseVisualStyleBackColor = true;
            this.btn_Multiply.Click += new System.EventHandler(this.btn_Multiply_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Red;
            this.btn_Clear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Clear.Location = new System.Drawing.Point(294, 175);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 62);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 271);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Multiply);
            this.Controls.Add(this.btn_Divide);
            this.Controls.Add(this.btn_Subtract);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txtbox_Result);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.txtbox_SecondValue);
            this.Controls.Add(this.lblSecondValue);
            this.Controls.Add(this.txtbox_FirstValue);
            this.Controls.Add(this.lblFirstInput);
            this.Name = "frmCalculator";
            this.Text = "Calculator Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstInput;
        private System.Windows.Forms.TextBox txtbox_FirstValue;
        private System.Windows.Forms.TextBox txtbox_SecondValue;
        private System.Windows.Forms.Label lblSecondValue;
        private System.Windows.Forms.TextBox txtbox_Result;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Subtract;
        private System.Windows.Forms.Button btn_Divide;
        private System.Windows.Forms.Button btn_Multiply;
        private System.Windows.Forms.Button btn_Clear;
    }
}

