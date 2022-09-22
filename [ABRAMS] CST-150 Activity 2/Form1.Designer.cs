namespace _ABRAMS__CST_150_Activity_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.earthWeightInput = new System.Windows.Forms.TextBox();
            this.marsWeightOutput = new System.Windows.Forms.TextBox();
            this.readInputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your weight on Earth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Your weight on Mars";
            // 
            // earthWeightInput
            // 
            this.earthWeightInput.Location = new System.Drawing.Point(174, 6);
            this.earthWeightInput.Name = "earthWeightInput";
            this.earthWeightInput.Size = new System.Drawing.Size(100, 23);
            this.earthWeightInput.TabIndex = 2;
            // 
            // marsWeightOutput
            // 
            this.marsWeightOutput.Enabled = false;
            this.marsWeightOutput.Location = new System.Drawing.Point(174, 35);
            this.marsWeightOutput.Name = "marsWeightOutput";
            this.marsWeightOutput.Size = new System.Drawing.Size(100, 23);
            this.marsWeightOutput.TabIndex = 3;
            // 
            // readInputButton
            // 
            this.readInputButton.Location = new System.Drawing.Point(199, 64);
            this.readInputButton.Name = "readInputButton";
            this.readInputButton.Size = new System.Drawing.Size(75, 23);
            this.readInputButton.TabIndex = 4;
            this.readInputButton.Text = "Convert";
            this.readInputButton.UseVisualStyleBackColor = true;
            this.readInputButton.Click += new System.EventHandler(this.readInputButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 94);
            this.Controls.Add(this.readInputButton);
            this.Controls.Add(this.marsWeightOutput);
            this.Controls.Add(this.earthWeightInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "[ABRAMS] CST-150 Activity 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox earthWeightInput;
        private TextBox marsWeightOutput;
        private Button readInputButton;
    }
}