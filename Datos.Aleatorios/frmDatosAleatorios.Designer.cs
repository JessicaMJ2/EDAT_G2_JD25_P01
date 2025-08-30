namespace Datos.Aleatorios
{
    partial class frmDatosAleatorios
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
            label1 = new Label();
            Numero = new Label();
            intNumero = new TextBox();
            Nombre = new Label();
            strNombre = new TextBox();
            Label = new Label();
            strSexoM = new RadioButton();
            strSexoF = new RadioButton();
            Grupo = new Label();
            chrGrupo = new ComboBox();
            Sueldo = new Label();
            dblSueldo = new TextBox();
            blnSeguroMedico = new CheckBox();
            btnGenerarDatos = new Button();
            dtmFechaNacimiento = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 26);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 0;
            label1.Text = "Datos del empleado";
            // 
            // Numero
            // 
            Numero.AutoSize = true;
            Numero.Location = new Point(74, 65);
            Numero.Name = "Numero";
            Numero.Size = new Size(63, 20);
            Numero.TabIndex = 1;
            Numero.Text = "Número";
            Numero.Click += Numero_Click;
            // 
            // intNumero
            // 
            intNumero.Location = new Point(143, 62);
            intNumero.Name = "intNumero";
            intNumero.Size = new Size(92, 27);
            intNumero.TabIndex = 2;
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(73, 122);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 3;
            Nombre.Text = "Nombre";
            // 
            // strNombre
            // 
            strNombre.Location = new Point(144, 115);
            strNombre.Name = "strNombre";
            strNombre.Size = new Size(351, 27);
            strNombre.TabIndex = 4;
            // 
            // Label
            // 
            Label.AutoSize = true;
            Label.Location = new Point(73, 166);
            Label.Name = "Label";
            Label.Size = new Size(125, 20);
            Label.TabIndex = 5;
            Label.Text = "Fecha nacimiento";
            // 
            // strSexoM
            // 
            strSexoM.AutoSize = true;
            strSexoM.Location = new Point(143, 207);
            strSexoM.Name = "strSexoM";
            strSexoM.Size = new Size(97, 24);
            strSexoM.TabIndex = 6;
            strSexoM.TabStop = true;
            strSexoM.Text = "Masculino";
            strSexoM.UseVisualStyleBackColor = true;
            // 
            // strSexoF
            // 
            strSexoF.AutoSize = true;
            strSexoF.Location = new Point(143, 237);
            strSexoF.Name = "strSexoF";
            strSexoF.Size = new Size(95, 24);
            strSexoF.TabIndex = 7;
            strSexoF.TabStop = true;
            strSexoF.Text = "Femenino";
            strSexoF.UseVisualStyleBackColor = true;
            // 
            // Grupo
            // 
            Grupo.AutoSize = true;
            Grupo.Location = new Point(79, 284);
            Grupo.Name = "Grupo";
            Grupo.Size = new Size(50, 20);
            Grupo.TabIndex = 8;
            Grupo.Text = "Grupo";
            // 
            // chrGrupo
            // 
            chrGrupo.FormattingEnabled = true;
            chrGrupo.Location = new Point(143, 281);
            chrGrupo.Name = "chrGrupo";
            chrGrupo.Size = new Size(93, 28);
            chrGrupo.TabIndex = 9;
            // 
            // Sueldo
            // 
            Sueldo.AutoSize = true;
            Sueldo.Location = new Point(74, 333);
            Sueldo.Name = "Sueldo";
            Sueldo.Size = new Size(55, 20);
            Sueldo.TabIndex = 10;
            Sueldo.Text = "Sueldo";
            // 
            // dblSueldo
            // 
            dblSueldo.Location = new Point(143, 330);
            dblSueldo.Name = "dblSueldo";
            dblSueldo.Size = new Size(152, 27);
            dblSueldo.TabIndex = 11;
            // 
            // blnSeguroMedico
            // 
            blnSeguroMedico.AutoSize = true;
            blnSeguroMedico.Location = new Point(143, 380);
            blnSeguroMedico.Name = "blnSeguroMedico";
            blnSeguroMedico.Size = new Size(132, 24);
            blnSeguroMedico.TabIndex = 12;
            blnSeguroMedico.Text = "Seguro médico";
            blnSeguroMedico.UseVisualStyleBackColor = true;
            // 
            // btnGenerarDatos
            // 
            btnGenerarDatos.Location = new Point(46, 438);
            btnGenerarDatos.Name = "btnGenerarDatos";
            btnGenerarDatos.Size = new Size(498, 29);
            btnGenerarDatos.TabIndex = 13;
            btnGenerarDatos.Text = "Generar datos aleatorios";
            btnGenerarDatos.UseVisualStyleBackColor = true;
            btnGenerarDatos.Click += btnGenerarDatos_Click;
            // 
            // dtmFechaNacimiento
            // 
            dtmFechaNacimiento.Location = new Point(205, 161);
            dtmFechaNacimiento.Name = "dtmFechaNacimiento";
            dtmFechaNacimiento.Size = new Size(290, 27);
            dtmFechaNacimiento.TabIndex = 15;
            // 
            // frmDatosAleatorios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 486);
            Controls.Add(dtmFechaNacimiento);
            Controls.Add(btnGenerarDatos);
            Controls.Add(blnSeguroMedico);
            Controls.Add(dblSueldo);
            Controls.Add(Sueldo);
            Controls.Add(chrGrupo);
            Controls.Add(Grupo);
            Controls.Add(strSexoF);
            Controls.Add(strSexoM);
            Controls.Add(Label);
            Controls.Add(strNombre);
            Controls.Add(Nombre);
            Controls.Add(intNumero);
            Controls.Add(Numero);
            Controls.Add(label1);
            Name = "frmDatosAleatorios";
            Text = "frmDatosAleatorios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Numero;
        private TextBox intNumero;
        private Label Nombre;
        private TextBox strNombre;
        private Label Label;
        private RadioButton strSexoM;
        private RadioButton strSexoF;
        private Label Grupo;
        private ComboBox chrGrupo;
        private Label Sueldo;
        private TextBox dblSueldo;
        private CheckBox blnSeguroMedico;
        private Button btnGenerarDatos;
        private DateTimePicker dtmFechaNacimiento;
    }
}