
namespace DesignPattern
{
    partial class WinForm
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
            this.b_StrategyPattern = new System.Windows.Forms.Button();
            this.tb_Pattern = new System.Windows.Forms.TextBox();
            this.b_FactoryMethodPattern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_StrategyPattern
            // 
            this.b_StrategyPattern.Location = new System.Drawing.Point(227, 12);
            this.b_StrategyPattern.Name = "b_StrategyPattern";
            this.b_StrategyPattern.Size = new System.Drawing.Size(110, 44);
            this.b_StrategyPattern.TabIndex = 0;
            this.b_StrategyPattern.Text = "Strategy Pattern";
            this.b_StrategyPattern.UseVisualStyleBackColor = true;
            this.b_StrategyPattern.Click += new System.EventHandler(this.b_StrategyPattern_Click);
            // 
            // tb_Pattern
            // 
            this.tb_Pattern.Location = new System.Drawing.Point(12, 12);
            this.tb_Pattern.Multiline = true;
            this.tb_Pattern.Name = "tb_Pattern";
            this.tb_Pattern.Size = new System.Drawing.Size(209, 315);
            this.tb_Pattern.TabIndex = 1;
            // 
            // b_FactoryMethodPattern
            // 
            this.b_FactoryMethodPattern.Location = new System.Drawing.Point(227, 62);
            this.b_FactoryMethodPattern.Name = "b_FactoryMethodPattern";
            this.b_FactoryMethodPattern.Size = new System.Drawing.Size(110, 44);
            this.b_FactoryMethodPattern.TabIndex = 2;
            this.b_FactoryMethodPattern.Text = "Factory Method Pattern";
            this.b_FactoryMethodPattern.UseVisualStyleBackColor = true;
            this.b_FactoryMethodPattern.Click += new System.EventHandler(this.b_FactoryMethodPattern_Click);
            // 
            // WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 340);
            this.Controls.Add(this.b_FactoryMethodPattern);
            this.Controls.Add(this.tb_Pattern);
            this.Controls.Add(this.b_StrategyPattern);
            this.Name = "WinForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_StrategyPattern;
        private System.Windows.Forms.TextBox tb_Pattern;
        private System.Windows.Forms.Button b_FactoryMethodPattern;
    }
}

