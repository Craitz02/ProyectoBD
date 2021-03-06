
namespace TeatroSistema.View
{
    partial class FrmEventosV2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEventosV2));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Header = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvEventosPendientes = new System.Windows.Forms.DataGridView();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.btnPagarFactura = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventosPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Header.Controls.Add(this.btnExit);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(800, 36);
            this.Header.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(766, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(34, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvEventosPendientes);
            this.panel1.Location = new System.Drawing.Point(30, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 331);
            this.panel1.TabIndex = 3;
            // 
            // dgvEventosPendientes
            // 
            this.dgvEventosPendientes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(228)))));
            this.dgvEventosPendientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEventosPendientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEventosPendientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEventosPendientes.ColumnHeadersHeight = 30;
            this.dgvEventosPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEventosPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEventosPendientes.EnableHeadersVisualStyles = false;
            this.dgvEventosPendientes.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEventosPendientes.Location = new System.Drawing.Point(0, 0);
            this.dgvEventosPendientes.Name = "dgvEventosPendientes";
            this.dgvEventosPendientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEventosPendientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEventosPendientes.RowHeadersVisible = false;
            this.dgvEventosPendientes.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(228)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvEventosPendientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEventosPendientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEventosPendientes.Size = new System.Drawing.Size(452, 331);
            this.dgvEventosPendientes.TabIndex = 2;
            // 
            // calendario
            // 
            this.calendario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(173)))), ((int)(((byte)(228)))));
            this.calendario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendario.Location = new System.Drawing.Point(503, 259);
            this.calendario.Margin = new System.Windows.Forms.Padding(7);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 4;
            this.calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateChanged);
            // 
            // btnPagarFactura
            // 
            this.btnPagarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarFactura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPagarFactura.Location = new System.Drawing.Point(224, 437);
            this.btnPagarFactura.Margin = new System.Windows.Forms.Padding(2);
            this.btnPagarFactura.Name = "btnPagarFactura";
            this.btnPagarFactura.Size = new System.Drawing.Size(93, 38);
            this.btnPagarFactura.TabIndex = 4;
            this.btnPagarFactura.Text = "Pagar Factura";
            this.btnPagarFactura.UseVisualStyleBackColor = true;
            this.btnPagarFactura.Click += new System.EventHandler(this.btnPagarFactura_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(30, 437);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 38);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar evento";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.ForeColor = System.Drawing.Color.White;
            this.btnFacturar.Location = new System.Drawing.Point(127, 437);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(93, 38);
            this.btnFacturar.TabIndex = 5;
            this.btnFacturar.Text = "Facturar servicio";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(176, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 22);
            this.label1.TabIndex = 24;
            this.label1.Text = "Eventos Pendientes";
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizar.Location = new System.Drawing.Point(321, 437);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(93, 38);
            this.btnActualizar.TabIndex = 25;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // pbImagen
            // 
            this.pbImagen.Location = new System.Drawing.Point(503, 90);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(248, 159);
            this.pbImagen.TabIndex = 26;
            this.pbImagen.TabStop = false;
            // 
            // FrmEventosV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPagarFactura);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEventosV2";
            this.Text = "FrmEventosV2";
            this.Header.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEventosPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvEventosPendientes;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Button btnPagarFactura;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.PictureBox pbImagen;
    }
}