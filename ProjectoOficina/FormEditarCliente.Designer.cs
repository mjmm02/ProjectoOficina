namespace ProjectoOficina
{
    partial class FormEditarCliente
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
            buttonConfirm = new Button();
            textBoxNome = new TextBox();
            textBoxNvNome = new TextBox();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 84);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome de cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 146);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "Novo nome";
            // 
            // buttonConfirm
            // 
            buttonConfirm.Location = new Point(467, 76);
            buttonConfirm.Name = "buttonConfirm";
            buttonConfirm.Size = new Size(86, 37);
            buttonConfirm.TabIndex = 2;
            buttonConfirm.Text = "Confirmar";
            buttonConfirm.UseVisualStyleBackColor = true;
            buttonConfirm.Click += buttonConfirm_Click;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(240, 76);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(100, 23);
            textBoxNome.TabIndex = 3;
            textBoxNome.TextChanged += textBox1_TextChanged;
            // 
            // textBoxNvNome
            // 
            textBoxNvNome.Location = new Point(240, 143);
            textBoxNvNome.Name = "textBoxNvNome";
            textBoxNvNome.Size = new Size(100, 23);
            textBoxNvNome.TabIndex = 4;
            textBoxNvNome.TextChanged += textBoxNvNome_TextChanged;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(467, 143);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(86, 37);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Cancelar";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormEditarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCancel);
            Controls.Add(textBoxNvNome);
            Controls.Add(textBoxNome);
            Controls.Add(buttonConfirm);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormEditarCliente";
            Text = "FormEditarCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonConfirm;
        private TextBox textBoxNome;
        private TextBox textBoxNvNome;
        private Button buttonCancel;
    }
}