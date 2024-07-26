namespace ProjectoOficina
{
    partial class FormMarcacoes
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
            labelData = new Label();
            labelCliente = new Label();
            labelMecanico = new Label();
            labelCarro = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            listBoxMarcacoes = new ListBox();
            buttonGuardar = new Button();
            buttonCancel = new Button();
            buttonEditar = new Button();
            buttonRemover = new Button();
            SuspendLayout();
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(144, 47);
            labelData.Name = "labelData";
            labelData.Size = new Size(31, 15);
            labelData.TabIndex = 0;
            labelData.Text = "Data";
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(144, 99);
            labelCliente.Name = "labelCliente";
            labelCliente.Size = new Size(44, 15);
            labelCliente.TabIndex = 1;
            labelCliente.Text = "Cliente";
            // 
            // labelMecanico
            // 
            labelMecanico.AutoSize = true;
            labelMecanico.Location = new Point(144, 153);
            labelMecanico.Name = "labelMecanico";
            labelMecanico.Size = new Size(59, 15);
            labelMecanico.TabIndex = 2;
            labelMecanico.Text = "Mecanico";
            // 
            // labelCarro
            // 
            labelCarro.AutoSize = true;
            labelCarro.Location = new Point(144, 211);
            labelCarro.Name = "labelCarro";
            labelCarro.Size = new Size(36, 15);
            labelCarro.TabIndex = 3;
            labelCarro.Text = "Carro";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(211, 96);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(211, 150);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(211, 208);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            // 
            // listBoxMarcacoes
            // 
            listBoxMarcacoes.FormattingEnabled = true;
            listBoxMarcacoes.ItemHeight = 15;
            listBoxMarcacoes.Location = new Point(144, 296);
            listBoxMarcacoes.Name = "listBoxMarcacoes";
            listBoxMarcacoes.Size = new Size(280, 124);
            listBoxMarcacoes.TabIndex = 8;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(349, 47);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 9;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(349, 96);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(450, 296);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 11;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.Location = new Point(450, 357);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(75, 23);
            buttonRemover.TabIndex = 12;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // FormMarcacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonRemover);
            Controls.Add(buttonEditar);
            Controls.Add(buttonCancel);
            Controls.Add(buttonGuardar);
            Controls.Add(listBoxMarcacoes);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelCarro);
            Controls.Add(labelMecanico);
            Controls.Add(labelCliente);
            Controls.Add(labelData);
            Name = "FormMarcacoes";
            Text = "FormMarcacoes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelData;
        private Label labelCliente;
        private Label labelMecanico;
        private Label labelCarro;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ListBox listBoxMarcacoes;
        private Button buttonGuardar;
        private Button buttonCancel;
        private Button buttonEditar;
        private Button buttonRemover;
    }
}