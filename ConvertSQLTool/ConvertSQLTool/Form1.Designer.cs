namespace ConvertSQLTool
{
    partial class ConvertSQLTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertSQLTool));
            this.label1 = new System.Windows.Forms.Label();
            this.txtParam = new System.Windows.Forms.TextBox();
            this.txtMae = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAto = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "パラメータ";
            // 
            // txtParam
            // 
            this.txtParam.Location = new System.Drawing.Point(23, 31);
            this.txtParam.MaxLength = 0;
            this.txtParam.Multiline = true;
            this.txtParam.Name = "txtParam";
            this.txtParam.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtParam.Size = new System.Drawing.Size(948, 92);
            this.txtParam.TabIndex = 1;
            this.txtParam.Text = resources.GetString("txtParam.Text");
            // 
            // txtMae
            // 
            this.txtMae.Location = new System.Drawing.Point(23, 149);
            this.txtMae.MaxLength = 0;
            this.txtMae.Multiline = true;
            this.txtMae.Name = "txtMae";
            this.txtMae.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMae.Size = new System.Drawing.Size(398, 466);
            this.txtMae.TabIndex = 3;
            this.txtMae.Text = "SELECT KY40_KSHACD,KY40_INSDATE,KY40_INSTNTCD,KY40_INSAPLID,KY40_UPDAPLDATE,KY40_" +
    "UPDTNTCD,KY40_UPDONLAPLID,KY40_UPDBATAPLID,KY40_KDOFLG FROM MFHKY40_MSYSTEMCTRLT" +
    "BL WHERE KY40_KSHACD = ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(22, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "SQL文";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(356, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "置換前";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(569, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "置換後";
            // 
            // txtAto
            // 
            this.txtAto.Location = new System.Drawing.Point(573, 149);
            this.txtAto.MaxLength = 0;
            this.txtAto.Multiline = true;
            this.txtAto.Name = "txtAto";
            this.txtAto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAto.Size = new System.Drawing.Size(398, 466);
            this.txtAto.TabIndex = 5;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnConvert.Location = new System.Drawing.Point(447, 194);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(105, 41);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "変換";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnClear.Location = new System.Drawing.Point(447, 303);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 41);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "クリア";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Crimson;
            this.label5.Location = new System.Drawing.Point(697, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(274, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "※本ツールはSQL内のパラメータを置換するために設ける。";
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnCopy.Location = new System.Drawing.Point(447, 248);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(105, 41);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "コピー";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // ConvertSQLTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 622);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMae);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtParam);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConvertSQLTool";
            this.Text = "ConvertSQLTool";
            this.Load += new System.EventHandler(this.ConvertSQLTool_Load);
            this.Resize += new System.EventHandler(this.ConvertSQLTool_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParam;
        private System.Windows.Forms.TextBox txtMae;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAto;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCopy;
    }
}

