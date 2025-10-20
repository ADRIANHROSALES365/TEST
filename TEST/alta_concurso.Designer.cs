namespace TEST
{
    partial class alta_concurso
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            tb_nombre = new TextBox();
            tb_persona = new TextBox();
            tb_dependencia = new TextBox();
            tb_precio = new TextBox();
            cb_status = new ComboBox();
            calendar_1 = new MonthCalendar();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 42);
            label1.Name = "label1";
            label1.Size = new Size(136, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre Concurso :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 118);
            label2.Name = "label2";
            label2.Size = new Size(171, 20);
            label2.TabIndex = 1;
            label2.Text = "Persona que lo encargo :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 189);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 2;
            label3.Text = "Dependencia :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 239);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 3;
            label4.Text = "Fecha:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(504, 42);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 4;
            label5.Text = "Precio:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(505, 118);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 5;
            label6.Text = "Status:";
            // 
            // button1
            // 
            button1.Location = new Point(504, 321);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(662, 321);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 7;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            // 
            // tb_nombre
            // 
            tb_nombre.Location = new Point(174, 35);
            tb_nombre.Name = "tb_nombre";
            tb_nombre.Size = new Size(257, 27);
            tb_nombre.TabIndex = 8;
            // 
            // tb_persona
            // 
            tb_persona.Location = new Point(208, 111);
            tb_persona.Name = "tb_persona";
            tb_persona.Size = new Size(223, 27);
            tb_persona.TabIndex = 9;
            // 
            // tb_dependencia
            // 
            tb_dependencia.Location = new Point(174, 182);
            tb_dependencia.Name = "tb_dependencia";
            tb_dependencia.Size = new Size(257, 27);
            tb_dependencia.TabIndex = 10;
            // 
            // tb_precio
            // 
            tb_precio.Location = new Point(589, 39);
            tb_precio.Name = "tb_precio";
            tb_precio.Size = new Size(125, 27);
            tb_precio.TabIndex = 12;
            tb_precio.TextChanged += textBox5_TextChanged;
            // 
            // cb_status
            // 
            cb_status.FormattingEnabled = true;
            cb_status.Items.AddRange(new object[] { "EN PROGRESO", "ENTREGADO", "PAGADO" });
            cb_status.Location = new Point(589, 115);
            cb_status.Name = "cb_status";
            cb_status.Size = new Size(151, 28);
            cb_status.TabIndex = 13;
            // 
            // calendar_1
            // 
            calendar_1.Location = new Point(174, 239);
            calendar_1.Name = "calendar_1";
            calendar_1.TabIndex = 14;
            // 
            // button3
            // 
            button3.Location = new Point(598, 381);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 15;
            button3.Text = "Cerrar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // alta_concurso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(calendar_1);
            Controls.Add(cb_status);
            Controls.Add(tb_precio);
            Controls.Add(tb_dependencia);
            Controls.Add(tb_persona);
            Controls.Add(tb_nombre);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "alta_concurso";
            Text = "alta_concurso";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private TextBox tb_nombre;
        private TextBox tb_persona;
        private TextBox tb_dependencia;
        private TextBox tb_precio;
        private ComboBox cb_status;
        private MonthCalendar calendar_1;
        private Button button3;
    }
}