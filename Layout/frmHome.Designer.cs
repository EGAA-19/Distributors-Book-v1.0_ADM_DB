namespace Layout
{
    partial class frmHome
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnMinisizeWindows = new FontAwesome.Sharp.IconButton();
            this.btnCloseWindows = new FontAwesome.Sharp.IconButton();
            this.dgvDistributors = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Representative = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transport = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtNameCompany = new System.Windows.Forms.TextBox();
            this.btnSearchDistributor = new FontAwesome.Sharp.IconButton();
            this.btnNewDistributor = new FontAwesome.Sharp.IconButton();
            this.btnEditDistributor = new FontAwesome.Sharp.IconButton();
            this.btnDeleteDsitributor = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistributors)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnMinisizeWindows);
            this.panel1.Controls.Add(this.btnCloseWindows);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 30);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(163, 30);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(78)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distributors Book v1.0";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(78)))), ((int)(((byte)(49)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(78)))), ((int)(((byte)(49)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 25;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 30);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnMinisizeWindows
            // 
            this.btnMinisizeWindows.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinisizeWindows.FlatAppearance.BorderSize = 0;
            this.btnMinisizeWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinisizeWindows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(78)))), ((int)(((byte)(49)))));
            this.btnMinisizeWindows.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinisizeWindows.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(78)))), ((int)(((byte)(49)))));
            this.btnMinisizeWindows.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinisizeWindows.IconSize = 30;
            this.btnMinisizeWindows.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMinisizeWindows.Location = new System.Drawing.Point(476, 0);
            this.btnMinisizeWindows.Name = "btnMinisizeWindows";
            this.btnMinisizeWindows.Size = new System.Drawing.Size(30, 30);
            this.btnMinisizeWindows.TabIndex = 2;
            this.btnMinisizeWindows.UseVisualStyleBackColor = true;
            this.btnMinisizeWindows.Click += new System.EventHandler(this.btnMinisizeWindows_Click);
            // 
            // btnCloseWindows
            // 
            this.btnCloseWindows.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseWindows.FlatAppearance.BorderSize = 0;
            this.btnCloseWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindows.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCloseWindows.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(78)))), ((int)(((byte)(49)))));
            this.btnCloseWindows.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseWindows.IconSize = 23;
            this.btnCloseWindows.Location = new System.Drawing.Point(506, 0);
            this.btnCloseWindows.Name = "btnCloseWindows";
            this.btnCloseWindows.Size = new System.Drawing.Size(30, 30);
            this.btnCloseWindows.TabIndex = 0;
            this.btnCloseWindows.UseVisualStyleBackColor = true;
            this.btnCloseWindows.Click += new System.EventHandler(this.btnCloseWindows_Click);
            // 
            // dgvDistributors
            // 
            this.dgvDistributors.AllowUserToAddRows = false;
            this.dgvDistributors.AllowUserToDeleteRows = false;
            this.dgvDistributors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDistributors.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDistributors.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(226)))));
            this.dgvDistributors.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDistributors.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(14)))), ((int)(((byte)(2)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDistributors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDistributors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDistributors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Company,
            this.Phone,
            this.Representative,
            this.Email,
            this.City,
            this.Adress,
            this.Transport});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(78)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(185)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDistributors.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDistributors.EnableHeadersVisualStyles = false;
            this.dgvDistributors.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(21)))), ((int)(((byte)(4)))));
            this.dgvDistributors.Location = new System.Drawing.Point(12, 91);
            this.dgvDistributors.Name = "dgvDistributors";
            this.dgvDistributors.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(78)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(226)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDistributors.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDistributors.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDistributors.Size = new System.Drawing.Size(511, 247);
            this.dgvDistributors.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 45;
            // 
            // Company
            // 
            this.Company.DataPropertyName = "Company";
            this.Company.HeaderText = "Company";
            this.Company.Name = "Company";
            this.Company.ReadOnly = true;
            this.Company.Width = 90;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            this.Phone.Width = 71;
            // 
            // Representative
            // 
            this.Representative.DataPropertyName = "Representative";
            this.Representative.HeaderText = "Representative";
            this.Representative.Name = "Representative";
            this.Representative.ReadOnly = true;
            this.Representative.Width = 123;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 66;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 56;
            // 
            // Adress
            // 
            this.Adress.DataPropertyName = "Adress";
            this.Adress.HeaderText = "Adress";
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Width = 73;
            // 
            // Transport
            // 
            this.Transport.DataPropertyName = "Transport";
            this.Transport.HeaderText = "Transport";
            this.Transport.Name = "Transport";
            this.Transport.ReadOnly = true;
            this.Transport.Width = 73;
            // 
            // txtNameCompany
            // 
            this.txtNameCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(226)))));
            this.txtNameCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNameCompany.Location = new System.Drawing.Point(75, 50);
            this.txtNameCompany.Name = "txtNameCompany";
            this.txtNameCompany.Size = new System.Drawing.Size(448, 20);
            this.txtNameCompany.TabIndex = 3;
            // 
            // btnSearchDistributor
            // 
            this.btnSearchDistributor.FlatAppearance.BorderSize = 0;
            this.btnSearchDistributor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchDistributor.IconChar = FontAwesome.Sharp.IconChar.Sistrix;
            this.btnSearchDistributor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(226)))));
            this.btnSearchDistributor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearchDistributor.IconSize = 28;
            this.btnSearchDistributor.Location = new System.Drawing.Point(12, 42);
            this.btnSearchDistributor.Name = "btnSearchDistributor";
            this.btnSearchDistributor.Size = new System.Drawing.Size(57, 33);
            this.btnSearchDistributor.TabIndex = 3;
            this.btnSearchDistributor.UseVisualStyleBackColor = true;
            this.btnSearchDistributor.Click += new System.EventHandler(this.btnSearchDistributor_Click);
            // 
            // btnNewDistributor
            // 
            this.btnNewDistributor.FlatAppearance.BorderSize = 0;
            this.btnNewDistributor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewDistributor.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnNewDistributor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(226)))));
            this.btnNewDistributor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNewDistributor.IconSize = 40;
            this.btnNewDistributor.Location = new System.Drawing.Point(12, 349);
            this.btnNewDistributor.Name = "btnNewDistributor";
            this.btnNewDistributor.Size = new System.Drawing.Size(151, 39);
            this.btnNewDistributor.TabIndex = 4;
            this.btnNewDistributor.UseVisualStyleBackColor = true;
            this.btnNewDistributor.Click += new System.EventHandler(this.btnNewDistributor_Click);
            // 
            // btnEditDistributor
            // 
            this.btnEditDistributor.FlatAppearance.BorderSize = 0;
            this.btnEditDistributor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDistributor.IconChar = FontAwesome.Sharp.IconChar.UserPen;
            this.btnEditDistributor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(226)))));
            this.btnEditDistributor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditDistributor.IconSize = 40;
            this.btnEditDistributor.Location = new System.Drawing.Point(194, 349);
            this.btnEditDistributor.Name = "btnEditDistributor";
            this.btnEditDistributor.Size = new System.Drawing.Size(151, 39);
            this.btnEditDistributor.TabIndex = 5;
            this.btnEditDistributor.UseVisualStyleBackColor = true;
            this.btnEditDistributor.Click += new System.EventHandler(this.btnEditDistributor_Click);
            // 
            // btnDeleteDsitributor
            // 
            this.btnDeleteDsitributor.FlatAppearance.BorderSize = 0;
            this.btnDeleteDsitributor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDsitributor.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnDeleteDsitributor.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(247)))), ((int)(((byte)(226)))));
            this.btnDeleteDsitributor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteDsitributor.IconSize = 40;
            this.btnDeleteDsitributor.Location = new System.Drawing.Point(372, 349);
            this.btnDeleteDsitributor.Name = "btnDeleteDsitributor";
            this.btnDeleteDsitributor.Size = new System.Drawing.Size(151, 39);
            this.btnDeleteDsitributor.TabIndex = 6;
            this.btnDeleteDsitributor.UseVisualStyleBackColor = true;
            this.btnDeleteDsitributor.Click += new System.EventHandler(this.btnDeleteDsitributor_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(21)))), ((int)(((byte)(4)))));
            this.ClientSize = new System.Drawing.Size(536, 400);
            this.Controls.Add(this.btnDeleteDsitributor);
            this.Controls.Add(this.btnEditDistributor);
            this.Controls.Add(this.btnNewDistributor);
            this.Controls.Add(this.btnSearchDistributor);
            this.Controls.Add(this.txtNameCompany);
            this.Controls.Add(this.dgvDistributors);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDistributors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnMinisizeWindows;
        private FontAwesome.Sharp.IconButton btnCloseWindows;
        private System.Windows.Forms.DataGridView dgvDistributors;
        private System.Windows.Forms.TextBox txtNameCompany;
        private FontAwesome.Sharp.IconButton btnSearchDistributor;
        private FontAwesome.Sharp.IconButton btnNewDistributor;
        private FontAwesome.Sharp.IconButton btnEditDistributor;
        private FontAwesome.Sharp.IconButton btnDeleteDsitributor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Representative;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Transport;
    }
}

