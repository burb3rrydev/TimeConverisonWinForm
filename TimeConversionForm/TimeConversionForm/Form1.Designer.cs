namespace TimeConversionForm
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
            lbSeconds = new Label();
            tbUserInput = new TextBox();
            lbOutput = new Label();
            btnConvert = new Button();
            SuspendLayout();
            // 
            // lbSeconds
            // 
            lbSeconds.AutoSize = true;
            lbSeconds.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lbSeconds.Location = new Point(12, 9);
            lbSeconds.Name = "lbSeconds";
            lbSeconds.Size = new Size(231, 25);
            lbSeconds.TabIndex = 0;
            lbSeconds.Text = "Enter A Number In Seconds";
            // 
            // tbUserInput
            // 
            tbUserInput.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbUserInput.Location = new Point(12, 37);
            tbUserInput.Name = "tbUserInput";
            tbUserInput.Size = new Size(460, 23);
            tbUserInput.TabIndex = 1;
            tbUserInput.TextChanged += tbUserInput_TextChanged;
            // 
            // lbOutput
            // 
            lbOutput.AutoSize = true;
            lbOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbOutput.Location = new Point(12, 97);
            lbOutput.Name = "lbOutput";
            lbOutput.Size = new Size(52, 21);
            lbOutput.TabIndex = 2;
            lbOutput.Text = "label1";
            // 
            // btnConvert
            // 
            btnConvert.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConvert.AutoSize = true;
            btnConvert.ForeColor = SystemColors.InfoText;
            btnConvert.Location = new Point(12, 409);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(460, 40);
            btnConvert.TabIndex = 3;
            btnConvert.Text = "Convert";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(484, 461);
            Controls.Add(btnConvert);
            Controls.Add(lbOutput);
            Controls.Add(tbUserInput);
            Controls.Add(lbSeconds);
            ForeColor = SystemColors.GradientInactiveCaption;
            MinimumSize = new Size(500, 487);
            Name = "Form1";
            Text = "Time Conversion";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSeconds;
        private TextBox tbUserInput;
        private Label lbOutput;
        private Button btnConvert;
    }
}