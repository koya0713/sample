namespace GitSample
{
    partial class FrmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.txtExpression1 = new System.Windows.Forms.TextBox();
            this.txtExpression2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 22);
            label1.TabIndex = 0;
            label1.Text = "値１";
            // 
            // txtExpression1
            // 
            this.txtExpression1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtExpression1.Location = new System.Drawing.Point(16, 43);
            this.txtExpression1.Name = "txtExpression1";
            this.txtExpression1.Size = new System.Drawing.Size(162, 29);
            this.txtExpression1.TabIndex = 1;
            // 
            // txtExpression2
            // 
            this.txtExpression2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtExpression2.Location = new System.Drawing.Point(205, 43);
            this.txtExpression2.Name = "txtExpression2";
            this.txtExpression2.Size = new System.Drawing.Size(162, 29);
            this.txtExpression2.TabIndex = 3;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtResult.Location = new System.Drawing.Point(16, 186);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(351, 29);
            this.txtResult.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.button1.Location = new System.Drawing.Point(40, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "＋";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.button2.Location = new System.Drawing.Point(118, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 56);
            this.button2.TabIndex = 7;
            this.button2.Text = "－";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.button3.Location = new System.Drawing.Point(197, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(59, 56);
            this.button3.TabIndex = 8;
            this.button3.Text = "✕";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.button4.Location = new System.Drawing.Point(381, 114);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 56);
            this.button4.TabIndex = 9;
            this.button4.Text = "÷";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.button5.Location = new System.Drawing.Point(297, 114);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 56);
            this.button5.TabIndex = 12;
            this.button5.Text = "÷";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 241);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtExpression2);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtExpression1);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExpression1;
        private System.Windows.Forms.TextBox txtExpression2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

