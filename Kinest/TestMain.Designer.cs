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
            this.btnOpenUrl = new System.Windows.Forms.Button();
            this.cbProtocol = new System.Windows.Forms.ComboBox();
            this.btnCloseBrowsers = new System.Windows.Forms.Button();
            this.btnTestSqlInsert = new System.Windows.Forms.Button();
            this.btnShowUrls = new System.Windows.Forms.Button();
            this.cbUrl = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnOpenUrl
            // 
            this.btnOpenUrl.Location = new System.Drawing.Point(273, 12);
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
            this.btnCloseBrowsers.Location = new System.Drawing.Point(354, 12);
            this.btnCloseBrowsers.Name = "btnCloseBrowsers";
            this.btnCloseBrowsers.Size = new System.Drawing.Size(87, 23);
            this.btnCloseBrowsers.TabIndex = 4;
            this.btnCloseBrowsers.Text = "Close Browsers";
            this.btnCloseBrowsers.UseVisualStyleBackColor = true;
            this.btnCloseBrowsers.Click += new System.EventHandler(this.btnCloseBrowsers_Click);
            // 
            // btnTestSqlInsert
            // 
            this.btnTestSqlInsert.Location = new System.Drawing.Point(447, 12);
            this.btnTestSqlInsert.Name = "btnTestSqlInsert";
            this.btnTestSqlInsert.Size = new System.Drawing.Size(87, 23);
            this.btnTestSqlInsert.TabIndex = 5;
            this.btnTestSqlInsert.Text = "Insert URL";
            this.btnTestSqlInsert.UseVisualStyleBackColor = true;
            this.btnTestSqlInsert.Click += new System.EventHandler(this.btnTestSqlInsert_Click);
            // 
            // btnShowUrls
            // 
            this.btnShowUrls.Location = new System.Drawing.Point(540, 12);
            this.btnShowUrls.Name = "btnShowUrls";
            this.btnShowUrls.Size = new System.Drawing.Size(87, 23);
            this.btnShowUrls.TabIndex = 6;
            this.btnShowUrls.Text = "Show URL\'s";
            this.btnShowUrls.UseVisualStyleBackColor = true;
            this.btnShowUrls.Click += new System.EventHandler(this.btnShowUrls_Click);
            // 
            // cbUrl
            // 
            this.cbUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbUrl.FormattingEnabled = true;
            this.cbUrl.Location = new System.Drawing.Point(139, 12);
            this.cbUrl.Name = "cbUrl";
            this.cbUrl.Size = new System.Drawing.Size(121, 21);
            this.cbUrl.TabIndex = 7;
            this.cbUrl.SelectedIndexChanged += new System.EventHandler(this.cbUrl_SelectedIndexChanged);
            this.cbUrl.TextChanged += new System.EventHandler(this.cbUrl_TextChanged);
            this.cbUrl.Enter += new System.EventHandler(this.cbUrl_Enter);
            this.cbUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbUrl_KeyDown);
            this.cbUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbUrl_KeyUp);
            // 
            // TestMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbUrl);
            this.Controls.Add(this.btnShowUrls);
            this.Controls.Add(this.btnTestSqlInsert);
            this.Controls.Add(this.btnCloseBrowsers);
            this.Controls.Add(this.cbProtocol);
            this.Controls.Add(this.btnOpenUrl);
            this.Name = "TestMain";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.TestMain_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOpenUrl;
        private System.Windows.Forms.ComboBox cbProtocol;
        private System.Windows.Forms.Button btnCloseBrowsers;
        private System.Windows.Forms.Button btnTestSqlInsert;
        private System.Windows.Forms.Button btnShowUrls;
        private System.Windows.Forms.ComboBox cbUrl;
    }
}

