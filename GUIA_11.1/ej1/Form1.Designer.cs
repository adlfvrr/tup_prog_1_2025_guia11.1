namespace ej1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnRegistrar = new Button();
            tbIngreso = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnMaximoYMinimo = new Button();
            lbMinimo = new Label();
            lbMaximo = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            btnPromedio = new Button();
            lbPromedio = new Label();
            label4 = new Label();
            groupBox4 = new GroupBox();
            lbCantidad = new Label();
            label5 = new Label();
            btnCantidad = new Button();
            btnReiniciar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(tbIngreso);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(590, 179);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Procesar número";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(190, 106);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(186, 50);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar número";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbIngreso
            // 
            tbIngreso.Location = new Point(271, 49);
            tbIngreso.Name = "tbIngreso";
            tbIngreso.Size = new Size(154, 34);
            tbIngreso.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 52);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un número:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnMaximoYMinimo);
            groupBox2.Controls.Add(lbMinimo);
            groupBox2.Controls.Add(lbMaximo);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 197);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(590, 126);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Procesar máximo y mínimo";
            // 
            // btnMaximoYMinimo
            // 
            btnMaximoYMinimo.Location = new Point(381, 40);
            btnMaximoYMinimo.Name = "btnMaximoYMinimo";
            btnMaximoYMinimo.Size = new Size(186, 50);
            btnMaximoYMinimo.TabIndex = 3;
            btnMaximoYMinimo.Text = "Actualizar";
            btnMaximoYMinimo.UseVisualStyleBackColor = true;
            btnMaximoYMinimo.Click += btnMaximoYMinimo_Click;
            // 
            // lbMinimo
            // 
            lbMinimo.BackColor = SystemColors.ActiveCaption;
            lbMinimo.Location = new Point(247, 78);
            lbMinimo.Name = "lbMinimo";
            lbMinimo.Size = new Size(75, 28);
            lbMinimo.TabIndex = 3;
            // 
            // lbMaximo
            // 
            lbMaximo.BackColor = SystemColors.ActiveCaption;
            lbMaximo.Location = new Point(247, 40);
            lbMaximo.Name = "lbMaximo";
            lbMaximo.Size = new Size(75, 28);
            lbMaximo.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(105, 78);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 1;
            label3.Text = "Valor mínimo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(105, 40);
            label2.Name = "label2";
            label2.Size = new Size(136, 28);
            label2.TabIndex = 0;
            label2.Text = "Valor máximo:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnPromedio);
            groupBox3.Controls.Add(lbPromedio);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(12, 329);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(590, 84);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Procesar promedio";
            // 
            // btnPromedio
            // 
            btnPromedio.Location = new Point(381, 28);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(186, 50);
            btnPromedio.TabIndex = 4;
            btnPromedio.Text = "Actualizar";
            btnPromedio.UseVisualStyleBackColor = true;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // lbPromedio
            // 
            lbPromedio.BackColor = SystemColors.ActiveCaption;
            lbPromedio.Location = new Point(247, 39);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(75, 28);
            lbPromedio.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 39);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 0;
            label4.Text = "Promedio:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lbCantidad);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(btnCantidad);
            groupBox4.Location = new Point(12, 419);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(579, 98);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mostrar cantidad de ingresados";
            // 
            // lbCantidad
            // 
            lbCantidad.BackColor = SystemColors.ActiveCaption;
            lbCantidad.Location = new Point(247, 44);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(75, 28);
            lbCantidad.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(105, 44);
            label5.Name = "label5";
            label5.Size = new Size(95, 28);
            label5.TabIndex = 6;
            label5.Text = "Cantidad:";
            // 
            // btnCantidad
            // 
            btnCantidad.Location = new Point(381, 33);
            btnCantidad.Name = "btnCantidad";
            btnCantidad.Size = new Size(186, 50);
            btnCantidad.TabIndex = 5;
            btnCantidad.Text = "Actualizar";
            btnCantidad.UseVisualStyleBackColor = true;
            btnCantidad.Click += btnCantidad_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(163, 541);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(274, 50);
            btnReiniciar.TabIndex = 7;
            btnReiniciar.Text = "Reiniciar Variables";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 603);
            Controls.Add(btnReiniciar);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Ejercicio 1. Introducción";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRegistrar;
        private TextBox tbIngreso;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnMaximoYMinimo;
        private Label lbMinimo;
        private Label lbMaximo;
        private Label label3;
        private Label label2;
        private GroupBox groupBox3;
        private Label lbPromedio;
        private Label label4;
        private GroupBox groupBox4;
        private Button btnPromedio;
        private Label lbCantidad;
        private Label label5;
        private Button btnCantidad;
        private Button btnReiniciar;
    }
}
