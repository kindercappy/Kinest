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
            this.components = new System.ComponentModel.Container();
            this.btnOpenUrl = new System.Windows.Forms.Button();
            this.cbProtocol = new System.Windows.Forms.ComboBox();
            this.btnCloseBrowsers = new System.Windows.Forms.Button();
            this.cbUrl = new System.Windows.Forms.ComboBox();
            this.dgvSitesStoredInfo = new System.Windows.Forms.DataGridView();
            this.siteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protocolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sitesStoredBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kinestDataSet = new Kinest.kinestDataSet();
            this.sitesStoredTableAdapter = new Kinest.kinestDataSetTableAdapters.sitesStoredTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSitesStoredInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitesStoredBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinestDataSet)).BeginInit();
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
            // cbUrl
            // 
            this.cbUrl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUrl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbUrl.FormattingEnabled = true;
            this.cbUrl.Location = new System.Drawing.Point(139, 12);
            this.cbUrl.Name = "cbUrl";
            this.cbUrl.Size = new System.Drawing.Size(121, 21);
            this.cbUrl.TabIndex = 7;
            this.cbUrl.Text = "round.glass";
            this.cbUrl.SelectedIndexChanged += new System.EventHandler(this.cbUrl_SelectedIndexChanged);
            this.cbUrl.TextChanged += new System.EventHandler(this.cbUrl_TextChanged);
            this.cbUrl.Enter += new System.EventHandler(this.cbUrl_Enter);
            this.cbUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbUrl_KeyDown);
            this.cbUrl.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbUrl_KeyUp);
            // 
            // dgvSitesStoredInfo
            // 
            this.dgvSitesStoredInfo.AutoGenerateColumns = false;
            this.dgvSitesStoredInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSitesStoredInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siteIdDataGridViewTextBoxColumn,
            this.protocolDataGridViewTextBoxColumn,
            this.urlDataGridViewTextBoxColumn});
            this.dgvSitesStoredInfo.DataSource = this.sitesStoredBindingSource;
            this.dgvSitesStoredInfo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvSitesStoredInfo.Location = new System.Drawing.Point(12, 52);
            this.dgvSitesStoredInfo.Name = "dgvSitesStoredInfo";
            this.dgvSitesStoredInfo.Size = new System.Drawing.Size(429, 178);
            this.dgvSitesStoredInfo.TabIndex = 8;
            this.dgvSitesStoredInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSitesStoredInfo_CellContentClick);
            // 
            // siteIdDataGridViewTextBoxColumn
            // 
            this.siteIdDataGridViewTextBoxColumn.DataPropertyName = "siteId";
            this.siteIdDataGridViewTextBoxColumn.HeaderText = "siteId";
            this.siteIdDataGridViewTextBoxColumn.Name = "siteIdDataGridViewTextBoxColumn";
            this.siteIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.siteIdDataGridViewTextBoxColumn.Visible = false;
            this.siteIdDataGridViewTextBoxColumn.Width = 190;
            // 
            // protocolDataGridViewTextBoxColumn
            // 
            this.protocolDataGridViewTextBoxColumn.DataPropertyName = "protocol";
            this.protocolDataGridViewTextBoxColumn.HeaderText = "Protocol";
            this.protocolDataGridViewTextBoxColumn.Name = "protocolDataGridViewTextBoxColumn";
            this.protocolDataGridViewTextBoxColumn.Width = 180;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            this.urlDataGridViewTextBoxColumn.DataPropertyName = "url";
            this.urlDataGridViewTextBoxColumn.HeaderText = "URL";
            this.urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            this.urlDataGridViewTextBoxColumn.Width = 180;
            // 
            // sitesStoredBindingSource
            // 
            this.sitesStoredBindingSource.DataMember = "sitesStored";
            this.sitesStoredBindingSource.DataSource = this.kinestDataSet;
            // 
            // kinestDataSet
            // 
            this.kinestDataSet.DataSetName = "kinestDataSet";
            this.kinestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sitesStoredTableAdapter
            // 
            this.sitesStoredTableAdapter.ClearBeforeFill = true;
            // 
            // TestMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSitesStoredInfo);
            this.Controls.Add(this.cbUrl);
            this.Controls.Add(this.btnCloseBrowsers);
            this.Controls.Add(this.cbProtocol);
            this.Controls.Add(this.btnOpenUrl);
            this.Name = "TestMain";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.TestMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSitesStoredInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitesStoredBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kinestDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOpenUrl;
        private System.Windows.Forms.ComboBox cbProtocol;
        private System.Windows.Forms.Button btnCloseBrowsers;
        private System.Windows.Forms.ComboBox cbUrl;
        private System.Windows.Forms.DataGridView dgvSitesStoredInfo;
        private kinestDataSet kinestDataSet;
        private System.Windows.Forms.BindingSource sitesStoredBindingSource;
        private kinestDataSetTableAdapters.sitesStoredTableAdapter sitesStoredTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
    }
}

