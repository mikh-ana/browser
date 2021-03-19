namespace lab2
{
    partial class browstart
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(browstart));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.goBack = new System.Windows.Forms.ToolStripButton();
            this.goReload = new System.Windows.Forms.ToolStripButton();
            this.finishLoading = new System.Windows.Forms.ToolStripButton();
            this.goForward = new System.Windows.Forms.ToolStripButton();
            this.search = new System.Windows.Forms.ToolStripTextBox();
            this.goSearch = new System.Windows.Forms.ToolStripButton();
            this.addTab = new System.Windows.Forms.ToolStripButton();
            this.deleteTab = new System.Windows.Forms.ToolStripButton();
            this.addFavorites = new System.Windows.Forms.ToolStripButton();
            this.webControl1 = new Awesomium.Windows.Forms.WebControl(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listFavorites = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clearHistory = new System.Windows.Forms.Button();
            this.listHistory = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goBack,
            this.goReload,
            this.finishLoading,
            this.goForward,
            this.search,
            this.goSearch,
            this.addTab,
            this.deleteTab,
            this.addFavorites});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // goBack
            // 
            this.goBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goBack.Image = ((System.Drawing.Image)(resources.GetObject("goBack.Image")));
            this.goBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(23, 22);
            this.goBack.Text = "toolStripButton3";
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // goReload
            // 
            this.goReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goReload.Image = ((System.Drawing.Image)(resources.GetObject("goReload.Image")));
            this.goReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goReload.Name = "goReload";
            this.goReload.Size = new System.Drawing.Size(23, 22);
            this.goReload.Text = "toolStripButton5";
            this.goReload.Click += new System.EventHandler(this.goReload_Click);
            // 
            // finishLoading
            // 
            this.finishLoading.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.finishLoading.Image = ((System.Drawing.Image)(resources.GetObject("finishLoading.Image")));
            this.finishLoading.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.finishLoading.Name = "finishLoading";
            this.finishLoading.Size = new System.Drawing.Size(23, 22);
            this.finishLoading.Text = "toolStripButton8";
            this.finishLoading.Click += new System.EventHandler(this.finishLoading_Click);
            // 
            // goForward
            // 
            this.goForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.goForward.Image = ((System.Drawing.Image)(resources.GetObject("goForward.Image")));
            this.goForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goForward.Name = "goForward";
            this.goForward.Size = new System.Drawing.Size(23, 22);
            this.goForward.Text = "toolStripButton4";
            this.goForward.Click += new System.EventHandler(this.goForward_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(500, 25);
            this.search.Text = "Enter web adress";
            this.search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.toolStripTextBox1_KeyUp);
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // goSearch
            // 
            this.goSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.goSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.goSearch.Checked = true;
            this.goSearch.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.goSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.goSearch.ForeColor = System.Drawing.Color.Black;
            this.goSearch.Image = ((System.Drawing.Image)(resources.GetObject("goSearch.Image")));
            this.goSearch.ImageTransparentColor = System.Drawing.Color.Violet;
            this.goSearch.Name = "goSearch";
            this.goSearch.Size = new System.Drawing.Size(58, 22);
            this.goSearch.Text = "Перейти";
            this.goSearch.Click += new System.EventHandler(this.goSearch_Click);
            // 
            // addTab
            // 
            this.addTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addTab.Image = ((System.Drawing.Image)(resources.GetObject("addTab.Image")));
            this.addTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addTab.Name = "addTab";
            this.addTab.Size = new System.Drawing.Size(23, 22);
            this.addTab.Text = "toolStripButton6";
            this.addTab.Click += new System.EventHandler(this.addTab_Click);
            // 
            // deleteTab
            // 
            this.deleteTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteTab.Image = ((System.Drawing.Image)(resources.GetObject("deleteTab.Image")));
            this.deleteTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteTab.Name = "deleteTab";
            this.deleteTab.Size = new System.Drawing.Size(23, 22);
            this.deleteTab.Text = "toolStripButton2";
            this.deleteTab.Click += new System.EventHandler(this.deleteTab_Click);
            // 
            // addFavorites
            // 
            this.addFavorites.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addFavorites.Image = ((System.Drawing.Image)(resources.GetObject("addFavorites.Image")));
            this.addFavorites.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addFavorites.Name = "addFavorites";
            this.addFavorites.Size = new System.Drawing.Size(23, 22);
            this.addFavorites.Text = "toolStripButton7";
            this.addFavorites.Click += new System.EventHandler(this.addFavorites_Click);
            // 
            // webControl1
            // 
            this.webControl1.Location = new System.Drawing.Point(0, 0);
            this.webControl1.Size = new System.Drawing.Size(0, 0);
            this.webControl1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(621, 425);
            this.tabControl1.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(621, 25);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(179, 425);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listFavorites);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(171, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сохраненные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listFavorites
            // 
            this.listFavorites.ContextMenuStrip = this.contextMenuStrip1;
            this.listFavorites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFavorites.FormattingEnabled = true;
            this.listFavorites.Location = new System.Drawing.Point(3, 3);
            this.listFavorites.Name = "listFavorites";
            this.listFavorites.Size = new System.Drawing.Size(165, 393);
            this.listFavorites.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(118, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.удалитьToolStripMenuItem.Text = "удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clearHistory);
            this.tabPage2.Controls.Add(this.listHistory);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(171, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "История";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clearHistory
            // 
            this.clearHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clearHistory.Location = new System.Drawing.Point(3, 373);
            this.clearHistory.Name = "clearHistory";
            this.clearHistory.Size = new System.Drawing.Size(165, 23);
            this.clearHistory.TabIndex = 2;
            this.clearHistory.Text = "Очистить историю";
            this.clearHistory.UseVisualStyleBackColor = true;
            this.clearHistory.Click += new System.EventHandler(this.clearHistory_Click);
            // 
            // listHistory
            // 
            this.listHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listHistory.FormattingEnabled = true;
            this.listHistory.Location = new System.Drawing.Point(3, 3);
            this.listHistory.Name = "listHistory";
            this.listHistory.Size = new System.Drawing.Size(165, 393);
            this.listHistory.TabIndex = 1;
            // 
            // browstart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "browstart";
            this.Text = "browstart";
            this.Load += new System.EventHandler(this.browstart_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox search;
        private System.Windows.Forms.ToolStripButton goSearch;
        private System.Windows.Forms.ToolStripButton goBack;
        private System.Windows.Forms.ToolStripButton goForward;
        private System.Windows.Forms.ToolStripButton goReload;
        private System.Windows.Forms.ToolStripButton addTab;
        private Awesomium.Windows.Forms.WebControl webControl1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripButton deleteTab;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listFavorites;
        private System.Windows.Forms.ListBox listHistory;
        private System.Windows.Forms.ToolStripButton addFavorites;
        private System.Windows.Forms.ToolStripButton finishLoading;
        private System.Windows.Forms.Button clearHistory;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}

