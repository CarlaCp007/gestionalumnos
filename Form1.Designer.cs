namespace examen
{
    partial class FormGestionCalificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionCalificaciones));
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnSuspensos = new System.Windows.Forms.Button();
            this.btnAprobados = new System.Windows.Forms.Button();
            this.btnMH = new System.Windows.Forms.Button();
            this.btnTodos = new System.Windows.Forms.Button();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lstResultados = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAgregar.Location = new System.Drawing.Point(149, 253);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 33);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Registrar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEliminar.Location = new System.Drawing.Point(273, 253);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 33);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnConsultar.Location = new System.Drawing.Point(405, 253);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(91, 33);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnModificar.Location = new System.Drawing.Point(528, 253);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(91, 33);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnSuspensos
            // 
            this.btnSuspensos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSuspensos.Location = new System.Drawing.Point(139, 318);
            this.btnSuspensos.Name = "btnSuspensos";
            this.btnSuspensos.Size = new System.Drawing.Size(105, 33);
            this.btnSuspensos.TabIndex = 4;
            this.btnSuspensos.Text = "Suspensos";
            this.btnSuspensos.UseVisualStyleBackColor = false;
            this.btnSuspensos.Click += new System.EventHandler(this.btnSuspensos_Click);
            // 
            // btnAprobados
            // 
            this.btnAprobados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAprobados.Location = new System.Drawing.Point(263, 318);
            this.btnAprobados.Name = "btnAprobados";
            this.btnAprobados.Size = new System.Drawing.Size(109, 33);
            this.btnAprobados.TabIndex = 5;
            this.btnAprobados.Text = "Aprobados";
            this.btnAprobados.UseVisualStyleBackColor = false;
            this.btnAprobados.Click += new System.EventHandler(this.btnAprobados_Click);
            // 
            // btnMH
            // 
            this.btnMH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMH.Location = new System.Drawing.Point(405, 318);
            this.btnMH.Name = "btnMH";
            this.btnMH.Size = new System.Drawing.Size(91, 33);
            this.btnMH.TabIndex = 6;
            this.btnMH.Text = "MH";
            this.btnMH.UseVisualStyleBackColor = false;
            this.btnMH.Click += new System.EventHandler(this.btnMH_Click);
            // 
            // btnTodos
            // 
            this.btnTodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnTodos.Location = new System.Drawing.Point(528, 318);
            this.btnTodos.Name = "btnTodos";
            this.btnTodos.Size = new System.Drawing.Size(91, 33);
            this.btnTodos.TabIndex = 7;
            this.btnTodos.Text = "Todos";
            this.btnTodos.UseVisualStyleBackColor = false;
            this.btnTodos.Click += new System.EventHandler(this.btnTodos_Click);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.Color.White;
            this.lblDNI.Location = new System.Drawing.Point(174, 128);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(37, 20);
            this.lblDNI.TabIndex = 8;
            this.lblDNI.Text = "DNI";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(287, 128);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 9;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.BackColor = System.Drawing.Color.White;
            this.lblApellidos.Location = new System.Drawing.Point(428, 128);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(65, 20);
            this.lblApellidos.TabIndex = 10;
            this.lblApellidos.Text = "Apellido";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.BackColor = System.Drawing.Color.White;
            this.lblNota.Location = new System.Drawing.Point(550, 128);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(43, 20);
            this.lblNota.TabIndex = 11;
            this.lblNota.Text = "Nota";
            // 
            // txtDni
            // 
            this.txtDni.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDni.Location = new System.Drawing.Point(139, 168);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 26);
            this.txtDni.TabIndex = 12;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombre.Location = new System.Drawing.Point(263, 168);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 26);
            this.txtNombre.TabIndex = 13;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtApellidos.Location = new System.Drawing.Point(404, 168);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(100, 26);
            this.txtApellidos.TabIndex = 14;
            // 
            // txtNota
            // 
            this.txtNota.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNota.Location = new System.Drawing.Point(540, 168);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(100, 26);
            this.txtNota.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(286, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Sistema calificaciones";
            // 
            // lstResultados
            // 
            this.lstResultados.HideSelection = false;
            this.lstResultados.Location = new System.Drawing.Point(239, 371);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(257, 97);
            this.lstResultados.TabIndex = 17;
            this.lstResultados.UseCompatibleStateImageBehavior = false;
            // 
            // FormGestionCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.lstResultados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblApellidos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.btnTodos);
            this.Controls.Add(this.btnMH);
            this.Controls.Add(this.btnAprobados);
            this.Controls.Add(this.btnSuspensos);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "FormGestionCalificaciones";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnSuspensos;
        private System.Windows.Forms.Button btnAprobados;
        private System.Windows.Forms.Button btnMH;
        private System.Windows.Forms.Button btnTodos;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lstResultados;
    }
}

