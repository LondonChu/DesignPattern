
namespace Timer
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
            this.components = new System.ComponentModel.Container();
            this.FormTimer = new System.Windows.Forms.Timer(this.components);
            this.b_FormTimerStart = new System.Windows.Forms.Button();
            this.b_FormTimerStop = new System.Windows.Forms.Button();
            this.l_FormTimer = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.b_SystemTimerStop = new System.Windows.Forms.Button();
            this.l_SystemTimer = new System.Windows.Forms.Label();
            this.b_SystemTimerStart = new System.Windows.Forms.Button();
            this.l_SystemThreadingTimer = new System.Windows.Forms.Label();
            this.b_SystemThreadingTimerStart = new System.Windows.Forms.Button();
            this.b_SystemThreadingTimerStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormTimer
            // 
            this.FormTimer.Tick += new System.EventHandler(this.FormTimer_Tick);
            // 
            // b_FormTimerStart
            // 
            this.b_FormTimerStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_FormTimerStart.BackColor = System.Drawing.Color.White;
            this.b_FormTimerStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_FormTimerStart.Location = new System.Drawing.Point(192, 6);
            this.b_FormTimerStart.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.b_FormTimerStart.Name = "b_FormTimerStart";
            this.b_FormTimerStart.Size = new System.Drawing.Size(123, 38);
            this.b_FormTimerStart.TabIndex = 0;
            this.b_FormTimerStart.Text = "Start";
            this.b_FormTimerStart.UseVisualStyleBackColor = false;
            this.b_FormTimerStart.Click += new System.EventHandler(this.b_FormTimerStart_Click);
            // 
            // b_FormTimerStop
            // 
            this.b_FormTimerStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_FormTimerStop.BackColor = System.Drawing.Color.White;
            this.b_FormTimerStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_FormTimerStop.Location = new System.Drawing.Point(321, 6);
            this.b_FormTimerStop.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.b_FormTimerStop.Name = "b_FormTimerStop";
            this.b_FormTimerStop.Size = new System.Drawing.Size(123, 38);
            this.b_FormTimerStop.TabIndex = 1;
            this.b_FormTimerStop.Text = "Stop";
            this.b_FormTimerStop.UseVisualStyleBackColor = false;
            this.b_FormTimerStop.Click += new System.EventHandler(this.b_FormTimerStop_Click);
            // 
            // l_FormTimer
            // 
            this.l_FormTimer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_FormTimer.AutoSize = true;
            this.l_FormTimer.Location = new System.Drawing.Point(3, 15);
            this.l_FormTimer.Name = "l_FormTimer";
            this.l_FormTimer.Size = new System.Drawing.Size(91, 20);
            this.l_FormTimer.TabIndex = 2;
            this.l_FormTimer.Text = "FormTimer";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.button4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.b_SystemThreadingTimerStop, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.b_SystemThreadingTimerStart, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.l_SystemThreadingTimer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.b_SystemTimerStop, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.l_SystemTimer, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.b_SystemTimerStart, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.l_FormTimer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.b_FormTimerStop, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.b_FormTimerStart, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(452, 199);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // b_SystemTimerStop
            // 
            this.b_SystemTimerStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_SystemTimerStop.BackColor = System.Drawing.Color.White;
            this.b_SystemTimerStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_SystemTimerStop.Location = new System.Drawing.Point(321, 56);
            this.b_SystemTimerStop.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.b_SystemTimerStop.Name = "b_SystemTimerStop";
            this.b_SystemTimerStop.Size = new System.Drawing.Size(123, 38);
            this.b_SystemTimerStop.TabIndex = 5;
            this.b_SystemTimerStop.Text = "Stop";
            this.b_SystemTimerStop.UseVisualStyleBackColor = false;
            this.b_SystemTimerStop.Click += new System.EventHandler(this.b_SystemTimerStop_Click);
            // 
            // l_SystemTimer
            // 
            this.l_SystemTimer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_SystemTimer.AutoSize = true;
            this.l_SystemTimer.Location = new System.Drawing.Point(3, 65);
            this.l_SystemTimer.Name = "l_SystemTimer";
            this.l_SystemTimer.Size = new System.Drawing.Size(106, 20);
            this.l_SystemTimer.TabIndex = 4;
            this.l_SystemTimer.Text = "SystemTimer";
            // 
            // b_SystemTimerStart
            // 
            this.b_SystemTimerStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_SystemTimerStart.BackColor = System.Drawing.Color.White;
            this.b_SystemTimerStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_SystemTimerStart.Location = new System.Drawing.Point(192, 56);
            this.b_SystemTimerStart.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.b_SystemTimerStart.Name = "b_SystemTimerStart";
            this.b_SystemTimerStart.Size = new System.Drawing.Size(123, 38);
            this.b_SystemTimerStart.TabIndex = 4;
            this.b_SystemTimerStart.Text = "Start";
            this.b_SystemTimerStart.UseVisualStyleBackColor = false;
            this.b_SystemTimerStart.Click += new System.EventHandler(this.b_SystemTimerStart_Click);
            // 
            // l_SystemThreadingTimer
            // 
            this.l_SystemThreadingTimer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.l_SystemThreadingTimer.AutoSize = true;
            this.l_SystemThreadingTimer.Location = new System.Drawing.Point(3, 115);
            this.l_SystemThreadingTimer.Name = "l_SystemThreadingTimer";
            this.l_SystemThreadingTimer.Size = new System.Drawing.Size(183, 20);
            this.l_SystemThreadingTimer.TabIndex = 5;
            this.l_SystemThreadingTimer.Text = "SystemThreadingTimer";
            // 
            // b_SystemThreadingTimerStart
            // 
            this.b_SystemThreadingTimerStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_SystemThreadingTimerStart.BackColor = System.Drawing.Color.White;
            this.b_SystemThreadingTimerStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_SystemThreadingTimerStart.Location = new System.Drawing.Point(192, 106);
            this.b_SystemThreadingTimerStart.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.b_SystemThreadingTimerStart.Name = "b_SystemThreadingTimerStart";
            this.b_SystemThreadingTimerStart.Size = new System.Drawing.Size(123, 38);
            this.b_SystemThreadingTimerStart.TabIndex = 5;
            this.b_SystemThreadingTimerStart.Text = "Start";
            this.b_SystemThreadingTimerStart.UseVisualStyleBackColor = false;
            this.b_SystemThreadingTimerStart.Click += new System.EventHandler(this.b_SystemThreadingTimerStart_Click);
            // 
            // b_SystemThreadingTimerStop
            // 
            this.b_SystemThreadingTimerStop.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.b_SystemThreadingTimerStop.BackColor = System.Drawing.Color.White;
            this.b_SystemThreadingTimerStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_SystemThreadingTimerStop.Location = new System.Drawing.Point(321, 106);
            this.b_SystemThreadingTimerStop.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.b_SystemThreadingTimerStop.Name = "b_SystemThreadingTimerStop";
            this.b_SystemThreadingTimerStop.Size = new System.Drawing.Size(123, 38);
            this.b_SystemThreadingTimerStop.TabIndex = 6;
            this.b_SystemThreadingTimerStop.Text = "Stop";
            this.b_SystemThreadingTimerStop.UseVisualStyleBackColor = false;
            this.b_SystemThreadingTimerStop.Click += new System.EventHandler(this.b_SystemThreadingTimerStop_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "SystemTimer";
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(192, 156);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(123, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "Start";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(321, 156);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(123, 38);
            this.button4.TabIndex = 8;
            this.button4.Text = "Stop";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(478, 228);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer FormTimer;
        private System.Windows.Forms.Button b_FormTimerStart;
        private System.Windows.Forms.Button b_FormTimerStop;
        private System.Windows.Forms.Label l_FormTimer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label l_SystemTimer;
        private System.Windows.Forms.Button b_SystemTimerStop;
        private System.Windows.Forms.Button b_SystemTimerStart;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_SystemThreadingTimerStop;
        private System.Windows.Forms.Button b_SystemThreadingTimerStart;
        private System.Windows.Forms.Label l_SystemThreadingTimer;
    }
}

