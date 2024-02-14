namespace Presentacion
{
    partial class Frm_Catalogo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblfiltro = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtfiltroavanz = new System.Windows.Forms.TextBox();
            this.lblfiltroavanzado = new System.Windows.Forms.Label();
            this.cbcriterio = new System.Windows.Forms.ComboBox();
            this.lblcriterio = new System.Windows.Forms.Label();
            this.cbcampo = new System.Windows.Forms.ComboBox();
            this.lblcampo = new System.Windows.Forms.Label();
            this.lblfiltrodescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLimpiarfiltro = new System.Windows.Forms.Button();
            this.btnfiltro = new System.Windows.Forms.Button();
            this.pbArticulos = new System.Windows.Forms.PictureBox();
            this.btnDetalle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(27, 67);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(986, 347);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(810, 83);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtFiltro.TabIndex = 4;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblfiltro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltro.Location = new System.Drawing.Point(706, 83);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(98, 16);
            this.lblfiltro.TabIndex = 3;
            this.lblfiltro.Text = "FiltroBasico:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(27, 433);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(147, 60);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "&Agregar Articulo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.LightGreen;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModificar.FlatAppearance.BorderSize = 2;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.Location = new System.Drawing.Point(180, 433);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(152, 60);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "&Modificar Articulo";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(77)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(510, 433);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(152, 60);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "&Eliminar Articulo";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtfiltroavanz
            // 
            this.txtfiltroavanz.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtfiltroavanz.BackColor = System.Drawing.Color.Azure;
            this.txtfiltroavanz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtfiltroavanz.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtfiltroavanz.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltroavanz.Location = new System.Drawing.Point(501, 28);
            this.txtfiltroavanz.Name = "txtfiltroavanz";
            this.txtfiltroavanz.Size = new System.Drawing.Size(139, 23);
            this.txtfiltroavanz.TabIndex = 7;
            // 
            // lblfiltroavanzado
            // 
            this.lblfiltroavanzado.AutoSize = true;
            this.lblfiltroavanzado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltroavanzado.Location = new System.Drawing.Point(449, 30);
            this.lblfiltroavanzado.Name = "lblfiltroavanzado";
            this.lblfiltroavanzado.Size = new System.Drawing.Size(46, 16);
            this.lblfiltroavanzado.TabIndex = 21;
            this.lblfiltroavanzado.Text = "Filtro:";
            // 
            // cbcriterio
            // 
            this.cbcriterio.BackColor = System.Drawing.SystemColors.Info;
            this.cbcriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcriterio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcriterio.FormattingEnabled = true;
            this.cbcriterio.Location = new System.Drawing.Point(322, 28);
            this.cbcriterio.Name = "cbcriterio";
            this.cbcriterio.Size = new System.Drawing.Size(121, 24);
            this.cbcriterio.TabIndex = 6;
            // 
            // lblcriterio
            // 
            this.lblcriterio.AutoSize = true;
            this.lblcriterio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcriterio.Location = new System.Drawing.Point(256, 30);
            this.lblcriterio.Name = "lblcriterio";
            this.lblcriterio.Size = new System.Drawing.Size(60, 16);
            this.lblcriterio.TabIndex = 19;
            this.lblcriterio.Text = "Criterio:";
            // 
            // cbcampo
            // 
            this.cbcampo.BackColor = System.Drawing.SystemColors.Info;
            this.cbcampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcampo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcampo.FormattingEnabled = true;
            this.cbcampo.Location = new System.Drawing.Point(129, 28);
            this.cbcampo.Name = "cbcampo";
            this.cbcampo.Size = new System.Drawing.Size(121, 24);
            this.cbcampo.TabIndex = 5;
            this.cbcampo.SelectedIndexChanged += new System.EventHandler(this.cbcampo_SelectedIndexChanged);
            // 
            // lblcampo
            // 
            this.lblcampo.AutoSize = true;
            this.lblcampo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcampo.Location = new System.Drawing.Point(66, 31);
            this.lblcampo.Name = "lblcampo";
            this.lblcampo.Size = new System.Drawing.Size(57, 16);
            this.lblcampo.TabIndex = 17;
            this.lblcampo.Text = "Campo:";
            // 
            // lblfiltrodescripcion
            // 
            this.lblfiltrodescripcion.AutoSize = true;
            this.lblfiltrodescripcion.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltrodescripcion.Location = new System.Drawing.Point(818, 106);
            this.lblfiltrodescripcion.Name = "lblfiltrodescripcion";
            this.lblfiltrodescripcion.Size = new System.Drawing.Size(80, 10);
            this.lblfiltrodescripcion.TabIndex = 23;
            this.lblfiltrodescripcion.Text = "(Marca/Categoria)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 24;
            this.label1.Text = "(Filtro avanzado)";
            // 
            // BtnLimpiarfiltro
            // 
            this.BtnLimpiarfiltro.BackgroundImage = global::Presentacion.Properties.Resources.goma_de_borrar;
            this.BtnLimpiarfiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnLimpiarfiltro.CausesValidation = false;
            this.BtnLimpiarfiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLimpiarfiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimpiarfiltro.Location = new System.Drawing.Point(678, 28);
            this.BtnLimpiarfiltro.Name = "BtnLimpiarfiltro";
            this.BtnLimpiarfiltro.Size = new System.Drawing.Size(28, 24);
            this.BtnLimpiarfiltro.TabIndex = 25;
            this.BtnLimpiarfiltro.UseVisualStyleBackColor = true;
            this.BtnLimpiarfiltro.Click += new System.EventHandler(this.BtnLimpiarfiltro_Click);
            // 
            // btnfiltro
            // 
            this.btnfiltro.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnfiltro.BackgroundImage = global::Presentacion.Properties.Resources.icone_loupe_noir;
            this.btnfiltro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnfiltro.CausesValidation = false;
            this.btnfiltro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnfiltro.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.btnfiltro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnfiltro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnfiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfiltro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiltro.Location = new System.Drawing.Point(646, 28);
            this.btnfiltro.Name = "btnfiltro";
            this.btnfiltro.Size = new System.Drawing.Size(26, 24);
            this.btnfiltro.TabIndex = 16;
            this.btnfiltro.UseVisualStyleBackColor = false;
            this.btnfiltro.Click += new System.EventHandler(this.btnfiltro_Click);
            // 
            // pbArticulos
            // 
            this.pbArticulos.BackColor = System.Drawing.SystemColors.Info;
            this.pbArticulos.Location = new System.Drawing.Point(694, 119);
            this.pbArticulos.MaximumSize = new System.Drawing.Size(302, 273);
            this.pbArticulos.MinimumSize = new System.Drawing.Size(302, 273);
            this.pbArticulos.Name = "pbArticulos";
            this.pbArticulos.Size = new System.Drawing.Size(302, 273);
            this.pbArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArticulos.TabIndex = 1;
            this.pbArticulos.TabStop = false;
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.LightGreen;
            this.btnDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDetalle.FlatAppearance.BorderSize = 2;
            this.btnDetalle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDetalle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalle.Location = new System.Drawing.Point(343, 433);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(152, 60);
            this.btnDetalle.TabIndex = 26;
            this.btnDetalle.Text = "&Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = false;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // Frm_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1025, 513);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.BtnLimpiarfiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblfiltrodescripcion);
            this.Controls.Add(this.txtfiltroavanz);
            this.Controls.Add(this.lblfiltroavanzado);
            this.Controls.Add(this.cbcriterio);
            this.Controls.Add(this.lblcriterio);
            this.Controls.Add(this.cbcampo);
            this.Controls.Add(this.lblcampo);
            this.Controls.Add(this.btnfiltro);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblfiltro);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.pbArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "Frm_Catalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catologo";
            this.Load += new System.EventHandler(this.Frm_Catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbArticulos;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblfiltro;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtfiltroavanz;
        private System.Windows.Forms.Label lblfiltroavanzado;
        private System.Windows.Forms.ComboBox cbcriterio;
        private System.Windows.Forms.Label lblcriterio;
        private System.Windows.Forms.ComboBox cbcampo;
        private System.Windows.Forms.Label lblcampo;
        private System.Windows.Forms.Button btnfiltro;
        private System.Windows.Forms.Label lblfiltrodescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLimpiarfiltro;
        private System.Windows.Forms.Button btnDetalle;
    }
}

