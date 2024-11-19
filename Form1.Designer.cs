namespace ReqFerramentas
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerirColaboradores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGerirRequisições = new System.Windows.Forms.Button();
            this.btnGerirFerramentas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerirColaboradores
            // 
            this.btnGerirColaboradores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerirColaboradores.Location = new System.Drawing.Point(69, 158);
            this.btnGerirColaboradores.Name = "btnGerirColaboradores";
            this.btnGerirColaboradores.Size = new System.Drawing.Size(209, 85);
            this.btnGerirColaboradores.TabIndex = 0;
            this.btnGerirColaboradores.Text = "Gerir Colaboradores";
            this.btnGerirColaboradores.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // btnGerirRequisições
            // 
            this.btnGerirRequisições.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerirRequisições.Location = new System.Drawing.Point(284, 158);
            this.btnGerirRequisições.Name = "btnGerirRequisições";
            this.btnGerirRequisições.Size = new System.Drawing.Size(209, 85);
            this.btnGerirRequisições.TabIndex = 2;
            this.btnGerirRequisições.Text = "Gerir Requisições";
            this.btnGerirRequisições.UseVisualStyleBackColor = true;
            // 
            // btnGerirFerramentas
            // 
            this.btnGerirFerramentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerirFerramentas.Location = new System.Drawing.Point(499, 158);
            this.btnGerirFerramentas.Name = "btnGerirFerramentas";
            this.btnGerirFerramentas.Size = new System.Drawing.Size(209, 85);
            this.btnGerirFerramentas.TabIndex = 3;
            this.btnGerirFerramentas.Text = "Gerir Ferramentas";
            this.btnGerirFerramentas.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerirFerramentas);
            this.Controls.Add(this.btnGerirRequisições);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGerirColaboradores);
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerirColaboradores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGerirRequisições;
        private System.Windows.Forms.Button btnGerirFerramentas;
    }
}

