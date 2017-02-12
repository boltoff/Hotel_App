namespace Hotel_App
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tsMainMenu = new System.Windows.Forms.ToolStrip();
            this.tssp = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslbUserDesc = new System.Windows.Forms.ToolStripLabel();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxPeopleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.optionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel_BaseDataSet = new Hotel_App.Hotel_BaseDataSet();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.lbDeleteDesc = new System.Windows.Forms.Label();
            this.roomSelectTableAdapter = new Hotel_App.Hotel_BaseDataSetTableAdapters.RoomSelectTableAdapter();
            this.procedures = new Hotel_App.Hotel_BaseDataSetTableAdapters.procedures();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.tsbtnGuests = new System.Windows.Forms.ToolStripButton();
            this.tsbtnReservations = new System.Windows.Forms.ToolStripButton();
            this.tsbtnHistory = new System.Windows.Forms.ToolStripButton();
            this.tsbtnMyReservations = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditProfile = new System.Windows.Forms.ToolStripButton();
            this.tsMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_BaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMainMenu
            // 
            this.tsMainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.tsMainMenu.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.tsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnExit,
            this.tssp,
            this.tsbtnGuests,
            this.tsbtnReservations,
            this.tsbtnHistory,
            this.tsbtnMyReservations,
            this.tsbtnEditProfile,
            this.toolStripSeparator1,
            this.tslbUserDesc});
            this.tsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMainMenu.Name = "tsMainMenu";
            this.tsMainMenu.Size = new System.Drawing.Size(566, 72);
            this.tsMainMenu.TabIndex = 0;
            this.tsMainMenu.Text = "toolStrip1";
            // 
            // tssp
            // 
            this.tssp.Name = "tssp";
            this.tssp.Size = new System.Drawing.Size(6, 72);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 72);
            // 
            // tslbUserDesc
            // 
            this.tslbUserDesc.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.tslbUserDesc.Name = "tslbUserDesc";
            this.tslbUserDesc.Size = new System.Drawing.Size(44, 69);
            this.tslbUserDesc.Text = "null";
            // 
            // dgvRooms
            // 
            this.dgvRooms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRooms.AutoGenerateColumns = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRooms.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvRooms.ColumnHeadersHeight = 26;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.maxPeopleDataGridViewTextBoxColumn,
            this.optionsDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgvRooms.DataSource = this.roomSelectBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRooms.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRooms.GridColor = System.Drawing.SystemColors.Control;
            this.dgvRooms.Location = new System.Drawing.Point(0, 99);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.Size = new System.Drawing.Size(566, 176);
            this.dgvRooms.TabIndex = 1;
            this.dgvRooms.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvRooms_UserDeletedRow);
            this.dgvRooms.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvRooms_UserDeletingRow);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "RoomType";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            this.roomTypeDataGridViewTextBoxColumn.Width = 84;
            // 
            // maxPeopleDataGridViewTextBoxColumn
            // 
            this.maxPeopleDataGridViewTextBoxColumn.DataPropertyName = "MaxPeople";
            this.maxPeopleDataGridViewTextBoxColumn.HeaderText = "MaxPeople";
            this.maxPeopleDataGridViewTextBoxColumn.Name = "maxPeopleDataGridViewTextBoxColumn";
            this.maxPeopleDataGridViewTextBoxColumn.Width = 85;
            // 
            // optionsDataGridViewTextBoxColumn
            // 
            this.optionsDataGridViewTextBoxColumn.DataPropertyName = "Options";
            this.optionsDataGridViewTextBoxColumn.HeaderText = "Options";
            this.optionsDataGridViewTextBoxColumn.Name = "optionsDataGridViewTextBoxColumn";
            this.optionsDataGridViewTextBoxColumn.Width = 68;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 56;
            // 
            // roomSelectBindingSource
            // 
            this.roomSelectBindingSource.DataMember = "RoomSelect";
            this.roomSelectBindingSource.DataSource = this.hotel_BaseDataSet;
            // 
            // hotel_BaseDataSet
            // 
            this.hotel_BaseDataSet.DataSetName = "Hotel_BaseDataSet";
            this.hotel_BaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.AccessibleName = "ChangeRoom";
            this.btnAddRoom.Location = new System.Drawing.Point(391, 75);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(75, 23);
            this.btnAddRoom.TabIndex = 2;
            this.btnAddRoom.Text = "Add Room";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Visible = false;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.AccessibleName = "ChangeRoom";
            this.btnUpdateRoom.Location = new System.Drawing.Point(472, 75);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(82, 23);
            this.btnUpdateRoom.TabIndex = 3;
            this.btnUpdateRoom.Text = "Update Room";
            this.btnUpdateRoom.UseVisualStyleBackColor = true;
            this.btnUpdateRoom.Visible = false;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // lbDeleteDesc
            // 
            this.lbDeleteDesc.AutoSize = true;
            this.lbDeleteDesc.Location = new System.Drawing.Point(13, 80);
            this.lbDeleteDesc.Name = "lbDeleteDesc";
            this.lbDeleteDesc.Size = new System.Drawing.Size(196, 13);
            this.lbDeleteDesc.TabIndex = 4;
            this.lbDeleteDesc.Text = "*select row and press \"Delete\" to delete";
            this.lbDeleteDesc.Visible = false;
            // 
            // roomSelectTableAdapter
            // 
            this.roomSelectTableAdapter.ClearBeforeFill = true;
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbtnExit.Image = global::Hotel_App.Properties.Resources.exit;
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(54, 69);
            this.tsbtnExit.Text = "Exit";
            this.tsbtnExit.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnExit.Click += new System.EventHandler(this.tsbtnExit_Click);
            // 
            // tsbtnGuests
            // 
            this.tsbtnGuests.AccessibleName = "Guests";
            this.tsbtnGuests.Image = global::Hotel_App.Properties.Resources.guests;
            this.tsbtnGuests.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnGuests.Name = "tsbtnGuests";
            this.tsbtnGuests.Size = new System.Drawing.Size(54, 69);
            this.tsbtnGuests.Text = "Guests";
            this.tsbtnGuests.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnGuests.Visible = false;
            this.tsbtnGuests.Click += new System.EventHandler(this.tsbtnGuests_Click);
            // 
            // tsbtnReservations
            // 
            this.tsbtnReservations.AccessibleName = "Reservations";
            this.tsbtnReservations.Image = global::Hotel_App.Properties.Resources.reservations;
            this.tsbtnReservations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnReservations.Name = "tsbtnReservations";
            this.tsbtnReservations.Size = new System.Drawing.Size(77, 69);
            this.tsbtnReservations.Text = "Reservations";
            this.tsbtnReservations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnReservations.Visible = false;
            this.tsbtnReservations.Click += new System.EventHandler(this.tsbtnReservations_Click);
            // 
            // tsbtnHistory
            // 
            this.tsbtnHistory.AccessibleName = "History";
            this.tsbtnHistory.Image = global::Hotel_App.Properties.Resources.history;
            this.tsbtnHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHistory.Name = "tsbtnHistory";
            this.tsbtnHistory.Size = new System.Drawing.Size(54, 69);
            this.tsbtnHistory.Text = "History";
            this.tsbtnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnHistory.Visible = false;
            // 
            // tsbtnMyReservations
            // 
            this.tsbtnMyReservations.AccessibleName = "UserReservations";
            this.tsbtnMyReservations.Image = global::Hotel_App.Properties.Resources.reservations;
            this.tsbtnMyReservations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnMyReservations.Name = "tsbtnMyReservations";
            this.tsbtnMyReservations.Size = new System.Drawing.Size(97, 69);
            this.tsbtnMyReservations.Text = "My Reservations";
            this.tsbtnMyReservations.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnMyReservations.Visible = false;
            // 
            // tsbtnEditProfile
            // 
            this.tsbtnEditProfile.AccessibleName = "EditProfile";
            this.tsbtnEditProfile.Image = global::Hotel_App.Properties.Resources.edit_profile;
            this.tsbtnEditProfile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditProfile.Name = "tsbtnEditProfile";
            this.tsbtnEditProfile.Size = new System.Drawing.Size(68, 69);
            this.tsbtnEditProfile.Text = "Edit Profile";
            this.tsbtnEditProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnEditProfile.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 287);
            this.Controls.Add(this.lbDeleteDesc);
            this.Controls.Add(this.btnUpdateRoom);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.dgvRooms);
            this.Controls.Add(this.tsMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tsMainMenu.ResumeLayout(false);
            this.tsMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_BaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMainMenu;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.ToolStripSeparator tssp;
        private System.Windows.Forms.ToolStripButton tsbtnGuests;
        private System.Windows.Forms.ToolStripButton tsbtnReservations;
        private System.Windows.Forms.ToolStripButton tsbtnHistory;
        private System.Windows.Forms.ToolStripButton tsbtnMyReservations;
        private System.Windows.Forms.ToolStripButton tsbtnEditProfile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tslbUserDesc;
        private System.Windows.Forms.DataGridView dgvRooms;
        private Hotel_BaseDataSet hotel_BaseDataSet;
        private System.Windows.Forms.BindingSource roomSelectBindingSource;
        private Hotel_BaseDataSetTableAdapters.RoomSelectTableAdapter roomSelectTableAdapter;
        private Hotel_BaseDataSetTableAdapters.procedures procedures;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxPeopleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn optionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.Label lbDeleteDesc;
    }
}

