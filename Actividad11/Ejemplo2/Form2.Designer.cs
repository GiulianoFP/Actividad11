namespace Ejemplo2
{
    partial class Form2
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
            lbIngreso = new Label();
            tbIngreso = new TextBox();
            btnRegistrar = new Button();
            lbPromedio = new Label();
            btnMProm = new Button();
            tbProm = new TextBox();
            SuspendLayout();
            // 
            // lbIngreso
            // 
            lbIngreso.AutoSize = true;
            lbIngreso.Location = new Point(40, 49);
            lbIngreso.Name = "lbIngreso";
            lbIngreso.Size = new Size(91, 15);
            lbIngreso.TabIndex = 0;
            lbIngreso.Text = "Ingrese un valor";
            // 
            // tbIngreso
            // 
            tbIngreso.Location = new Point(184, 42);
            tbIngreso.Name = "tbIngreso";
            tbIngreso.Size = new Size(100, 23);
            tbIngreso.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(362, 45);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(85, 23);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.Location = new Point(40, 112);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(69, 15);
            lbPromedio.TabIndex = 3;
            lbPromedio.Text = "lbPromedio";
            // 
            // btnMProm
            // 
            btnMProm.Location = new Point(362, 95);
            btnMProm.Name = "btnMProm";
            btnMProm.Size = new Size(85, 48);
            btnMProm.TabIndex = 4;
            btnMProm.Text = "Mostrar Promedio";
            btnMProm.UseVisualStyleBackColor = true;
            btnMProm.Click += btnMProm_Click;
            // 
            // tbProm
            // 
            tbProm.Location = new Point(40, 175);
            tbProm.Multiline = true;
            tbProm.Name = "tbProm";
            tbProm.Size = new Size(407, 138);
            tbProm.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 359);
            Controls.Add(tbProm);
            Controls.Add(btnMProm);
            Controls.Add(lbPromedio);
            Controls.Add(btnRegistrar);
            Controls.Add(tbIngreso);
            Controls.Add(lbIngreso);
            Name = "Form2";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbIngreso;
        private TextBox tbIngreso;
        private Button btnRegistrar;
        private Label lbPromedio;
        private Button btnMProm;
        private TextBox tbProm;
    }
}
