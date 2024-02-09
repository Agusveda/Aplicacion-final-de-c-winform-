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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbArticulos = new System.Windows.Forms.PictureBox();
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
            this.btnfiltro = new System.Windows.Forms.Button();
            this.lblfiltrodescripcion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.LightYellow;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvArticulos.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(27, 58);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(986, 347);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // pbArticulos
            // 
            this.pbArticulos.BackColor = System.Drawing.SystemColors.Info;
            this.pbArticulos.Location = new System.Drawing.Point(693, 103);
            this.pbArticulos.MaximumSize = new System.Drawing.Size(302, 273);
            this.pbArticulos.MinimumSize = new System.Drawing.Size(302, 273);
            this.pbArticulos.Name = "pbArticulos";
            this.pbArticulos.Size = new System.Drawing.Size(302, 273);
            this.pbArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbArticulos.TabIndex = 1;
            this.pbArticulos.TabStop = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(810, 67);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(100, 20);
            this.txtFiltro.TabIndex = 2;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblfiltro
            // 
            this.lblfiltro.AutoSize = true;
            this.lblfiltro.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.lblfiltro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltro.Location = new System.Drawing.Point(706, 67);
            this.lblfiltro.Name = "lblfiltro";
            this.lblfiltro.Size = new System.Drawing.Size(98, 16);
            this.lblfiltro.TabIndex = 3;
            this.lblfiltro.Text = "FiltroBasico:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.LightGreen;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Location = new System.Drawing.Point(59, 428);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(233, 70);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "&Agregar Articulo";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.LightGreen;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModificar.FlatAppearance.BorderSize = 2;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnModificar.Location = new System.Drawing.Point(407, 428);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(233, 70);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "&Modificar Articulo";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Location = new System.Drawing.Point(746, 428);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(233, 70);
            this.btnEliminar.TabIndex = 6;
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
            this.txtfiltroavanz.TabIndex = 22;
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
            this.cbcriterio.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbcriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcriterio.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcriterio.FormattingEnabled = true;
            this.cbcriterio.Location = new System.Drawing.Point(322, 28);
            this.cbcriterio.Name = "cbcriterio";
            this.cbcriterio.Size = new System.Drawing.Size(121, 24);
            this.cbcriterio.TabIndex = 20;
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
            this.cbcampo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.cbcampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbcampo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcampo.FormattingEnabled = true;
            this.cbcampo.Location = new System.Drawing.Point(129, 28);
            this.cbcampo.Name = "cbcampo";
            this.cbcampo.Size = new System.Drawing.Size(121, 24);
            this.cbcampo.TabIndex = 18;
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
            // btnfiltro
            // 
            this.btnfiltro.BackColor = System.Drawing.Color.FloralWhite;
            this.btnfiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfiltro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfiltro.Location = new System.Drawing.Point(669, 26);
            this.btnfiltro.Name = "btnfiltro";
            this.btnfiltro.Size = new System.Drawing.Size(122, 26);
            this.btnfiltro.TabIndex = 16;
            this.btnfiltro.Text = "&Buscar";
            this.btnfiltro.UseVisualStyleBackColor = false;
            this.btnfiltro.Click += new System.EventHandler(this.btnfiltro_Click);
            // 
            // lblfiltrodescripcion
            // 
            this.lblfiltrodescripcion.AutoSize = true;
            this.lblfiltrodescripcion.Font = new System.Drawing.Font("Verdana", 6F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiltrodescripcion.Location = new System.Drawing.Point(818, 90);
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
            // Frm_Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1025, 518);
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
    }
}

