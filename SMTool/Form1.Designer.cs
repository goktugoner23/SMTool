namespace SMTool
{
    partial class SMTool
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.dateTime_begin = new System.Windows.Forms.DateTimePicker();
            this.dateTime_end = new System.Windows.Forms.DateTimePicker();
            this.btn_accSearch = new System.Windows.Forms.Button();
            this.Label_accname = new System.Windows.Forms.Label();
            this.btn_IntGraph = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_Twitter = new System.Windows.Forms.TabPage();
            this.btn_advSearch = new System.Windows.Forms.Button();
            this.label_advSearch = new System.Windows.Forms.Label();
            this.textBox_advSearch = new System.Windows.Forms.TextBox();
            this.checkBox_Date = new System.Windows.Forms.CheckBox();
            this.dataGrid_Details = new System.Windows.Forms.DataGridView();
            this.label_status = new System.Windows.Forms.Label();
            this.tabPage_Instagram = new System.Windows.Forms.TabPage();
            this.tabPage_LinkedIn = new System.Windows.Forms.TabPage();
            this.Vertex1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vertex2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relationship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tweet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RT_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fav_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interaction_Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewLinkColumn();
            this.tabControl.SuspendLayout();
            this.tabPage_Twitter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Details)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(169, 6);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(216, 20);
            this.textBox_userName.TabIndex = 1;
            // 
            // dateTime_begin
            // 
            this.dateTime_begin.Location = new System.Drawing.Point(169, 35);
            this.dateTime_begin.Name = "dateTime_begin";
            this.dateTime_begin.Size = new System.Drawing.Size(105, 20);
            this.dateTime_begin.TabIndex = 2;
            // 
            // dateTime_end
            // 
            this.dateTime_end.Location = new System.Drawing.Point(280, 35);
            this.dateTime_end.Name = "dateTime_end";
            this.dateTime_end.Size = new System.Drawing.Size(105, 20);
            this.dateTime_end.TabIndex = 3;
            // 
            // btn_accSearch
            // 
            this.btn_accSearch.Location = new System.Drawing.Point(169, 74);
            this.btn_accSearch.Name = "btn_accSearch";
            this.btn_accSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_accSearch.TabIndex = 4;
            this.btn_accSearch.Text = "Search";
            this.btn_accSearch.UseVisualStyleBackColor = true;
            this.btn_accSearch.Click += new System.EventHandler(this.btn_accSearch_Click);
            // 
            // Label_accname
            // 
            this.Label_accname.AutoSize = true;
            this.Label_accname.Location = new System.Drawing.Point(7, 8);
            this.Label_accname.Name = "Label_accname";
            this.Label_accname.Size = new System.Drawing.Size(132, 13);
            this.Label_accname.TabIndex = 5;
            this.Label_accname.Text = "Tweet/Account to search:";
            // 
            // btn_IntGraph
            // 
            this.btn_IntGraph.Location = new System.Drawing.Point(169, 118);
            this.btn_IntGraph.Name = "btn_IntGraph";
            this.btn_IntGraph.Size = new System.Drawing.Size(116, 23);
            this.btn_IntGraph.TabIndex = 8;
            this.btn_IntGraph.Text = "View Interaction Graph";
            this.btn_IntGraph.UseVisualStyleBackColor = true;
            this.btn_IntGraph.Click += new System.EventHandler(this.btn_IntGraph_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_Twitter);
            this.tabControl.Controls.Add(this.tabPage_Instagram);
            this.tabControl.Controls.Add(this.tabPage_LinkedIn);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1391, 648);
            this.tabControl.TabIndex = 9;
            // 
            // tabPage_Twitter
            // 
            this.tabPage_Twitter.Controls.Add(this.btn_advSearch);
            this.tabPage_Twitter.Controls.Add(this.label_advSearch);
            this.tabPage_Twitter.Controls.Add(this.textBox_advSearch);
            this.tabPage_Twitter.Controls.Add(this.checkBox_Date);
            this.tabPage_Twitter.Controls.Add(this.dataGrid_Details);
            this.tabPage_Twitter.Controls.Add(this.label_status);
            this.tabPage_Twitter.Controls.Add(this.btn_IntGraph);
            this.tabPage_Twitter.Controls.Add(this.textBox_userName);
            this.tabPage_Twitter.Controls.Add(this.dateTime_begin);
            this.tabPage_Twitter.Controls.Add(this.dateTime_end);
            this.tabPage_Twitter.Controls.Add(this.Label_accname);
            this.tabPage_Twitter.Controls.Add(this.btn_accSearch);
            this.tabPage_Twitter.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Twitter.Name = "tabPage_Twitter";
            this.tabPage_Twitter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Twitter.Size = new System.Drawing.Size(1383, 622);
            this.tabPage_Twitter.TabIndex = 0;
            this.tabPage_Twitter.Text = "Twitter";
            this.tabPage_Twitter.UseVisualStyleBackColor = true;
            // 
            // btn_advSearch
            // 
            this.btn_advSearch.Location = new System.Drawing.Point(160, 245);
            this.btn_advSearch.Name = "btn_advSearch";
            this.btn_advSearch.Size = new System.Drawing.Size(75, 23);
            this.btn_advSearch.TabIndex = 16;
            this.btn_advSearch.Text = "Search";
            this.btn_advSearch.UseVisualStyleBackColor = true;
            this.btn_advSearch.Click += new System.EventHandler(this.btn_advSearch_Click);
            // 
            // label_advSearch
            // 
            this.label_advSearch.AutoSize = true;
            this.label_advSearch.Location = new System.Drawing.Point(7, 208);
            this.label_advSearch.Name = "label_advSearch";
            this.label_advSearch.Size = new System.Drawing.Size(93, 13);
            this.label_advSearch.TabIndex = 15;
            this.label_advSearch.Text = "Advanced Search";
            // 
            // textBox_advSearch
            // 
            this.textBox_advSearch.Location = new System.Drawing.Point(160, 205);
            this.textBox_advSearch.Name = "textBox_advSearch";
            this.textBox_advSearch.Size = new System.Drawing.Size(216, 20);
            this.textBox_advSearch.TabIndex = 14;
            // 
            // checkBox_Date
            // 
            this.checkBox_Date.AutoSize = true;
            this.checkBox_Date.Location = new System.Drawing.Point(9, 36);
            this.checkBox_Date.Name = "checkBox_Date";
            this.checkBox_Date.Size = new System.Drawing.Size(157, 17);
            this.checkBox_Date.TabIndex = 13;
            this.checkBox_Date.Text = "Get Tweets Between Dates";
            this.checkBox_Date.UseVisualStyleBackColor = true;
            // 
            // dataGrid_Details
            // 
            this.dataGrid_Details.AllowUserToAddRows = false;
            this.dataGrid_Details.AllowUserToDeleteRows = false;
            this.dataGrid_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vertex1,
            this.Vertex2,
            this.Relationship,
            this.Date,
            this.Location,
            this.Tweet,
            this.RT_Count,
            this.Fav_Count,
            this.Interaction_Count,
            this.URL});
            this.dataGrid_Details.Location = new System.Drawing.Point(556, 8);
            this.dataGrid_Details.Name = "dataGrid_Details";
            this.dataGrid_Details.ReadOnly = true;
            this.dataGrid_Details.RowHeadersWidth = 51;
            this.dataGrid_Details.Size = new System.Drawing.Size(798, 551);
            this.dataGrid_Details.TabIndex = 11;
            this.dataGrid_Details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_Details_CellContentClick);
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(553, 584);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(35, 13);
            this.label_status.TabIndex = 10;
            this.label_status.Text = "label1";
            this.label_status.Visible = false;
            // 
            // tabPage_Instagram
            // 
            this.tabPage_Instagram.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Instagram.Name = "tabPage_Instagram";
            this.tabPage_Instagram.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Instagram.Size = new System.Drawing.Size(1383, 622);
            this.tabPage_Instagram.TabIndex = 1;
            this.tabPage_Instagram.Text = "Instagram";
            this.tabPage_Instagram.UseVisualStyleBackColor = true;
            // 
            // tabPage_LinkedIn
            // 
            this.tabPage_LinkedIn.Location = new System.Drawing.Point(4, 22);
            this.tabPage_LinkedIn.Name = "tabPage_LinkedIn";
            this.tabPage_LinkedIn.Size = new System.Drawing.Size(1383, 622);
            this.tabPage_LinkedIn.TabIndex = 2;
            this.tabPage_LinkedIn.Text = "LinkedIn";
            this.tabPage_LinkedIn.UseVisualStyleBackColor = true;
            // 
            // Vertex1
            // 
            this.Vertex1.HeaderText = "User 1";
            this.Vertex1.Name = "Vertex1";
            this.Vertex1.ReadOnly = true;
            // 
            // Vertex2
            // 
            this.Vertex2.HeaderText = "User 2";
            this.Vertex2.Name = "Vertex2";
            this.Vertex2.ReadOnly = true;
            // 
            // Relationship
            // 
            this.Relationship.HeaderText = "Interaction";
            this.Relationship.Name = "Relationship";
            this.Relationship.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Location
            // 
            this.Location.HeaderText = "Location";
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            // 
            // Tweet
            // 
            this.Tweet.HeaderText = "Tweet";
            this.Tweet.Name = "Tweet";
            this.Tweet.ReadOnly = true;
            this.Tweet.Width = 400;
            // 
            // RT_Count
            // 
            this.RT_Count.HeaderText = "RT Count";
            this.RT_Count.Name = "RT_Count";
            this.RT_Count.ReadOnly = true;
            // 
            // Fav_Count
            // 
            this.Fav_Count.HeaderText = "Like Count";
            this.Fav_Count.Name = "Fav_Count";
            this.Fav_Count.ReadOnly = true;
            // 
            // Interaction_Count
            // 
            this.Interaction_Count.HeaderText = "Interaction Type";
            this.Interaction_Count.Name = "Interaction_Count";
            this.Interaction_Count.ReadOnly = true;
            // 
            // URL
            // 
            this.URL.HeaderText = "Url";
            this.URL.Name = "URL";
            this.URL.ReadOnly = true;
            this.URL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.URL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SMTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 726);
            this.Controls.Add(this.tabControl);
            this.Name = "SMTool";
            this.Text = "SMTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SMTool_FormClosing);
            this.Load += new System.EventHandler(this.SMTool_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage_Twitter.ResumeLayout(false);
            this.tabPage_Twitter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Details)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.Button btn_accSearch;
        private System.Windows.Forms.Label Label_accname;
        private System.Windows.Forms.Button btn_IntGraph;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_Twitter;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.TabPage tabPage_Instagram;
        private System.Windows.Forms.TabPage tabPage_LinkedIn;
        public System.Windows.Forms.DateTimePicker dateTime_begin;
        public System.Windows.Forms.DateTimePicker dateTime_end;
        public System.Windows.Forms.CheckBox checkBox_Date;
        public System.Windows.Forms.DataGridView dataGrid_Details;
        private System.Windows.Forms.Button btn_advSearch;
        private System.Windows.Forms.Label label_advSearch;
        private System.Windows.Forms.TextBox textBox_advSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vertex1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vertex2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Relationship;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tweet;
        private System.Windows.Forms.DataGridViewTextBoxColumn RT_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fav_Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interaction_Count;
        private System.Windows.Forms.DataGridViewLinkColumn URL;
    }
}

