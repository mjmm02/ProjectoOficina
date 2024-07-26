namespace ProjectoOficina
{
    partial class FormEditarMecanico
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
            labelNomeMc = new Label();
            labelNovoNomeMc = new Label();
            textBox1 = new TextBox();
            buttonGuardar = new Button();
            buttonSair = new Button();
            SuspendLayout();
            // 
            // labelNomeMc
            // 
            labelNomeMc.AutoSize = true;
            labelNomeMc.Location = new Point(248, 93);
            labelNomeMc.Name = "labelNomeMc";
            labelNomeMc.Size = new Size(38, 15);
            labelNomeMc.TabIndex = 0;
            labelNomeMc.Text = "label1";
            labelNomeMc.Click += label1_Click;
            // 
            // labelNovoNomeMc
            // 
            labelNovoNomeMc.AutoSize = true;
            labelNovoNomeMc.Location = new Point(172, 146);
            labelNovoNomeMc.Name = "labelNovoNomeMc";
            labelNovoNomeMc.Size = new Size(70, 15);
            labelNovoNomeMc.TabIndex = 1;
            labelNovoNomeMc.Text = "Novo nome";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(248, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(180, 210);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 3;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonSair
            // 
            buttonSair.Location = new Point(273, 210);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(75, 23);
            buttonSair.TabIndex = 4;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = true;
            buttonSair.Click += buttonSair_Click;
            // 
            // FormEditarMecanico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSair);
            Controls.Add(buttonGuardar);
            Controls.Add(textBox1);
            Controls.Add(labelNovoNomeMc);
            Controls.Add(labelNomeMc);
            Name = "FormEditarMecanico";
            Text = "FormEditarMecanico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNomeMc;
        private Label labelNovoNomeMc;
        private TextBox textBox1;
        private Button buttonGuardar;
        private Button buttonSair;
    }
}