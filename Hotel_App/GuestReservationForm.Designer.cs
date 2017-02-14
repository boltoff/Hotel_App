namespace Hotel_App
{
    partial class GuestReservationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestReservationForm));
            this.tsMyReservationMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.dgvMyReservations = new System.Windows.Forms.DataGridView();
            this.hotel_BaseDataSet = new Hotel_App.Hotel_BaseDataSet();
            this.reservationSelectWhereIdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservationSelectWhereIdTableAdapter = new Hotel_App.Hotel_BaseDataSetTableAdapters.ReservationSelectWhereIdTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestsCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsMyReservationMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_BaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationSelectWhereIdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMyReservationMenu
            // 
            this.tsMyReservationMenu.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tsMyReservationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnClose,
            this.toolStripSeparator1});
            this.tsMyReservationMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMyReservationMenu.Name = "tsMyReservationMenu";
            this.tsMyReservationMenu.Size = new System.Drawing.Size(670, 72);
            this.tsMyReservationMenu.TabIndex = 0;
            this.tsMyReservationMenu.Text = "toolStrip1";
            // 
            // tsbtnClose
            // 
            this.tsbtnClose.Image = global::Hotel_App.Properties.Resources.Close;
            this.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClose.Name = "tsbtnClose";
            this.tsbtnClose.Size = new System.Drawing.Size(54, 69);
            this.tsbtnClose.Text = "Close";
            this.tsbtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 72);
            // 
            // dgvMyReservations
            // 
            this.dgvMyReservations.AllowUserToAddRows = false;
            this.dgvMyReservations.AllowUserToDeleteRows = false;
            this.dgvMyReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMyReservations.AutoGenerateColumns = false;
            this.dgvMyReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMyReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.checkInDateDataGridViewTextBoxColumn,
            this.checkOutDateDataGridViewTextBoxColumn,
            this.guestsCountDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.roomPriceDataGridViewTextBoxColumn,
            this.guestDataGridViewTextBoxColumn});
            this.dgvMyReservations.DataSource = this.reservationSelectWhereIdBindingSource;
            this.dgvMyReservations.Location = new System.Drawing.Point(0, 75);
            this.dgvMyReservations.Name = "dgvMyReservations";
            this.dgvMyReservations.ReadOnly = true;
            this.dgvMyReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyReservations.Size = new System.Drawing.Size(670, 198);
            this.dgvMyReservations.TabIndex = 1;
            // 
            // hotel_BaseDataSet
            // 
            this.hotel_BaseDataSet.DataSetName = "Hotel_BaseDataSet";
            this.hotel_BaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationSelectWhereIdBindingSource
            // 
            this.reservationSelectWhereIdBindingSource.DataMember = "ReservationSelectWhereId";
            this.reservationSelectWhereIdBindingSource.DataSource = this.hotel_BaseDataSet;
            // 
            // reservationSelectWhereIdTableAdapter
            // 
            this.reservationSelectWhereIdTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // checkInDateDataGridViewTextBoxColumn
            // 
            this.checkInDateDataGridViewTextBoxColumn.DataPropertyName = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.HeaderText = "CheckInDate";
            this.checkInDateDataGridViewTextBoxColumn.Name = "checkInDateDataGridViewTextBoxColumn";
            this.checkInDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.checkInDateDataGridViewTextBoxColumn.Width = 95;
            // 
            // checkOutDateDataGridViewTextBoxColumn
            // 
            this.checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.HeaderText = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
            this.checkOutDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.checkOutDateDataGridViewTextBoxColumn.Width = 103;
            // 
            // guestsCountDataGridViewTextBoxColumn
            // 
            this.guestsCountDataGridViewTextBoxColumn.DataPropertyName = "GuestsCount";
            this.guestsCountDataGridViewTextBoxColumn.HeaderText = "GuestsCount";
            this.guestsCountDataGridViewTextBoxColumn.Name = "guestsCountDataGridViewTextBoxColumn";
            this.guestsCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.guestsCountDataGridViewTextBoxColumn.Width = 93;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomDataGridViewTextBoxColumn.Width = 60;
            // 
            // roomPriceDataGridViewTextBoxColumn
            // 
            this.roomPriceDataGridViewTextBoxColumn.DataPropertyName = "Room Price";
            this.roomPriceDataGridViewTextBoxColumn.HeaderText = "Room Price";
            this.roomPriceDataGridViewTextBoxColumn.Name = "roomPriceDataGridViewTextBoxColumn";
            this.roomPriceDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomPriceDataGridViewTextBoxColumn.Width = 87;
            // 
            // guestDataGridViewTextBoxColumn
            // 
            this.guestDataGridViewTextBoxColumn.DataPropertyName = "Guest";
            this.guestDataGridViewTextBoxColumn.HeaderText = "Guest";
            this.guestDataGridViewTextBoxColumn.Name = "guestDataGridViewTextBoxColumn";
            this.guestDataGridViewTextBoxColumn.ReadOnly = true;
            this.guestDataGridViewTextBoxColumn.Width = 60;
            // 
            // GuestReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 285);
            this.Controls.Add(this.dgvMyReservations);
            this.Controls.Add(this.tsMyReservationMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GuestReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Reservations";
            this.Load += new System.EventHandler(this.GuestReservationForm_Load);
            this.tsMyReservationMenu.ResumeLayout(false);
            this.tsMyReservationMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_BaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationSelectWhereIdBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMyReservationMenu;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataGridView dgvMyReservations;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestsCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reservationSelectWhereIdBindingSource;
        private Hotel_BaseDataSet hotel_BaseDataSet;
        private Hotel_BaseDataSetTableAdapters.ReservationSelectWhereIdTableAdapter reservationSelectWhereIdTableAdapter;
    }
}