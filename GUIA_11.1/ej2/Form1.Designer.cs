namespace ej2
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
            btnRegistrarMonto = new Button();
            tbMonto = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnRegistrarEdades = new Button();
            tbEdad4 = new TextBox();
            tbEdad3 = new TextBox();
            tbEdad2 = new TextBox();
            tbEdad1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox3 = new GroupBox();
            lsbResultado = new ListBox();
            btnResultado = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrarMonto);
            groupBox1.Controls.Add(tbMonto);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(793, 147);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Solicitud de monto a repartir";
            // 
            // btnRegistrarMonto
            // 
            btnRegistrarMonto.Location = new Point(457, 34);
            btnRegistrarMonto.Name = "btnRegistrarMonto";
            btnRegistrarMonto.Size = new Size(227, 52);
            btnRegistrarMonto.TabIndex = 2;
            btnRegistrarMonto.Text = "Registrar monto";
            btnRegistrarMonto.UseVisualStyleBackColor = true;
            btnRegistrarMonto.Click += btnRegistrarMonto_Click;
            // 
            // tbMonto
            // 
            tbMonto.Location = new Point(132, 43);
            tbMonto.Name = "tbMonto";
            tbMonto.Size = new Size(234, 34);
            tbMonto.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 46);
            label1.Name = "label1";
            label1.Size = new Size(76, 28);
            label1.TabIndex = 0;
            label1.Text = "Monto:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRegistrarEdades);
            groupBox2.Controls.Add(tbEdad4);
            groupBox2.Controls.Add(tbEdad3);
            groupBox2.Controls.Add(tbEdad2);
            groupBox2.Controls.Add(tbEdad1);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(12, 165);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(793, 219);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Solicitud de las edades de las niñas";
            // 
            // btnRegistrarEdades
            // 
            btnRegistrarEdades.Location = new Point(290, 153);
            btnRegistrarEdades.Name = "btnRegistrarEdades";
            btnRegistrarEdades.Size = new Size(227, 52);
            btnRegistrarEdades.TabIndex = 3;
            btnRegistrarEdades.Text = "Registrar edades";
            btnRegistrarEdades.UseVisualStyleBackColor = true;
            btnRegistrarEdades.Click += btnRegistrarEdades_Click;
            // 
            // tbEdad4
            // 
            tbEdad4.Location = new Point(372, 100);
            tbEdad4.Name = "tbEdad4";
            tbEdad4.Size = new Size(116, 34);
            tbEdad4.TabIndex = 6;
            // 
            // tbEdad3
            // 
            tbEdad3.Location = new Point(372, 51);
            tbEdad3.Name = "tbEdad3";
            tbEdad3.Size = new Size(116, 34);
            tbEdad3.TabIndex = 5;
            // 
            // tbEdad2
            // 
            tbEdad2.Location = new Point(132, 100);
            tbEdad2.Name = "tbEdad2";
            tbEdad2.Size = new Size(116, 34);
            tbEdad2.TabIndex = 4;
            // 
            // tbEdad1
            // 
            tbEdad1.Location = new Point(132, 51);
            tbEdad1.Name = "tbEdad1";
            tbEdad1.Size = new Size(116, 34);
            tbEdad1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(290, 103);
            label5.Name = "label5";
            label5.Size = new Size(76, 28);
            label5.TabIndex = 3;
            label5.Text = "Edad 4:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(290, 54);
            label4.Name = "label4";
            label4.Size = new Size(76, 28);
            label4.TabIndex = 2;
            label4.Text = "Edad 3:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 103);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 1;
            label3.Text = "Edad 2:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 54);
            label2.Name = "label2";
            label2.Size = new Size(76, 28);
            label2.TabIndex = 0;
            label2.Text = "Edad 1:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lsbResultado);
            groupBox3.Controls.Add(btnResultado);
            groupBox3.Location = new Point(12, 390);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(793, 214);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Monto y porcentajes de las niñas";
            // 
            // lsbResultado
            // 
            lsbResultado.FormattingEnabled = true;
            lsbResultado.ItemHeight = 28;
            lsbResultado.Location = new Point(6, 33);
            lsbResultado.Name = "lsbResultado";
            lsbResultado.Size = new Size(591, 172);
            lsbResultado.TabIndex = 8;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(603, 86);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(163, 52);
            btnResultado.TabIndex = 7;
            btnResultado.Text = "Actualizar";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 616);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnRegistrarMonto;
        private TextBox tbMonto;
        private Label label1;
        private GroupBox groupBox2;
        private Label label2;
        private Button btnRegistrarEdades;
        private TextBox tbEdad4;
        private TextBox tbEdad3;
        private TextBox tbEdad2;
        private TextBox tbEdad1;
        private Label label5;
        private Label label4;
        private Label label3;
        private GroupBox groupBox3;
        private ListBox lsbResultado;
        private Button btnResultado;
    }
}
