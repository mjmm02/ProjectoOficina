namespace ProjectoOficina
{
    partial class FormCliente
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
            buttonCriarRegisto = new Button();
            buttonCancel = new Button();
            buttonEditar = new Button();
            buttonRemover = new Button();
            listBoxClientes = new ListBox();
            labelCliente = new Label();
            textBoxNome = new TextBox();
            SuspendLayout();
            // 
            // buttonCriarRegisto
            // 
            buttonCriarRegisto.Location = new Point(131, 221);
            buttonCriarRegisto.Name = "buttonCriarRegisto";
            buttonCriarRegisto.Size = new Size(84, 33);
            buttonCriarRegisto.TabIndex = 0;
            buttonCriarRegisto.Text = "Criar Registo";
            buttonCriarRegisto.UseVisualStyleBackColor = true;
            buttonCriarRegisto.Click += buttonCriarRegisto_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(237, 221);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(78, 33);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(524, 260);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(106, 47);
            buttonEditar.TabIndex = 2;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += buttonEditar_Click;
            // 
            // buttonRemover
            // 
            buttonRemover.Location = new Point(524, 339);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(106, 46);
            buttonRemover.TabIndex = 3;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // listBoxClientes
            // 
            listBoxClientes.FormattingEnabled = true;
            listBoxClientes.ItemHeight = 15;
            listBoxClientes.Location = new Point(131, 260);
            listBoxClientes.Name = "listBoxClientes";
            listBoxClientes.Size = new Size(313, 154);
            listBoxClientes.TabIndex = 5;
            // 
            // labelCliente
            // 
            labelCliente.AutoSize = true;
            labelCliente.Location = new Point(131, 141);
            labelCliente.Name = "labelCliente";
            labelCliente.RightToLeft = RightToLeft.Yes;
            labelCliente.Size = new Size(95, 15);
            labelCliente.TabIndex = 6;
            labelCliente.Text = "Nome do cliente";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(237, 138);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 7;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 450);
            Controls.Add(textBoxNome);
            Controls.Add(labelCliente);
            Controls.Add(listBoxClientes);
            Controls.Add(buttonRemover);
            Controls.Add(buttonEditar);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCriarRegisto);
            Name = "FormCliente";
            Text = "Ficha de cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCriarRegisto;
        private Button buttonCancel;
        private Button buttonEditar;
        private Button buttonRemover;
        private ListBox listBoxClientes;
        private Label labelCliente;
        private TextBox textBoxNome;
    }
}