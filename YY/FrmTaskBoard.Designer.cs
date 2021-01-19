
namespace YY
{
    partial class FrmTaskBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTaskBoard));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.kartEkle = new DevExpress.XtraBars.BarButtonItem();
            this.listeyiAc = new DevExpress.XtraBars.BarButtonItem();
            this.kartGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.icons = new DevExpress.Utils.ImageCollection(this.components);
            this.Main = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.docManager = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.docManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.kartEkle,
            this.listeyiAc,
            this.kartGuncelle});
            this.ribbon.LargeImages = this.icons;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.Main});
            this.ribbon.Size = new System.Drawing.Size(819, 181);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // kartEkle
            // 
            this.kartEkle.Caption = "Teknik Kart Oluştur";
            this.kartEkle.Id = 5;
            this.kartEkle.ImageOptions.LargeImageIndex = 1;
            this.kartEkle.Name = "kartEkle";
            this.kartEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.kartEkle_ItemClick);
            // 
            // listeyiAc
            // 
            this.listeyiAc.Caption = "Listeyi Aç";
            this.listeyiAc.Id = 8;
            this.listeyiAc.ImageOptions.LargeImageIndex = 0;
            this.listeyiAc.Name = "listeyiAc";
            this.listeyiAc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.listeyiAc_ItemClick);
            // 
            // kartGuncelle
            // 
            this.kartGuncelle.Caption = "Teknik Kart Güncelle";
            this.kartGuncelle.Id = 10;
            this.kartGuncelle.ImageOptions.LargeImageIndex = 2;
            this.kartGuncelle.Name = "kartGuncelle";
            this.kartGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.kartGuncelle_ItemClick);
            // 
            // icons
            // 
            this.icons.ImageSize = new System.Drawing.Size(32, 32);
            this.icons.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icons.ImageStream")));
            this.icons.Images.SetKeyName(0, "iconfinder_server_1287513.png");
            this.icons.Images.SetKeyName(1, "iconfinder_tools_1287509.png");
            this.icons.Images.SetKeyName(2, "asdasd.png");
            // 
            // Main
            // 
            this.Main.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.Main.Name = "Main";
            this.Main.Text = "Main";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.kartEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.kartGuncelle);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Teknik Kart";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.listeyiAc);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "To Do List";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 783);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(819, 29);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
            // 
            // docManager
            // 
            this.docManager.MdiParent = this;
            this.docManager.MenuManager = this.ribbon;
            this.docManager.View = this.tabbedView1;
            this.docManager.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Teknik Kart Oluştur";
            this.barButtonItem1.Id = 5;
            this.barButtonItem1.ImageOptions.LargeImageIndex = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Teknik Kart Oluştur";
            this.barButtonItem2.Id = 5;
            this.barButtonItem2.ImageOptions.LargeImageIndex = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // FrmTaskBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 812);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmTaskBoard.IconOptions.LargeImage")));
            this.IsMdiContainer = true;
            this.Name = "FrmTaskBoard";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Task Board";
            this.Load += new System.EventHandler(this.TaskBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.docManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage Main;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Docking2010.DocumentManager docManager;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem kartEkle;
        private DevExpress.Utils.ImageCollection icons;
        private DevExpress.XtraBars.BarButtonItem listeyiAc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem kartGuncelle;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}