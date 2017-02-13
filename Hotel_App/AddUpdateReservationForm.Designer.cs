namespace Hotel_App
{
    partial class AddUpdateReservationForm
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
            this.procedures = new Hotel_App.Hotel_BaseDataSetTableAdapters.procedures();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbCheckIn = new System.Windows.Forms.Label();
            this.lbRoomType = new System.Windows.Forms.Label();
            this.lbGuestCount = new System.Windows.Forms.Label();
            this.lbCheckOut = new System.Windows.Forms.Label();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.nudGuestCount = new System.Windows.Forms.NumericUpDown();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.cmbGuest = new System.Windows.Forms.ComboBox();
            this.lbGuest = new System.Windows.Forms.Label();
            this.hotel_BaseDataSet = new Hotel_App.Hotel_BaseDataSet();
            this.roomSelect = new Hotel_App.Hotel_BaseDataSetTableAdapters.RoomSelectTableAdapter();
            this.guestSelect = new Hotel_App.Hotel_BaseDataSetTableAdapters.GuestSelectTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nudGuestCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_BaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(168, 160);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "Add";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(87, 160);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbCheckIn
            // 
            this.lbCheckIn.AutoSize = true;
            this.lbCheckIn.Location = new System.Drawing.Point(24, 29);
            this.lbCheckIn.Name = "lbCheckIn";
            this.lbCheckIn.Size = new System.Drawing.Size(53, 13);
            this.lbCheckIn.TabIndex = 7;
            this.lbCheckIn.Text = "Check In:";
            // 
            // lbRoomType
            // 
            this.lbRoomType.AutoSize = true;
            this.lbRoomType.Location = new System.Drawing.Point(39, 104);
            this.lbRoomType.Name = "lbRoomType";
            this.lbRoomType.Size = new System.Drawing.Size(38, 13);
            this.lbRoomType.TabIndex = 9;
            this.lbRoomType.Text = "Room:";
            // 
            // lbGuestCount
            // 
            this.lbGuestCount.AutoSize = true;
            this.lbGuestCount.Location = new System.Drawing.Point(8, 77);
            this.lbGuestCount.Name = "lbGuestCount";
            this.lbGuestCount.Size = new System.Drawing.Size(69, 13);
            this.lbGuestCount.TabIndex = 10;
            this.lbGuestCount.Text = "Guest Count:";
            // 
            // lbCheckOut
            // 
            this.lbCheckOut.AutoSize = true;
            this.lbCheckOut.Location = new System.Drawing.Point(16, 55);
            this.lbCheckOut.Name = "lbCheckOut";
            this.lbCheckOut.Size = new System.Drawing.Size(61, 13);
            this.lbCheckOut.TabIndex = 11;
            this.lbCheckOut.Text = "Check Out:";
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(83, 23);
            this.dtpCheckIn.MinDate = new System.DateTime(2017, 2, 13, 0, 0, 0, 0);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(157, 20);
            this.dtpCheckIn.TabIndex = 12;
            this.dtpCheckIn.ValueChanged += new System.EventHandler(this.dtpCheckIn_ValueChanged);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOut.Location = new System.Drawing.Point(83, 49);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(157, 20);
            this.dtpCheckOut.TabIndex = 13;
            // 
            // nudGuestCount
            // 
            this.nudGuestCount.Location = new System.Drawing.Point(83, 75);
            this.nudGuestCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudGuestCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudGuestCount.Name = "nudGuestCount";
            this.nudGuestCount.Size = new System.Drawing.Size(157, 20);
            this.nudGuestCount.TabIndex = 14;
            this.nudGuestCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(83, 101);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(157, 21);
            this.cmbRoomType.TabIndex = 15;
            // 
            // cmbGuest
            // 
            this.cmbGuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGuest.FormattingEnabled = true;
            this.cmbGuest.Location = new System.Drawing.Point(83, 128);
            this.cmbGuest.Name = "cmbGuest";
            this.cmbGuest.Size = new System.Drawing.Size(157, 21);
            this.cmbGuest.TabIndex = 16;
            this.cmbGuest.Visible = false;
            // 
            // lbGuest
            // 
            this.lbGuest.AutoSize = true;
            this.lbGuest.Location = new System.Drawing.Point(39, 131);
            this.lbGuest.Name = "lbGuest";
            this.lbGuest.Size = new System.Drawing.Size(38, 13);
            this.lbGuest.TabIndex = 17;
            this.lbGuest.Text = "Guest:";
            this.lbGuest.Visible = false;
            // 
            // hotel_BaseDataSet
            // 
            this.hotel_BaseDataSet.DataSetName = "Hotel_BaseDataSet";
            this.hotel_BaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomSelect
            // 
            this.roomSelect.ClearBeforeFill = true;
            // 
            // guestSelect
            // 
            this.guestSelect.ClearBeforeFill = true;
            // 
            // AddUpdateReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 195);
            this.Controls.Add(this.lbGuest);
            this.Controls.Add(this.cmbGuest);
            this.Controls.Add(this.cmbRoomType);
            this.Controls.Add(this.nudGuestCount);
            this.Controls.Add(this.dtpCheckOut);
            this.Controls.Add(this.dtpCheckIn);
            this.Controls.Add(this.lbCheckOut);
            this.Controls.Add(this.lbGuestCount);
            this.Controls.Add(this.lbRoomType);
            this.Controls.Add(this.lbCheckIn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddUpdateReservationForm";
            this.Text = "Add Reservation";
            this.Load += new System.EventHandler(this.AddUpdateReservationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGuestCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel_BaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Hotel_BaseDataSetTableAdapters.procedures procedures;
        public System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Label lbCheckIn;
        public System.Windows.Forms.Label lbRoomType;
        public System.Windows.Forms.Label lbGuestCount;
        public System.Windows.Forms.Label lbCheckOut;
        public System.Windows.Forms.DateTimePicker dtpCheckIn;
        public System.Windows.Forms.DateTimePicker dtpCheckOut;
        public System.Windows.Forms.NumericUpDown nudGuestCount;
        public System.Windows.Forms.ComboBox cmbRoomType;
        public System.Windows.Forms.ComboBox cmbGuest;
        public System.Windows.Forms.Label lbGuest;
        private Hotel_BaseDataSet hotel_BaseDataSet;
        private Hotel_BaseDataSetTableAdapters.RoomSelectTableAdapter roomSelect;
        private Hotel_BaseDataSetTableAdapters.GuestSelectTableAdapter guestSelect;
    }
}