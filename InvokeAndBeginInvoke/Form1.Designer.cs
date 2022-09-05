
namespace InvokeAndBeginInvoke
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.b_Invoke = new System.Windows.Forms.Button();
            this.b_BeginInvoke = new System.Windows.Forms.Button();
            this.b_DelegateBeginInvoke = new System.Windows.Forms.Button();
            this.b_DelegateInvoke = new System.Windows.Forms.Button();
            this.b_DelegateBeginInvokeCallBack = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_Invoke
            // 
            this.b_Invoke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_Invoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Invoke.Location = new System.Drawing.Point(3, 3);
            this.b_Invoke.Name = "b_Invoke";
            this.b_Invoke.Size = new System.Drawing.Size(224, 45);
            this.b_Invoke.TabIndex = 0;
            this.b_Invoke.Text = "Invoke";
            this.b_Invoke.UseVisualStyleBackColor = true;
            this.b_Invoke.Click += new System.EventHandler(this.b_Invoke_Click);
            // 
            // b_BeginInvoke
            // 
            this.b_BeginInvoke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_BeginInvoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_BeginInvoke.Location = new System.Drawing.Point(3, 54);
            this.b_BeginInvoke.Name = "b_BeginInvoke";
            this.b_BeginInvoke.Size = new System.Drawing.Size(224, 45);
            this.b_BeginInvoke.TabIndex = 1;
            this.b_BeginInvoke.Text = "Begin Invoke";
            this.b_BeginInvoke.UseVisualStyleBackColor = true;
            this.b_BeginInvoke.Click += new System.EventHandler(this.b_BeginInvoke_Click);
            // 
            // b_DelegateBeginInvoke
            // 
            this.b_DelegateBeginInvoke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_DelegateBeginInvoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_DelegateBeginInvoke.Location = new System.Drawing.Point(3, 156);
            this.b_DelegateBeginInvoke.Name = "b_DelegateBeginInvoke";
            this.b_DelegateBeginInvoke.Size = new System.Drawing.Size(224, 45);
            this.b_DelegateBeginInvoke.TabIndex = 4;
            this.b_DelegateBeginInvoke.Text = "Delegate : BeginInvoke";
            this.b_DelegateBeginInvoke.UseVisualStyleBackColor = true;
            this.b_DelegateBeginInvoke.Click += new System.EventHandler(this.b_DelegateBeginInvoke_Click);
            // 
            // b_DelegateInvoke
            // 
            this.b_DelegateInvoke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_DelegateInvoke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_DelegateInvoke.Location = new System.Drawing.Point(3, 105);
            this.b_DelegateInvoke.Name = "b_DelegateInvoke";
            this.b_DelegateInvoke.Size = new System.Drawing.Size(224, 45);
            this.b_DelegateInvoke.TabIndex = 3;
            this.b_DelegateInvoke.Text = "Delegate : Invoke";
            this.b_DelegateInvoke.UseVisualStyleBackColor = true;
            this.b_DelegateInvoke.Click += new System.EventHandler(this.b_DelegateInvoke_Click);
            // 
            // b_DelegateBeginInvokeCallBack
            // 
            this.b_DelegateBeginInvokeCallBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b_DelegateBeginInvokeCallBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_DelegateBeginInvokeCallBack.Location = new System.Drawing.Point(3, 207);
            this.b_DelegateBeginInvokeCallBack.Name = "b_DelegateBeginInvokeCallBack";
            this.b_DelegateBeginInvokeCallBack.Size = new System.Drawing.Size(224, 48);
            this.b_DelegateBeginInvokeCallBack.TabIndex = 7;
            this.b_DelegateBeginInvokeCallBack.Text = "Delegate : BeginInvokeCallBack";
            this.b_DelegateBeginInvokeCallBack.UseVisualStyleBackColor = true;
            this.b_DelegateBeginInvokeCallBack.Click += new System.EventHandler(this.b_DelegateBeginInvokeCallBack_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.b_Invoke, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.b_DelegateBeginInvokeCallBack, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.b_BeginInvoke, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.b_DelegateBeginInvoke, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.b_DelegateInvoke, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(230, 258);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(230, 258);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_Invoke;
        private System.Windows.Forms.Button b_BeginInvoke;
        private System.Windows.Forms.Button b_DelegateBeginInvoke;
        private System.Windows.Forms.Button b_DelegateInvoke;
        private System.Windows.Forms.Button b_DelegateBeginInvokeCallBack;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

