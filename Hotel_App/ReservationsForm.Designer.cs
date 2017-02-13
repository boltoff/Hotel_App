namespace Hotel_App
{
    partial class ReservationsForm
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
            this.tsReservationMenu = new System.Windows.Forms.ToolStrip();
            this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnAddReservation = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpdateReservation = new System.Windows.Forms.ToolStripButton();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkInDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkOutDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestsCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_BaseDataSet = new Hotel_App.Hotel_BaseDataSet();
            this.reservationSelectTableAdapter = new Hotel_App.Hotel_BaseDataSetTableAdapters.ReservationSelectTableAdapter();
            this.tsReservationMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_BaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tsReservationMenu
            // 
            this.tsReservationMenu.BackColor = System.Drawing.SystemColors.Control;
            this.tsReservationMenu.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tsReservationMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnClose,
            this.toolStripSeparator1,
            this.tsbtnAddReservation,
            this.tsbtnUpdateReservation});
            this.tsReservationMenu.Location = new System.Drawing.Point(0, 0);
            this.tsReservationMenu.Name = "tsReservationMenu";
            this.tsReservationMenu.Size = new System.Drawing.Size(635, 72);
            this.tsReservationMenu.TabIndex = 0;
            this.tsReservationMenu.Text = "toolStrip1";
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
            // tsbtnAddReservation
            // 
            this.tsbtnAddReservation.Image = global::Hotel_App.Properties.Resources.addreservation;
            this.tsbtnAddReservation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAddReservation.Name = "tsbtnAddReservation";
            this.tsbtnAddReservation.Size = new System.Drawing.Size(97, 69);
            this.tsbtnAddReservation.Text = "Add Reservation";
            this.tsbtnAddReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnUpdateReservation
            // 
            this.tsbtnUpdateReservation.Image = global::Hotel_App.Properties.Resources.updatereservation;
            this.tsbtnUpdateReservation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnUpdateReservation.Name = "tsbtnUpdateReservation";
            this.tsbtnUpdateReservation.Size = new System.Drawing.Size(113, 69);
            this.tsbtnUpdateReservation.Text = "Update Reservation";
            this.tsbtnUpdateReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnUpdateReservation.Click += new System.EventHandler(this.tsbtnUpdateReservation_Click);
            // 
            // dgvReservations
            // 
            this.dgvReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservations.AutoGenerateColumns = false;
            this.dgvReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.checkInDateDataGridViewTextBoxColumn,
            this.checkOutDateDataGridViewTextBoxColumn,
            this.guestsCountDataGridViewTextBoxColumn,
            this.roomDataGridViewTextBoxColumn,
            this.roomPriceDataGridViewTextBoxColumn,
            this.guestDataGridViewTextBoxColumn});
            this.dgvReservations.DataSource = this.reservationSelectBindingSource;
            this.dgvReservations.Location = new System.Drawing.Point(0, 76);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.Size = new System.Drawing.Size(635, 228);
            this.dgvReservations.TabIndex = 1;
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
            this.checkInDateDataGridViewTextBoxColumn.Width = 95;
            // 
            // checkOutDateDataGridViewTextBoxColumn
            // 
            this.checkOutDateDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.HeaderText = "CheckOutDate";
            this.checkOutDateDataGridViewTextBoxColumn.Name = "checkOutDateDataGridViewTextBoxColumn";
            this.checkOutDateDataGridViewTextBoxColumn.Width = 103;
            // 
            // guestsCountDataGridViewTextBoxColumn
            // 
            this.guestsCountDataGridViewTextBoxColumn.DataPropertyName = "GuestsCount";
            this.guestsCountDataGridViewTextBoxColumn.HeaderText = "GuestsCount";
            this.guestsCountDataGridViewTextBoxColumn.Name = "guestsCountDataGridViewTextBoxColumn";
            this.guestsCountDataGridViewTextBoxColumn.Width = 93;
            // 
            // roomDataGridViewTextBoxColumn
            // 
            this.roomDataGridViewTextBoxColumn.DataPropertyName = "Room";
            this.roomDataGridViewTextBoxColumn.HeaderText = "Room";
            this.roomDataGridViewTextBoxColumn.Name = "roomDataGridViewTextBoxColumn";
            this.roomDataGridViewTextBoxColumn.Width = 60;
            // 
            // roomPriceDataGridViewTextBoxColumn
            // 
            this.roomPriceDataGridViewTextBoxColumn.DataPropertyName = "Room Price";
            this.roomPriceDataGridViewTextBoxColumn.HeaderText = "Room Price";
            this.roomPriceDataGridViewTextBoxColumn.Name = "roomPriceDataGridViewTextBoxColumn";
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
            // reservationSelectBindingSource
            // 
            this.reservationSelectBindingSource.DataMember = "ReservationSelect";
            this.reservationSelectBindingSource.DataSource = this.hotel_BaseDataSet;
            // 
            // hotel_BaseDataSet
            // 
            this.hotel_BaseDataSet.DataSetName = "Hotel_BaseDataSet";
            this.hotel_BaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationSelectTableAdapter
            // 
            this.reservationSelectTableAdapter.ClearBeforeFill = true;
            // 
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 317);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.tsReservationMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReservationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.ReservationsForm_Load);
            this.tsReservationMenu.ResumeLayout(false);
            this.tsReservationMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_BaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsReservationMenu;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnAddReservation;
        private System.Windows.Forms.ToolStripButton tsbtnUpdateReservation;
        private System.Windows.Forms.DataGridView dgvReservations;
        private Hotel_BaseDataSet hotel_BaseDataSet;
        private System.Windows.Forms.BindingSource reservationSelectBindingSource;
        private Hotel_BaseDataSetTableAdapters.ReservationSelectTableAdapter reservationSelectTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkInDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkOutDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestsCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestDataGridViewTextBoxColumn;
    }
}