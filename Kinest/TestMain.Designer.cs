namespace Kinest
{
    partial class TestMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.btnOpenUrl = new System.Windows.Forms.Button();
            this.cbProtocol = new System.Windows.Forms.ComboBox();
            this.btnCloseBrowsers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(139, 12);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(100, 20);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "round.glass";
            // 
            // btnOpenUrl
            // 
            this.btnOpenUrl.Location = new System.Drawing.Point(245, 12);
            this.btnOpenUrl.Name = "btnOpenUrl";
            this.btnOpenUrl.Size = new System.Drawing.Size(75, 23);
            this.btnOpenUrl.TabIndex = 1;
            this.btnOpenUrl.Text = "Open URL";
            this.btnOpenUrl.UseMnemonic = false;
            this.btnOpenUrl.UseVisualStyleBackColor = true;
            this.btnOpenUrl.Click += new System.EventHandler(this.btnOpenUrl_Click);
            // 
            // cbProtocol
            // 
            this.cbProtocol.FormattingEnabled = true;
            this.cbProtocol.Items.AddRange(new object[] {
            "https",
            "http"});
            this.cbProtocol.Location = new System.Drawing.Point(12, 12);
            this.cbProtocol.Name = "cbProtocol";
            this.cbProtocol.Size = new System.Drawing.Size(121, 21);
            this.cbProtocol.TabIndex = 3;
            // 
            // btnCloseBrowsers
            // 
            this.btnCloseBrowsers.Location = new System.Drawing.Point(326, 12);
            this.btnCloseBrowsers.Name = "btnCloseBrowsers";
            this.btnCloseBrowsers.Size = new System.Drawing.Size(87, 23);
            this.btnCloseBrowsers.TabIndex = 4;
            this.btnCloseBrowsers.Text = "Close Browsers";
            this.btnCloseBrowsers.UseVisualStyleBackColor = true;
            this.btnCloseBrowsers.Click += new System.EventHandler(this.btnCloseBrowsers_Click);
            // 
            // TestMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCloseBrowsers);
            this.Controls.Add(this.cbProtocol);
            this.Controls.Add(this.btnOpenUrl);
            this.Controls.Add(this.txtUrl);
            this.Name = "TestMain";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.TestMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnOpenUrl;
        private System.Windows.Forms.ComboBox cbProtocol;
        private System.Windows.Forms.Button btnCloseBrowsers;
    }
}

