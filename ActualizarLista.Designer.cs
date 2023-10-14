namespace Ejemplo_codigo_profesores
{
    partial class ActualizarLista
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
            Actualizar = new Button();
            Volver = new Button();
            button2 = new Button();
            textBox8 = new TextBox();
            button12 = new Button();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            dataGridViewProfesores = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Especialidad = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            NumeroId = new DataGridViewTextBoxColumn();
            ListarProfesores = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProfesores).BeginInit();
            SuspendLayout();
            // 
            // Actualizar
            // 
            Actualizar.Location = new Point(595, 41);
            Actualizar.Name = "Actualizar";
            Actualizar.Size = new Size(124, 23);
            Actualizar.TabIndex = 63;
            Actualizar.Text = "Actualizar/Editar";
            Actualizar.UseVisualStyleBackColor = true;
            Actualizar.Click += Actualizar_Click;
            // 
            // Volver
            // 
            Volver.Location = new Point(12, 348);
            Volver.Name = "Volver";
            Volver.Size = new Size(75, 23);
            Volver.TabIndex = 61;
            Volver.Text = "Volver";
            Volver.UseVisualStyleBackColor = true;
            Volver.Click += Volver_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 398);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 60;
            button2.Text = "salida";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(171, 227);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(221, 23);
            textBox8.TabIndex = 59;
            textBox8.TextChanged += campoIdentificacion_TextChanged;
            // 
            // button12
            // 
            button12.Location = new Point(12, 162);
            button12.Name = "button12";
            button12.Size = new Size(140, 28);
            button12.TabIndex = 58;
            button12.Text = "Dirección de Residencia";
            button12.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(171, 199);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(221, 23);
            textBox7.TabIndex = 57;
            textBox7.TextChanged += campoFechaNacimiento_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(171, 162);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(221, 23);
            textBox6.TabIndex = 56;
            textBox6.TextChanged += campoDireccion_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(169, 133);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(223, 23);
            textBox5.TabIndex = 55;
            textBox5.TextChanged += campoCorreo_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(103, 98);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(224, 23);
            textBox4.TabIndex = 54;
            textBox4.TextChanged += campoTelefono_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(103, 69);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(224, 23);
            textBox3.TabIndex = 53;
            textBox3.TextChanged += campoEspecialidad_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(103, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(224, 23);
            textBox2.TabIndex = 52;
            textBox2.TextChanged += campoApellido_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(103, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 23);
            textBox1.TabIndex = 51;
            textBox1.TextChanged += campoNombre_TextChanged;
            // 
            // button11
            // 
            button11.Location = new Point(12, 227);
            button11.Name = "button11";
            button11.Size = new Size(151, 23);
            button11.TabIndex = 50;
            button11.Text = "Numero Identificación";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Location = new Point(12, 198);
            button10.Name = "button10";
            button10.Size = new Size(128, 23);
            button10.TabIndex = 49;
            button10.Text = "Fecha Nacimiento";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(12, 128);
            button9.Name = "button9";
            button9.Size = new Size(128, 23);
            button9.TabIndex = 48;
            button9.Text = "Correo Electronico";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(12, 99);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 47;
            button8.Text = "Telefono";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(12, 70);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 46;
            button7.Text = "Especialidad";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(12, 41);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 45;
            button6.Text = "Apellido";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(12, 12);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 44;
            button5.Text = "Nombre";
            button5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProfesores
            // 
            dataGridViewProfesores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProfesores.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Especialidad, Telefono, Correo, Direccion, Fecha, NumeroId });
            dataGridViewProfesores.Location = new Point(139, 271);
            dataGridViewProfesores.Name = "dataGridViewProfesores";
            dataGridViewProfesores.RowTemplate.Height = 25;
            dataGridViewProfesores.Size = new Size(638, 150);
            dataGridViewProfesores.TabIndex = 64;
            dataGridViewProfesores.CellClick += dataGridViewProfesores_CellClick;
            dataGridViewProfesores.CellContentClick += dataGridViewProfesores_CellClick;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Profesor";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido Profesor";
            Apellido.Name = "Apellido";
            // 
            // Especialidad
            // 
            Especialidad.HeaderText = "Especialidad Profesor";
            Especialidad.Name = "Especialidad";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono Profesor";
            Telefono.Name = "Telefono";
            // 
            // Correo
            // 
            Correo.HeaderText = "Correo Electronico Profesor";
            Correo.Name = "Correo";
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Dirección Residencia Profesor";
            Direccion.Name = "Direccion";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha Nacimiento Profesor";
            Fecha.Name = "Fecha";
            // 
            // NumeroId
            // 
            NumeroId.HeaderText = "Numero Identificación Profesor";
            NumeroId.Name = "NumeroId";
            // 
            // ListarProfesores
            // 
            ListarProfesores.Location = new Point(595, 98);
            ListarProfesores.Name = "ListarProfesores";
            ListarProfesores.Size = new Size(124, 44);
            ListarProfesores.TabIndex = 66;
            ListarProfesores.Text = "Listar los profesores guardados";
            ListarProfesores.UseVisualStyleBackColor = true;
            ListarProfesores.Click += ListarProfesores_Click;
            // 
            // ActualizarLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListarProfesores);
            Controls.Add(dataGridViewProfesores);
            Controls.Add(Actualizar);
            Controls.Add(Volver);
            Controls.Add(button2);
            Controls.Add(textBox8);
            Controls.Add(button12);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Name = "ActualizarLista";
            Text = "ActualizarLista";
            Load += ActualizarLista_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProfesores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Actualizar;
        private Button Volver;
        private Button button2;
        private TextBox textBox8;
        private Button button12;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private DataGridView dataGridViewProfesores;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Especialidad;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn NumeroId;
        private Button ListarProfesores;
    }
}