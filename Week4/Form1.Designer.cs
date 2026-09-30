namespace Week4
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
            lblTitle = new Label();
            lblCounterValue = new Label();
            btnIncrement = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Britannic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(140, 27);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(433, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Simple Counter Using Button and Label";
            // 
            // lblCounterValue
            // 
            lblCounterValue.AutoSize = true;
            lblCounterValue.Font = new Font("Britannic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCounterValue.Location = new Point(312, 123);
            lblCounterValue.Name = "lblCounterValue";
            lblCounterValue.Size = new Size(35, 36);
            lblCounterValue.TabIndex = 1;
            lblCounterValue.Text = "0";
            // 
            // btnIncrement
            // 
            btnIncrement.Font = new Font("Britannic Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIncrement.Location = new Point(284, 215);
            btnIncrement.Name = "btnIncrement";
            btnIncrement.Size = new Size(112, 59);
            btnIncrement.TabIndex = 2;
            btnIncrement.Text = "Click Me";
            btnIncrement.UseVisualStyleBackColor = true;
            btnIncrement.Click += btnIncrement_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 484);
            Controls.Add(btnIncrement);
            Controls.Add(lblCounterValue);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCounterValue;
        private Button btnIncrement;
    }
}
