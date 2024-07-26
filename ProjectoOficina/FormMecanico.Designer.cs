namespace ProjectoOficina
{
    partial class FormMecanico
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
            buttonCriarMec = new Button();
            buttonCancel = new Button();
            buttonEditar = new Button();
            buttonDelete = new Button();
            listBox1 = new ListBox();
            textBoxNomeMec = new TextBox();
            labelNome = new Label();
            SuspendLayout();
            // 
            // buttonCriarMec
            // 
            buttonCriarMec.Location = new Point(119, 215);
            buttonCriarMec.Name = "buttonCriarMec";
            buttonCriarMec.Size = new Size(75, 23);
            buttonCriarMec.TabIndex = 0;
            buttonCriarMec.Text = "Criar";
            buttonCriarMec.UseVisualStyleBackColor = true;
            buttonCriarMec.Click += buttonCriarMec_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(226, 215);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 1;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(526, 294);
            buttonEditar.Name = "buttonEditar";
            buttonEditar.Size = new Size(75, 23);
            buttonEditar.TabIndex = 2;
            buttonEditar.Text = "Editar";
            buttonEditar.UseVisualStyleBackColor = true;
            buttonEditar.Click += button3_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(526, 354);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 3;
            buttonDelete.Text = "Eliminar";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(119, 280);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(317, 139);
            listBox1.TabIndex = 4;
            // 
            // textBoxNomeMec
            // 
            textBoxNomeMec.Location = new Point(160, 122);
            textBoxNomeMec.Name = "textBoxNomeMec";
            textBoxNomeMec.Size = new Size(124, 23);
            textBoxNomeMec.TabIndex = 5;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(116, 125);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(40, 15);
            labelNome.TabIndex = 6;
            labelNome.Text = "Nome";
            // 
            // FormMecanico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 460);
            Controls.Add(labelNome);
            Controls.Add(textBoxNomeMec);
            Controls.Add(listBox1);
            Controls.Add(buttonDelete);
            Controls.Add(buttonEditar);
            Controls.Add(buttonCancel);
            Controls.Add(buttonCriarMec);
            Name = "FormMecanico";
            Text = "FormMecanico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCriarMec;
        private Button buttonCancel;
        private Button buttonEditar;
        private Button buttonDelete;
        private ListBox listBox1;
        private TextBox textBoxNomeMec;
        private Label labelNome;
    }
}