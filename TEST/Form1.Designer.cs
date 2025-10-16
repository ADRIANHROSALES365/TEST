namespace TEST
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
            GDV01 = new DataGridView();
            B_Agregar_01 = new Button();
            B_Editar_01 = new Button();
            B_Borrar_02 = new Button();
            button1 = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)GDV01).BeginInit();
            SuspendLayout();
            // 
            // GDV01
            // 
            GDV01.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GDV01.Location = new Point(12, 90);
            GDV01.Name = "GDV01";
            GDV01.RowHeadersWidth = 51;
            GDV01.Size = new Size(776, 291);
            GDV01.TabIndex = 0;
            // 
            // B_Agregar_01
            // 
            B_Agregar_01.Location = new Point(29, 55);
            B_Agregar_01.Name = "B_Agregar_01";
            B_Agregar_01.Size = new Size(94, 29);
            B_Agregar_01.TabIndex = 1;
            B_Agregar_01.Text = "Agregar";
            B_Agregar_01.UseVisualStyleBackColor = true;
            B_Agregar_01.Click += B_Agregar_01_Click;
            // 
            // B_Editar_01
            // 
            B_Editar_01.Location = new Point(344, 55);
            B_Editar_01.Name = "B_Editar_01";
            B_Editar_01.Size = new Size(94, 29);
            B_Editar_01.TabIndex = 2;
            B_Editar_01.Text = "Editar";
            B_Editar_01.UseVisualStyleBackColor = true;
            // 
            // B_Borrar_02
            // 
            B_Borrar_02.Location = new Point(664, 55);
            B_Borrar_02.Name = "B_Borrar_02";
            B_Borrar_02.Size = new Size(94, 29);
            B_Borrar_02.TabIndex = 3;
            B_Borrar_02.Text = "Cambiar";
            B_Borrar_02.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(202, 396);
            button1.Name = "button1";
            button1.Size = new Size(408, 51);
            button1.TabIndex = 4;
            button1.Text = "Historial";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 5;
            label1.Text = "Control Concursos 2025";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(B_Borrar_02);
            Controls.Add(B_Editar_01);
            Controls.Add(B_Agregar_01);
            Controls.Add(GDV01);
            Name = "Form1";
            Text = "Control Propuestas realizadas";
            ((System.ComponentModel.ISupportInitialize)GDV01).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView GDV01;
        private Button B_Agregar_01;
        private Button B_Editar_01;
        private Button B_Borrar_02;
        private Button button1;
        private Label label1;
    }
}
