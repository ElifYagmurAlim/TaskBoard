
namespace YY
{
    partial class FrmToDoList
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition1 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition2 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableColumnDefinition tableColumnDefinition3 = new DevExpress.XtraEditors.TableLayout.TableColumnDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition3 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.tileView2 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.tileViewColumn6 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn7 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.kartlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cardsDataSet11 = new YY.CardsDataSet1();
            this.tileView3 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colkartNo = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colprojeAd = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colteknikUzman = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.coltarih = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.coltahminiSure = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colgerceklesenSure = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colisAciklama = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colisNot = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn1 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn2 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn3 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn4 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.tileViewColumn5 = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.cardsDataSet1 = new YY.CardsDataSet();
            this.cardsDataSet = new YY.CardsDataSet();
            this.cardsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.durumlarTableAdapter1 = new YY.CardsDataSetTableAdapters.DurumlarTableAdapter();
            this.cardsDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kartlarTableAdapter = new YY.CardsDataSet1TableAdapters.KartlarTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tileView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tileView2
            // 
            this.tileView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tileViewColumn6,
            this.tileViewColumn7});
            this.tileView2.GridControl = this.gridControl1;
            this.tileView2.Name = "tileView2";
            this.tileView2.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.Kanban;
            this.tileView2.OptionsTiles.RowCount = 0;
            this.tileView2.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            // 
            // tileViewColumn6
            // 
            this.tileViewColumn6.Caption = "tileViewColumn6";
            this.tileViewColumn6.MinWidth = 25;
            this.tileViewColumn6.Name = "tileViewColumn6";
            this.tileViewColumn6.Visible = true;
            this.tileViewColumn6.VisibleIndex = 0;
            this.tileViewColumn6.Width = 94;
            // 
            // tileViewColumn7
            // 
            this.tileViewColumn7.Caption = "tileViewColumn7";
            this.tileViewColumn7.MinWidth = 25;
            this.tileViewColumn7.Name = "tileViewColumn7";
            this.tileViewColumn7.Visible = true;
            this.tileViewColumn7.VisibleIndex = 1;
            this.tileViewColumn7.Width = 94;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.kartlarBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "FK_Aciklamalar_Kartlar";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(802, 567);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView3,
            this.tileView1,
            this.tileView2});
            // 
            // kartlarBindingSource
            // 
            this.kartlarBindingSource.DataMember = "Kartlar";
            this.kartlarBindingSource.DataSource = this.cardsDataSet11;
            // 
            // cardsDataSet11
            // 
            this.cardsDataSet11.DataSetName = "CardsDataSet1";
            this.cardsDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tileView3
            // 
            this.tileView3.GridControl = this.gridControl1;
            this.tileView3.Name = "tileView3";
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colkartNo,
            this.colprojeAd,
            this.colteknikUzman,
            this.coltarih,
            this.coltahminiSure,
            this.colgerceklesenSure,
            this.colisAciklama,
            this.colisNot,
            this.tileViewColumn1,
            this.tileViewColumn2,
            this.tileViewColumn3,
            this.tileViewColumn4,
            this.tileViewColumn5});
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsTiles.ItemSize = new System.Drawing.Size(360, 150);
            this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.Kanban;
            this.tileView1.OptionsTiles.RowCount = 0;
            this.tileView1.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            this.tileView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colkartNo, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.tileView1.TileColumns.Add(tableColumnDefinition1);
            this.tileView1.TileColumns.Add(tableColumnDefinition2);
            this.tileView1.TileColumns.Add(tableColumnDefinition3);
            this.tileView1.TileRows.Add(tableRowDefinition1);
            this.tileView1.TileRows.Add(tableRowDefinition2);
            this.tileView1.TileRows.Add(tableRowDefinition3);
            tileViewItemElement1.Column = this.colkartNo;
            tileViewItemElement1.ColumnIndex = 2;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement1.Text = "colkartNo";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.colprojeAd;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement2.Text = "colprojeAd";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Column = this.colteknikUzman;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement3.RowIndex = 1;
            tileViewItemElement3.Text = "colteknikUzman";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.Column = this.coltarih;
            tileViewItemElement4.ColumnIndex = 2;
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileViewItemElement4.RowIndex = 1;
            tileViewItemElement4.Text = "coltarih";
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.TileTemplate.Add(tileViewItemElement2);
            this.tileView1.TileTemplate.Add(tileViewItemElement3);
            this.tileView1.TileTemplate.Add(tileViewItemElement4);
            // 
            // colkartNo
            // 
            this.colkartNo.FieldName = "kartNo";
            this.colkartNo.MinWidth = 25;
            this.colkartNo.Name = "colkartNo";
            this.colkartNo.Visible = true;
            this.colkartNo.VisibleIndex = 0;
            this.colkartNo.Width = 94;
            // 
            // colprojeAd
            // 
            this.colprojeAd.FieldName = "projeAd";
            this.colprojeAd.MinWidth = 25;
            this.colprojeAd.Name = "colprojeAd";
            this.colprojeAd.Visible = true;
            this.colprojeAd.VisibleIndex = 1;
            this.colprojeAd.Width = 94;
            // 
            // colteknikUzman
            // 
            this.colteknikUzman.FieldName = "teknikUzman";
            this.colteknikUzman.MinWidth = 25;
            this.colteknikUzman.Name = "colteknikUzman";
            this.colteknikUzman.Visible = true;
            this.colteknikUzman.VisibleIndex = 2;
            this.colteknikUzman.Width = 94;
            // 
            // coltarih
            // 
            this.coltarih.FieldName = "tarih";
            this.coltarih.MinWidth = 25;
            this.coltarih.Name = "coltarih";
            this.coltarih.Visible = true;
            this.coltarih.VisibleIndex = 3;
            this.coltarih.Width = 94;
            // 
            // coltahminiSure
            // 
            this.coltahminiSure.FieldName = "tahminiSure";
            this.coltahminiSure.MinWidth = 25;
            this.coltahminiSure.Name = "coltahminiSure";
            this.coltahminiSure.Visible = true;
            this.coltahminiSure.VisibleIndex = 4;
            this.coltahminiSure.Width = 94;
            // 
            // colgerceklesenSure
            // 
            this.colgerceklesenSure.FieldName = "gerceklesenSure";
            this.colgerceklesenSure.MinWidth = 25;
            this.colgerceklesenSure.Name = "colgerceklesenSure";
            this.colgerceklesenSure.Visible = true;
            this.colgerceklesenSure.VisibleIndex = 5;
            this.colgerceklesenSure.Width = 94;
            // 
            // colisAciklama
            // 
            this.colisAciklama.FieldName = "isAciklama";
            this.colisAciklama.MinWidth = 25;
            this.colisAciklama.Name = "colisAciklama";
            this.colisAciklama.Visible = true;
            this.colisAciklama.VisibleIndex = 6;
            this.colisAciklama.Width = 94;
            // 
            // colisNot
            // 
            this.colisNot.FieldName = "isNot";
            this.colisNot.MinWidth = 25;
            this.colisNot.Name = "colisNot";
            this.colisNot.Visible = true;
            this.colisNot.VisibleIndex = 7;
            this.colisNot.Width = 94;
            // 
            // tileViewColumn1
            // 
            this.tileViewColumn1.MinWidth = 25;
            this.tileViewColumn1.Name = "tileViewColumn1";
            this.tileViewColumn1.Visible = true;
            this.tileViewColumn1.VisibleIndex = 8;
            this.tileViewColumn1.Width = 94;
            // 
            // tileViewColumn2
            // 
            this.tileViewColumn2.MinWidth = 25;
            this.tileViewColumn2.Name = "tileViewColumn2";
            this.tileViewColumn2.Visible = true;
            this.tileViewColumn2.VisibleIndex = 9;
            this.tileViewColumn2.Width = 94;
            // 
            // tileViewColumn3
            // 
            this.tileViewColumn3.MinWidth = 25;
            this.tileViewColumn3.Name = "tileViewColumn3";
            this.tileViewColumn3.Visible = true;
            this.tileViewColumn3.VisibleIndex = 10;
            this.tileViewColumn3.Width = 94;
            // 
            // tileViewColumn4
            // 
            this.tileViewColumn4.MinWidth = 25;
            this.tileViewColumn4.Name = "tileViewColumn4";
            this.tileViewColumn4.Visible = true;
            this.tileViewColumn4.VisibleIndex = 11;
            this.tileViewColumn4.Width = 94;
            // 
            // tileViewColumn5
            // 
            this.tileViewColumn5.MinWidth = 25;
            this.tileViewColumn5.Name = "tileViewColumn5";
            this.tileViewColumn5.Visible = true;
            this.tileViewColumn5.VisibleIndex = 12;
            this.tileViewColumn5.Width = 94;
            // 
            // cardsDataSet1
            // 
            this.cardsDataSet1.DataSetName = "CardsDataSet";
            this.cardsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardsDataSet
            // 
            this.cardsDataSet.DataSetName = "CardsDataSet";
            this.cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cardsDataSetBindingSource
            // 
            this.cardsDataSetBindingSource.DataSource = this.cardsDataSet;
            this.cardsDataSetBindingSource.Position = 0;
            // 
            // durumlarTableAdapter1
            // 
            this.durumlarTableAdapter1.ClearBeforeFill = true;
            // 
            // cardsDataSet1BindingSource
            // 
            this.cardsDataSet1BindingSource.DataSource = this.cardsDataSet1;
            this.cardsDataSet1BindingSource.Position = 0;
            // 
            // kartlarTableAdapter
            // 
            this.kartlarTableAdapter.ClearBeforeFill = true;
            // 
            // FrmToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 567);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmToDoList";
            this.Text = "ToDoList";
            this.Load += new System.EventHandler(this.FrmToDoList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tileView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cardsDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CardsDataSet cardsDataSet1;
        private CardsDataSet cardsDataSet;
        private System.Windows.Forms.BindingSource cardsDataSetBindingSource;
        private CardsDataSetTableAdapters.DurumlarTableAdapter durumlarTableAdapter1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource cardsDataSet1BindingSource;
        private CardsDataSet1 cardsDataSet11;
        private System.Windows.Forms.BindingSource kartlarBindingSource;
        private CardsDataSet1TableAdapters.KartlarTableAdapter kartlarTableAdapter;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView2;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn6;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView3;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn7;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraGrid.Columns.TileViewColumn colkartNo;
        private DevExpress.XtraGrid.Columns.TileViewColumn colprojeAd;
        private DevExpress.XtraGrid.Columns.TileViewColumn colteknikUzman;
        private DevExpress.XtraGrid.Columns.TileViewColumn coltarih;
        private DevExpress.XtraGrid.Columns.TileViewColumn coltahminiSure;
        private DevExpress.XtraGrid.Columns.TileViewColumn colgerceklesenSure;
        private DevExpress.XtraGrid.Columns.TileViewColumn colisAciklama;
        private DevExpress.XtraGrid.Columns.TileViewColumn colisNot;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn1;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn2;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn3;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn4;
        private DevExpress.XtraGrid.Columns.TileViewColumn tileViewColumn5;
    }
}