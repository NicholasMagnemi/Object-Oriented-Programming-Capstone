namespace Magnemi.MoneyToEnglish.Converter.App
{
    partial class frmMoneyConverterForm
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
            this.lblInputDescription = new System.Windows.Forms.Label();
            this.txtNumberInput = new System.Windows.Forms.TextBox();
            this.lbl_convertedNumberDisplay = new System.Windows.Forms.Label();
            this.btnClearInput = new System.Windows.Forms.Button();
            this.btnConvertNumber = new System.Windows.Forms.Button();
            this.btnExitApplication = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInputDescription
            // 
            this.lblInputDescription.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInputDescription.Location = new System.Drawing.Point(12, 9);
            this.lblInputDescription.Name = "lblInputDescription";
            this.lblInputDescription.Size = new System.Drawing.Size(586, 39);
            this.lblInputDescription.TabIndex = 0;
            this.lblInputDescription.Text = "Please enter your number below:";
            // 
            // txtNumberInput
            // 
            this.txtNumberInput.Font = new System.Drawing.Font("Arial Narrow", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtNumberInput.Location = new System.Drawing.Point(12, 46);
            this.txtNumberInput.Multiline = true;
            this.txtNumberInput.Name = "txtNumberInput";
            this.txtNumberInput.PlaceholderText = "$1,000,000,000.00";
            this.txtNumberInput.Size = new System.Drawing.Size(763, 109);
            this.txtNumberInput.TabIndex = 1;
            this.txtNumberInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumberInput_KeyPress);
            // 
            // lbl_convertedNumberDisplay
            // 
            this.lbl_convertedNumberDisplay.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_convertedNumberDisplay.Location = new System.Drawing.Point(12, 161);
            this.lbl_convertedNumberDisplay.Name = "lbl_convertedNumberDisplay";
            this.lbl_convertedNumberDisplay.Size = new System.Drawing.Size(940, 287);
            this.lbl_convertedNumberDisplay.TabIndex = 2;
            this.lbl_convertedNumberDisplay.Text = "Your number when converted will display here.";
            this.lbl_convertedNumberDisplay.Click += new System.EventHandler(this.lbl_convertedNumberDisplay_Click);
            // 
            // btnClearInput
            // 
            this.btnClearInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClearInput.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearInput.Location = new System.Drawing.Point(12, 489);
            this.btnClearInput.Name = "btnClearInput";
            this.btnClearInput.Size = new System.Drawing.Size(469, 54);
            this.btnClearInput.TabIndex = 3;
            this.btnClearInput.Text = "Clear Input";
            this.btnClearInput.UseVisualStyleBackColor = false;
            this.btnClearInput.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClearInput.MouseLeave += new System.EventHandler(this.btnClearInput_MouseLeave);
            this.btnClearInput.MouseHover += new System.EventHandler(this.btnClearInput_MouseHover);
            // 
            // btnConvertNumber
            // 
            this.btnConvertNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConvertNumber.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvertNumber.Location = new System.Drawing.Point(779, 46);
            this.btnConvertNumber.Name = "btnConvertNumber";
            this.btnConvertNumber.Size = new System.Drawing.Size(177, 107);
            this.btnConvertNumber.TabIndex = 4;
            this.btnConvertNumber.Text = "Convert Number";
            this.btnConvertNumber.UseVisualStyleBackColor = false;
            this.btnConvertNumber.Click += new System.EventHandler(this.btnConvertNumber_Click);
            this.btnConvertNumber.MouseLeave += new System.EventHandler(this.btnConvertNumber_MouseLeave);
            this.btnConvertNumber.MouseHover += new System.EventHandler(this.btnConvertNumber_MouseHover);
            // 
            // btnExitApplication
            // 
            this.btnExitApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExitApplication.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExitApplication.Location = new System.Drawing.Point(489, 489);
            this.btnExitApplication.Name = "btnExitApplication";
            this.btnExitApplication.Size = new System.Drawing.Size(469, 54);
            this.btnExitApplication.TabIndex = 5;
            this.btnExitApplication.Text = "Exit Application";
            this.btnExitApplication.UseVisualStyleBackColor = false;
            this.btnExitApplication.Click += new System.EventHandler(this.btnExitApplication_Click);
            this.btnExitApplication.MouseLeave += new System.EventHandler(this.btnExitApplication_MouseLeave);
            this.btnExitApplication.MouseHover += new System.EventHandler(this.btnExitApplication_MouseHover);
            // 
            // frmMoneyConverterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 550);
            this.Controls.Add(this.btnExitApplication);
            this.Controls.Add(this.btnConvertNumber);
            this.Controls.Add(this.btnClearInput);
            this.Controls.Add(this.lbl_convertedNumberDisplay);
            this.Controls.Add(this.txtNumberInput);
            this.Controls.Add(this.lblInputDescription);
            this.Name = "frmMoneyConverterForm";
            this.Text = "Money to Words";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputDescription;
        private System.Windows.Forms.TextBox txtNumberInput;
        private System.Windows.Forms.Label lbl_convertedNumberDisplay;
        private System.Windows.Forms.Button btnClearInput;
        private System.Windows.Forms.Button btnConvertNumber;
        private System.Windows.Forms.Button btnExitApplication;
    }
}
