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
            this.tsReservationMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
            this.tsbtnAddReservation = new System.Windows.Forms.ToolStripButton();
            this.tsbtnUpdateReservation = new System.Windows.Forms.ToolStripButton();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.tsReservationMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
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
            this.tsReservationMenu.Size = new System.Drawing.Size(427, 72);
            this.tsReservationMenu.TabIndex = 0;
            this.tsReservationMenu.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 72);
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
            // 
            // dgvReservations
            // 
            this.dgvReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(0, 75);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.Size = new System.Drawing.Size(427, 228);
            this.dgvReservations.TabIndex = 1;
            // 
            // ReservationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 315);
            this.Controls.Add(this.dgvReservations);
            this.Controls.Add(this.tsReservationMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReservationsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            this.tsReservationMenu.ResumeLayout(false);
            this.tsReservationMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
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
    }
}