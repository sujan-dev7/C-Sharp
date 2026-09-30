namespace Week4
{
    partial class Form3
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblTotal = new Label();
            lblObtained = new Label();
            lblOutput = new Label();
            btnPercentage = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(287, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(287, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(163, 143);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(97, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Enter Total Marks";
            // 
            // lblObtained
            // 
            lblObtained.AutoSize = true;
            lblObtained.Location = new Point(139, 81);
            lblObtained.Name = "lblObtained";
            lblObtained.Size = new Size(121, 15);
            lblObtained.TabIndex = 6;
            lblObtained.Text = "Enter Marks Obtained";
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(287, 350);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(45, 15);
            lblOutput.TabIndex = 7;
            lblOutput.Text = "Output";
            lblOutput.Visible = false;
            // 
            // btnPercentage
            // 
            btnPercentage.Location = new Point(276, 203);
            btnPercentage.Name = "btnPercentage";
            btnPercentage.Size = new Size(124, 110);
            btnPercentage.TabIndex = 8;
            btnPercentage.Text = "Calculate Percentage";
            btnPercentage.UseVisualStyleBackColor = true;
            btnPercentage.Click += btnPercentage_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 499);
            Controls.Add(btnPercentage);
            Controls.Add(lblOutput);
            Controls.Add(lblObtained);
            Controls.Add(lblTotal);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label lblTotal;
        private Label lblObtained;
        private Label lblOutput;
        private Button btnPercentage;
    }
}