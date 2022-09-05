
namespace DataBase
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
            this.b_GetData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_執行預存程序 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.b_MSDNEX = new System.Windows.Forms.Button();
            this.b_DataSet = new System.Windows.Forms.Button();
            this.b_DataReader = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // b_GetData
            // 
            this.b_GetData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_GetData.Location = new System.Drawing.Point(14, 14);
            this.b_GetData.Margin = new System.Windows.Forms.Padding(5);
            this.b_GetData.Name = "b_GetData";
            this.b_GetData.Size = new System.Drawing.Size(126, 73);
            this.b_GetData.TabIndex = 0;
            this.b_GetData.Text = "Get data";
            this.b_GetData.UseVisualStyleBackColor = true;
            this.b_GetData.Click += new System.EventHandler(this.button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(148, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(250, 292);
            this.dataGridView1.TabIndex = 1;
            // 
            // b_執行預存程序
            // 
            this.b_執行預存程序.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_執行預存程序.Location = new System.Drawing.Point(14, 322);
            this.b_執行預存程序.Margin = new System.Windows.Forms.Padding(5);
            this.b_執行預存程序.Name = "b_執行預存程序";
            this.b_執行預存程序.Size = new System.Drawing.Size(126, 73);
            this.b_執行預存程序.TabIndex = 2;
            this.b_執行預存程序.Text = "執行預存程序";
            this.b_執行預存程序.UseVisualStyleBackColor = true;
            this.b_執行預存程序.Click += new System.EventHandler(this.button_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(421, 14);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(250, 292);
            this.dataGridView2.TabIndex = 3;
            // 
            // b_MSDNEX
            // 
            this.b_MSDNEX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_MSDNEX.Location = new System.Drawing.Point(14, 414);
            this.b_MSDNEX.Margin = new System.Windows.Forms.Padding(5);
            this.b_MSDNEX.Name = "b_MSDNEX";
            this.b_MSDNEX.Size = new System.Drawing.Size(126, 73);
            this.b_MSDNEX.TabIndex = 4;
            this.b_MSDNEX.Text = "MSDN EX";
            this.b_MSDNEX.UseVisualStyleBackColor = true;
            this.b_MSDNEX.Click += new System.EventHandler(this.b_MSDNEX_Click);
            // 
            // b_DataSet
            // 
            this.b_DataSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_DataSet.Location = new System.Drawing.Point(545, 322);
            this.b_DataSet.Margin = new System.Windows.Forms.Padding(5);
            this.b_DataSet.Name = "b_DataSet";
            this.b_DataSet.Size = new System.Drawing.Size(126, 73);
            this.b_DataSet.TabIndex = 5;
            this.b_DataSet.Text = "DataSet";
            this.b_DataSet.UseVisualStyleBackColor = true;
            this.b_DataSet.Click += new System.EventHandler(this.b_DataSet_Click);
            // 
            // b_DataReader
            // 
            this.b_DataReader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_DataReader.Location = new System.Drawing.Point(545, 414);
            this.b_DataReader.Margin = new System.Windows.Forms.Padding(5);
            this.b_DataReader.Name = "b_DataReader";
            this.b_DataReader.Size = new System.Drawing.Size(126, 73);
            this.b_DataReader.TabIndex = 6;
            this.b_DataReader.Text = "DataReader";
            this.b_DataReader.UseVisualStyleBackColor = true;
            this.b_DataReader.Click += new System.EventHandler(this.b_DataReader_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(689, 507);
            this.Controls.Add(this.b_DataReader);
            this.Controls.Add(this.b_DataSet);
            this.Controls.Add(this.b_MSDNEX);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.b_執行預存程序);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.b_GetData);
            this.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b_GetData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_執行預存程序;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button b_MSDNEX;
        private System.Windows.Forms.Button b_DataSet;
        private System.Windows.Forms.Button b_DataReader;
    }
}

