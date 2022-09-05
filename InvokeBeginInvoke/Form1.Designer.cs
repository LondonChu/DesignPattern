
namespace InvokeBeginInvoke
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
            this.b_Invoke = new System.Windows.Forms.Button();
            this.b_BeginInvoke = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_Invoke
            // 
            this.b_Invoke.BackColor = System.Drawing.Color.White;
            this.b_Invoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Invoke.Location = new System.Drawing.Point(12, 12);
            this.b_Invoke.Name = "b_Invoke";
            this.b_Invoke.Size = new System.Drawing.Size(104, 23);
            this.b_Invoke.TabIndex = 0;
            this.b_Invoke.Text = "Invoke";
            this.b_Invoke.UseVisualStyleBackColor = false;
            this.b_Invoke.Click += new System.EventHandler(this.b_Invoke_Click);
            // 
            // b_BeginInvoke
            // 
            this.b_BeginInvoke.BackColor = System.Drawing.Color.White;
            this.b_BeginInvoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_BeginInvoke.Location = new System.Drawing.Point(12, 45);
            this.b_BeginInvoke.Name = "b_BeginInvoke";
            this.b_BeginInvoke.Size = new System.Drawing.Size(104, 23);
            this.b_BeginInvoke.TabIndex = 1;
            this.b_BeginInvoke.Text = "Begin Invoke";
            this.b_BeginInvoke.UseVisualStyleBackColor = false;
            this.b_BeginInvoke.Click += new System.EventHandler(this.b_BeginInvoke_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 228);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 252);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.b_BeginInvoke);
            this.Controls.Add(this.b_Invoke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_Invoke;
        private System.Windows.Forms.Button b_BeginInvoke;
        private System.Windows.Forms.TextBox textBox1;
    }
}

