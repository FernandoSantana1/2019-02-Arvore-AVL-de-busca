namespace Arvore_De_Busca
{
    partial class Form1
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
            this.btnLargura = new System.Windows.Forms.Button();
            this.btnEmOrdem = new System.Windows.Forms.Button();
            this.btnPosOrdem = new System.Windows.Forms.Button();
            this.btnPreOrdem = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.lblstats = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLargura
            // 
            this.btnLargura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLargura.Location = new System.Drawing.Point(427, 88);
            this.btnLargura.Name = "btnLargura";
            this.btnLargura.Size = new System.Drawing.Size(80, 35);
            this.btnLargura.TabIndex = 26;
            this.btnLargura.Text = "Largura";
            this.btnLargura.UseVisualStyleBackColor = true;
            this.btnLargura.Click += new System.EventHandler(this.BtnLargura_Click);
            // 
            // btnEmOrdem
            // 
            this.btnEmOrdem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmOrdem.Location = new System.Drawing.Point(346, 88);
            this.btnEmOrdem.Name = "btnEmOrdem";
            this.btnEmOrdem.Size = new System.Drawing.Size(80, 35);
            this.btnEmOrdem.TabIndex = 25;
            this.btnEmOrdem.Text = "Em ordem";
            this.btnEmOrdem.UseVisualStyleBackColor = true;
            this.btnEmOrdem.Click += new System.EventHandler(this.BtnEmOrdem_Click);
            // 
            // btnPosOrdem
            // 
            this.btnPosOrdem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPosOrdem.Location = new System.Drawing.Point(263, 88);
            this.btnPosOrdem.Name = "btnPosOrdem";
            this.btnPosOrdem.Size = new System.Drawing.Size(82, 35);
            this.btnPosOrdem.TabIndex = 24;
            this.btnPosOrdem.Text = "Pós ordem";
            this.btnPosOrdem.UseVisualStyleBackColor = true;
            this.btnPosOrdem.Click += new System.EventHandler(this.BtnPosOrdem_Click);
            // 
            // btnPreOrdem
            // 
            this.btnPreOrdem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreOrdem.Location = new System.Drawing.Point(182, 88);
            this.btnPreOrdem.Name = "btnPreOrdem";
            this.btnPreOrdem.Size = new System.Drawing.Size(80, 35);
            this.btnPreOrdem.TabIndex = 23;
            this.btnPreOrdem.Text = "Pré ordem";
            this.btnPreOrdem.UseVisualStyleBackColor = true;
            this.btnPreOrdem.Click += new System.EventHandler(this.BtnPreOrdem_Click);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Location = new System.Drawing.Point(101, 88);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(80, 35);
            this.btnProcurar.TabIndex = 22;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.BtnProcurar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(508, 88);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(80, 35);
            this.btnRemover.TabIndex = 21;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            // 
            // lblstats
            // 
            this.lblstats.AutoSize = true;
            this.lblstats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstats.Location = new System.Drawing.Point(181, 58);
            this.lblstats.Name = "lblstats";
            this.lblstats.Size = new System.Drawing.Size(12, 16);
            this.lblstats.TabIndex = 20;
            this.lblstats.Text = "-";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(20, 129);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(568, 304);
            this.richTextBox1.TabIndex = 19;
            this.richTextBox1.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(207, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 29);
            this.textBox1.TabIndex = 18;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(20, 88);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(80, 35);
            this.btnInserir.TabIndex = 17;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 450);
            this.Controls.Add(this.btnLargura);
            this.Controls.Add(this.btnEmOrdem);
            this.Controls.Add(this.btnPosOrdem);
            this.Controls.Add(this.btnPreOrdem);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.lblstats);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnInserir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arvore AVL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLargura;
        private System.Windows.Forms.Button btnEmOrdem;
        private System.Windows.Forms.Button btnPosOrdem;
        private System.Windows.Forms.Button btnPreOrdem;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label lblstats;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnInserir;
    }
}

