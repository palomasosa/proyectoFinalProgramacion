
namespace trabajoFinalProgramacion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblInscripción = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.nmrEdad = new System.Windows.Forms.NumericUpDown();
            this.nmrDNI = new System.Windows.Forms.NumericUpDown();
            this.rdbtnCarrera5 = new System.Windows.Forms.RadioButton();
            this.rdbtnCarrera10 = new System.Windows.Forms.RadioButton();
            this.rdbtnCarreras15 = new System.Windows.Forms.RadioButton();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblSeleccion = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnMostrarInscriptos1 = new System.Windows.Forms.Button();
            this.btnMostrarInscriptos2 = new System.Windows.Forms.Button();
            this.btnMostrarInscriptos3 = new System.Windows.Forms.Button();
            this.lblAlertaNombre = new System.Windows.Forms.Label();
            this.lblAlertaApellido = new System.Windows.Forms.Label();
            this.lblAlertaEdadMenor = new System.Windows.Forms.Label();
            this.lblAlertaEdadMayor = new System.Windows.Forms.Label();
            this.lblAlertaDNI = new System.Windows.Forms.Label();
            this.lblAlertaCarrera = new System.Windows.Forms.Label();
            this.lblAceptado = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblNoCupo = new System.Windows.Forms.Label();
            this.lblErrorDNIRepetido = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.dgv2 = new System.Windows.Forms.DataGridView();
            this.dgv3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nmrEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtitulo.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(233, 77);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(415, 30);
            this.lblSubtitulo.TabIndex = 0;
            this.lblSubtitulo.Text = "La manera más simple de correr...";
            this.lblSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblTitulo.Location = new System.Drawing.Point(295, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(270, 77);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "RACERS";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInscripción
            // 
            this.lblInscripción.AutoSize = true;
            this.lblInscripción.BackColor = System.Drawing.Color.Transparent;
            this.lblInscripción.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInscripción.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblInscripción.Location = new System.Drawing.Point(21, 109);
            this.lblInscripción.Name = "lblInscripción";
            this.lblInscripción.Size = new System.Drawing.Size(97, 24);
            this.lblInscripción.TabIndex = 2;
            this.lblInscripción.Text = "Inscribite";
            this.lblInscripción.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtNombre.Location = new System.Drawing.Point(18, 175);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(120, 17);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtApellido
            // 
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtApellido.Location = new System.Drawing.Point(172, 175);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(120, 17);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmrEdad
            // 
            this.nmrEdad.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrEdad.Location = new System.Drawing.Point(35, 240);
            this.nmrEdad.Name = "nmrEdad";
            this.nmrEdad.Size = new System.Drawing.Size(77, 23);
            this.nmrEdad.TabIndex = 5;
            this.nmrEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmrEdad.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // nmrDNI
            // 
            this.nmrDNI.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrDNI.Location = new System.Drawing.Point(172, 240);
            this.nmrDNI.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmrDNI.Name = "nmrDNI";
            this.nmrDNI.Size = new System.Drawing.Size(120, 23);
            this.nmrDNI.TabIndex = 6;
            this.nmrDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdbtnCarrera5
            // 
            this.rdbtnCarrera5.AutoSize = true;
            this.rdbtnCarrera5.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnCarrera5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbtnCarrera5.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnCarrera5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdbtnCarrera5.Location = new System.Drawing.Point(148, 323);
            this.rdbtnCarrera5.Name = "rdbtnCarrera5";
            this.rdbtnCarrera5.Size = new System.Drawing.Size(184, 20);
            this.rdbtnCarrera5.TabIndex = 7;
            this.rdbtnCarrera5.TabStop = true;
            this.rdbtnCarrera5.Text = "Carrera 5 kms (SIERRAS)";
            this.rdbtnCarrera5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbtnCarrera5.UseVisualStyleBackColor = false;
            // 
            // rdbtnCarrera10
            // 
            this.rdbtnCarrera10.AutoSize = true;
            this.rdbtnCarrera10.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnCarrera10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbtnCarrera10.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnCarrera10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdbtnCarrera10.Location = new System.Drawing.Point(148, 360);
            this.rdbtnCarrera10.Name = "rdbtnCarrera10";
            this.rdbtnCarrera10.Size = new System.Drawing.Size(190, 20);
            this.rdbtnCarrera10.TabIndex = 8;
            this.rdbtnCarrera10.TabStop = true;
            this.rdbtnCarrera10.Text = "Carrera 10 kms (SIERRAS)";
            this.rdbtnCarrera10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbtnCarrera10.UseVisualStyleBackColor = false;
            // 
            // rdbtnCarreras15
            // 
            this.rdbtnCarreras15.AutoSize = true;
            this.rdbtnCarreras15.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnCarreras15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbtnCarreras15.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtnCarreras15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.rdbtnCarreras15.Location = new System.Drawing.Point(148, 394);
            this.rdbtnCarreras15.Name = "rdbtnCarreras15";
            this.rdbtnCarreras15.Size = new System.Drawing.Size(190, 20);
            this.rdbtnCarreras15.TabIndex = 9;
            this.rdbtnCarreras15.TabStop = true;
            this.rdbtnCarreras15.Text = "Carrera 15 kms (CIUDAD)";
            this.rdbtnCarreras15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdbtnCarreras15.UseVisualStyleBackColor = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblNombre.Location = new System.Drawing.Point(31, 153);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 19);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblApellido.Location = new System.Drawing.Point(195, 153);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(75, 19);
            this.lblApellido.TabIndex = 11;
            this.lblApellido.Text = "Apellido";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.BackColor = System.Drawing.Color.Transparent;
            this.lblEdad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblEdad.Location = new System.Drawing.Point(44, 218);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(51, 19);
            this.lblEdad.TabIndex = 12;
            this.lblEdad.Text = "Edad";
            this.lblEdad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblDNI.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDNI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblDNI.Location = new System.Drawing.Point(206, 218);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(37, 19);
            this.lblDNI.TabIndex = 13;
            this.lblDNI.Text = "DNI";
            this.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeleccion
            // 
            this.lblSeleccion.AutoSize = true;
            this.lblSeleccion.BackColor = System.Drawing.Color.Transparent;
            this.lblSeleccion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblSeleccion.Location = new System.Drawing.Point(12, 298);
            this.lblSeleccion.Name = "lblSeleccion";
            this.lblSeleccion.Size = new System.Drawing.Size(175, 19);
            this.lblSeleccion.TabIndex = 14;
            this.lblSeleccion.Text = "Seleccione su carrera";
            this.lblSeleccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSubmit.Location = new System.Drawing.Point(92, 441);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(116, 39);
            this.btnSubmit.TabIndex = 15;
            this.btnSubmit.Text = "Inscribirme";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnMostrarInscriptos1
            // 
            this.btnMostrarInscriptos1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMostrarInscriptos1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarInscriptos1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarInscriptos1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMostrarInscriptos1.Location = new System.Drawing.Point(9, 320);
            this.btnMostrarInscriptos1.Name = "btnMostrarInscriptos1";
            this.btnMostrarInscriptos1.Size = new System.Drawing.Size(133, 26);
            this.btnMostrarInscriptos1.TabIndex = 16;
            this.btnMostrarInscriptos1.Text = "Mostrar inscriptos";
            this.btnMostrarInscriptos1.UseVisualStyleBackColor = false;
            this.btnMostrarInscriptos1.Click += new System.EventHandler(this.btnMostrarInscriptos1_Click);
            // 
            // btnMostrarInscriptos2
            // 
            this.btnMostrarInscriptos2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMostrarInscriptos2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarInscriptos2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarInscriptos2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMostrarInscriptos2.Location = new System.Drawing.Point(9, 357);
            this.btnMostrarInscriptos2.Name = "btnMostrarInscriptos2";
            this.btnMostrarInscriptos2.Size = new System.Drawing.Size(133, 26);
            this.btnMostrarInscriptos2.TabIndex = 17;
            this.btnMostrarInscriptos2.Text = "Mostrar inscriptos";
            this.btnMostrarInscriptos2.UseVisualStyleBackColor = false;
            this.btnMostrarInscriptos2.Click += new System.EventHandler(this.btnMostrarInscriptos2_Click);
            // 
            // btnMostrarInscriptos3
            // 
            this.btnMostrarInscriptos3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMostrarInscriptos3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarInscriptos3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarInscriptos3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMostrarInscriptos3.Location = new System.Drawing.Point(9, 391);
            this.btnMostrarInscriptos3.Name = "btnMostrarInscriptos3";
            this.btnMostrarInscriptos3.Size = new System.Drawing.Size(133, 26);
            this.btnMostrarInscriptos3.TabIndex = 18;
            this.btnMostrarInscriptos3.Text = "Mostrar inscriptos";
            this.btnMostrarInscriptos3.UseVisualStyleBackColor = false;
            this.btnMostrarInscriptos3.Click += new System.EventHandler(this.btnMostrarInscriptos3_Click);
            // 
            // lblAlertaNombre
            // 
            this.lblAlertaNombre.AutoSize = true;
            this.lblAlertaNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertaNombre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaNombre.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaNombre.Location = new System.Drawing.Point(6, 195);
            this.lblAlertaNombre.Name = "lblAlertaNombre";
            this.lblAlertaNombre.Size = new System.Drawing.Size(152, 18);
            this.lblAlertaNombre.TabIndex = 19;
            this.lblAlertaNombre.Text = "* Ingrese su nombre";
            this.lblAlertaNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlertaNombre.Visible = false;
            // 
            // lblAlertaApellido
            // 
            this.lblAlertaApellido.AutoSize = true;
            this.lblAlertaApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertaApellido.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaApellido.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaApellido.Location = new System.Drawing.Point(164, 195);
            this.lblAlertaApellido.Name = "lblAlertaApellido";
            this.lblAlertaApellido.Size = new System.Drawing.Size(156, 18);
            this.lblAlertaApellido.TabIndex = 20;
            this.lblAlertaApellido.Text = "* Ingrese su apellido";
            this.lblAlertaApellido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlertaApellido.Visible = false;
            // 
            // lblAlertaEdadMenor
            // 
            this.lblAlertaEdadMenor.AutoSize = true;
            this.lblAlertaEdadMenor.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertaEdadMenor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaEdadMenor.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaEdadMenor.Location = new System.Drawing.Point(6, 266);
            this.lblAlertaEdadMenor.Name = "lblAlertaEdadMenor";
            this.lblAlertaEdadMenor.Size = new System.Drawing.Size(202, 18);
            this.lblAlertaEdadMenor.TabIndex = 21;
            this.lblAlertaEdadMenor.Text = "* Debe ser mayor de edad";
            this.lblAlertaEdadMenor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlertaEdadMenor.Visible = false;
            // 
            // lblAlertaEdadMayor
            // 
            this.lblAlertaEdadMayor.AutoSize = true;
            this.lblAlertaEdadMayor.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertaEdadMayor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaEdadMayor.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaEdadMayor.Location = new System.Drawing.Point(6, 266);
            this.lblAlertaEdadMayor.Name = "lblAlertaEdadMayor";
            this.lblAlertaEdadMayor.Size = new System.Drawing.Size(419, 36);
            this.lblAlertaEdadMayor.TabIndex = 22;
            this.lblAlertaEdadMayor.Text = "* Si ud. es mayor a 55 años, debe acercarse a un centro \r\nde inscripción y presen" +
    "tar certificado médico ";
            this.lblAlertaEdadMayor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlertaEdadMayor.Visible = false;
            // 
            // lblAlertaDNI
            // 
            this.lblAlertaDNI.AutoSize = true;
            this.lblAlertaDNI.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertaDNI.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaDNI.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaDNI.Location = new System.Drawing.Point(298, 240);
            this.lblAlertaDNI.Name = "lblAlertaDNI";
            this.lblAlertaDNI.Size = new System.Drawing.Size(107, 18);
            this.lblAlertaDNI.TabIndex = 23;
            this.lblAlertaDNI.Text = "DNI no valido";
            this.lblAlertaDNI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlertaDNI.Visible = false;
            // 
            // lblAlertaCarrera
            // 
            this.lblAlertaCarrera.AutoSize = true;
            this.lblAlertaCarrera.BackColor = System.Drawing.Color.Transparent;
            this.lblAlertaCarrera.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlertaCarrera.ForeColor = System.Drawing.Color.Red;
            this.lblAlertaCarrera.Location = new System.Drawing.Point(12, 420);
            this.lblAlertaCarrera.Name = "lblAlertaCarrera";
            this.lblAlertaCarrera.Size = new System.Drawing.Size(267, 18);
            this.lblAlertaCarrera.TabIndex = 24;
            this.lblAlertaCarrera.Text = "* Por favor, seleccione una carrera";
            this.lblAlertaCarrera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlertaCarrera.Visible = false;
            // 
            // lblAceptado
            // 
            this.lblAceptado.AutoSize = true;
            this.lblAceptado.BackColor = System.Drawing.Color.Transparent;
            this.lblAceptado.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAceptado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAceptado.Location = new System.Drawing.Point(255, 501);
            this.lblAceptado.Name = "lblAceptado";
            this.lblAceptado.Size = new System.Drawing.Size(272, 36);
            this.lblAceptado.TabIndex = 25;
            this.lblAceptado.Text = "Corredor inscripto";
            this.lblAceptado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAceptado.Visible = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(721, 486);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(48, 23);
            this.btnCerrar.TabIndex = 29;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Visible = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblNoCupo
            // 
            this.lblNoCupo.AutoSize = true;
            this.lblNoCupo.BackColor = System.Drawing.Color.Transparent;
            this.lblNoCupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCupo.ForeColor = System.Drawing.Color.Red;
            this.lblNoCupo.Location = new System.Drawing.Point(126, 490);
            this.lblNoCupo.Name = "lblNoCupo";
            this.lblNoCupo.Size = new System.Drawing.Size(522, 29);
            this.lblNoCupo.TabIndex = 30;
            this.lblNoCupo.Text = "Lo sentimos, no hay mas cupo para esta carrera";
            this.lblNoCupo.Visible = false;
            // 
            // lblErrorDNIRepetido
            // 
            this.lblErrorDNIRepetido.AutoSize = true;
            this.lblErrorDNIRepetido.BackColor = System.Drawing.Color.Transparent;
            this.lblErrorDNIRepetido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDNIRepetido.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDNIRepetido.Location = new System.Drawing.Point(132, 519);
            this.lblErrorDNIRepetido.Name = "lblErrorDNIRepetido";
            this.lblErrorDNIRepetido.Size = new System.Drawing.Size(506, 24);
            this.lblErrorDNIRepetido.TabIndex = 31;
            this.lblErrorDNIRepetido.Text = "Error: Este DNI ya fue ingresado en la carrera seleccionada";
            this.lblErrorDNIRepetido.Visible = false;
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Location = new System.Drawing.Point(344, 298);
            this.dgv1.Name = "dgv1";
            this.dgv1.Size = new System.Drawing.Size(425, 189);
            this.dgv1.TabIndex = 32;
            this.dgv1.Visible = false;
            // 
            // dgv2
            // 
            this.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv2.Location = new System.Drawing.Point(344, 298);
            this.dgv2.Name = "dgv2";
            this.dgv2.Size = new System.Drawing.Size(425, 189);
            this.dgv2.TabIndex = 33;
            this.dgv2.Visible = false;
            // 
            // dgv3
            // 
            this.dgv3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv3.Location = new System.Drawing.Point(344, 298);
            this.dgv3.Name = "dgv3";
            this.dgv3.Size = new System.Drawing.Size(425, 189);
            this.dgv3.TabIndex = 34;
            this.dgv3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(781, 546);
            this.Controls.Add(this.dgv3);
            this.Controls.Add(this.dgv2);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.lblErrorDNIRepetido);
            this.Controls.Add(this.lblNoCupo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblAceptado);
            this.Controls.Add(this.lblAlertaCarrera);
            this.Controls.Add(this.lblAlertaDNI);
            this.Controls.Add(this.lblAlertaEdadMayor);
            this.Controls.Add(this.lblAlertaEdadMenor);
            this.Controls.Add(this.lblAlertaApellido);
            this.Controls.Add(this.lblAlertaNombre);
            this.Controls.Add(this.btnMostrarInscriptos3);
            this.Controls.Add(this.btnMostrarInscriptos2);
            this.Controls.Add(this.btnMostrarInscriptos1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblSeleccion);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.rdbtnCarreras15);
            this.Controls.Add(this.rdbtnCarrera10);
            this.Controls.Add(this.rdbtnCarrera5);
            this.Controls.Add(this.nmrDNI);
            this.Controls.Add(this.nmrEdad);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblInscripción);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblSubtitulo);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nmrEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblInscripción;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.NumericUpDown nmrEdad;
        private System.Windows.Forms.NumericUpDown nmrDNI;
        private System.Windows.Forms.RadioButton rdbtnCarrera5;
        private System.Windows.Forms.RadioButton rdbtnCarrera10;
        private System.Windows.Forms.RadioButton rdbtnCarreras15;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblSeleccion;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnMostrarInscriptos1;
        private System.Windows.Forms.Button btnMostrarInscriptos2;
        private System.Windows.Forms.Button btnMostrarInscriptos3;
        private System.Windows.Forms.Label lblAlertaNombre;
        private System.Windows.Forms.Label lblAlertaApellido;
        private System.Windows.Forms.Label lblAlertaEdadMenor;
        private System.Windows.Forms.Label lblAlertaEdadMayor;
        private System.Windows.Forms.Label lblAlertaDNI;
        private System.Windows.Forms.Label lblAlertaCarrera;
        private System.Windows.Forms.Label lblAceptado;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblNoCupo;
        private System.Windows.Forms.Label lblErrorDNIRepetido;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.DataGridView dgv2;
        private System.Windows.Forms.DataGridView dgv3;
    }
}

