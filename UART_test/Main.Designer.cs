﻿namespace UART_test
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_connect = new System.Windows.Forms.Button();
            this.comboBox_COMポート = new System.Windows.Forms.ComboBox();
            this.comboBox_ボーレート = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(8, 31);
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.Size = new System.Drawing.Size(158, 19);
            this.textBox_send.TabIndex = 0;
            // 
            // button_send
            // 
            this.button_send.Location = new System.Drawing.Point(213, 29);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(59, 21);
            this.button_send.TabIndex = 1;
            this.button_send.Text = "send";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.Click_send);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(180, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "+\'\\n\'";
            // 
            // button_connect
            // 
            this.button_connect.Location = new System.Drawing.Point(213, 0);
            this.button_connect.Name = "button_connect";
            this.button_connect.Size = new System.Drawing.Size(59, 23);
            this.button_connect.TabIndex = 4;
            this.button_connect.Text = "connect";
            this.button_connect.UseVisualStyleBackColor = true;
            this.button_connect.Click += new System.EventHandler(this.Click_connect);
            // 
            // comboBox_COMポート
            // 
            this.comboBox_COMポート.FormattingEnabled = true;
            this.comboBox_COMポート.Location = new System.Drawing.Point(8, 3);
            this.comboBox_COMポート.Name = "comboBox_COMポート";
            this.comboBox_COMポート.Size = new System.Drawing.Size(76, 20);
            this.comboBox_COMポート.TabIndex = 5;
            this.comboBox_COMポート.Text = "COMポート";
            this.comboBox_COMポート.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged_COMポート);
            // 
            // comboBox_ボーレート
            // 
            this.comboBox_ボーレート.FormattingEnabled = true;
            this.comboBox_ボーレート.Location = new System.Drawing.Point(90, 3);
            this.comboBox_ボーレート.Name = "comboBox_ボーレート";
            this.comboBox_ボーレート.Size = new System.Drawing.Size(76, 20);
            this.comboBox_ボーレート.TabIndex = 6;
            this.comboBox_ボーレート.Text = "ボーレート";
            this.comboBox_ボーレート.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged_ボーレート);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 60);
            this.Controls.Add(this.comboBox_ボーレート);
            this.Controls.Add(this.comboBox_COMポート);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_send);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_connect;
        private System.Windows.Forms.ComboBox comboBox_COMポート;
        private System.Windows.Forms.ComboBox comboBox_ボーレート;
    }
}

