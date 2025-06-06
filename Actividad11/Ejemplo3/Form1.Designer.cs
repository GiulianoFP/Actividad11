namespace Ejemplo3
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
            tbProm = new TextBox();
            btnMProm = new Button();
            lbPromedio = new Label();
            btnRegistrar = new Button();
            tbIngreso = new TextBox();
            lbIngreso = new Label();
            SuspendLayout();
            // 
            // tbProm
            // 
            tbProm.Location = new Point(39, 218);
            tbProm.Multiline = true;
            tbProm.Name = "tbProm";
            tbProm.Size = new Size(407, 138);
            tbProm.TabIndex = 11;
            // 
            // btnMProm
            // 
            btnMProm.Location = new Point(361, 138);
            btnMProm.Name = "btnMProm";
            btnMProm.Size = new Size(85, 48);
            btnMProm.TabIndex = 10;
            btnMProm.Text = "Mostrar Promedio";
            btnMProm.UseVisualStyleBackColor = true;
            btnMProm.Click += btnMProm_Click_1;
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.Location = new Point(39, 155);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(69, 15);
            lbPromedio.TabIndex = 9;
            lbPromedio.Text = "lbPromedio";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(361, 88);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(85, 23);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // tbIngreso
            // 
            tbIngreso.Location = new Point(183, 85);
            tbIngreso.Name = "tbIngreso";
            tbIngreso.Size = new Size(100, 23);
            tbIngreso.TabIndex = 7;
            // 
            // lbIngreso
            // 
            lbIngreso.AutoSize = true;
            lbIngreso.Location = new Point(39, 92);
            lbIngreso.Name = "lbIngreso";
            lbIngreso.Size = new Size(91, 15);
            lbIngreso.TabIndex = 6;
            lbIngreso.Text = "Ingrese un valor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 450);
            Controls.Add(tbProm);
            Controls.Add(btnMProm);
            Controls.Add(lbPromedio);
            Controls.Add(btnRegistrar);
            Controls.Add(tbIngreso);
            Controls.Add(lbIngreso);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbProm;
        private Button btnMProm;
        private Label lbPromedio;
        private Button btnRegistrar;
        private TextBox tbIngreso;
        private Label lbIngreso;
    }
}
