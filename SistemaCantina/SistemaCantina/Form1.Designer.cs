namespace SistemaCantina
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.listCaixa = new System.Windows.Forms.ListBox();
            this.lblTitulo3 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.picImagem = new System.Windows.Forms.PictureBox();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.lblTitulo4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(91, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(185, 22);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SISTEMA CANTINA";
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.BackColor = System.Drawing.Color.Transparent;
            this.lblProduto.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.Location = new System.Drawing.Point(27, 96);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(152, 20);
            this.lblProduto.TabIndex = 1;
            this.lblProduto.Text = "CÓDIGO DO PRODUTO:";
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(31, 119);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(150, 20);
            this.textCodigo.TabIndex = 2;
            this.textCodigo.TextChanged += new System.EventHandler(this.textCodigo_TextChanged);
            // 
            // listCaixa
            // 
            this.listCaixa.FormattingEnabled = true;
            this.listCaixa.Location = new System.Drawing.Point(198, 96);
            this.listCaixa.Name = "listCaixa";
            this.listCaixa.Size = new System.Drawing.Size(151, 173);
            this.listCaixa.TabIndex = 4;
            // 
            // lblTitulo3
            // 
            this.lblTitulo3.AutoSize = true;
            this.lblTitulo3.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo3.Location = new System.Drawing.Point(124, 305);
            this.lblTitulo3.Name = "lblTitulo3";
            this.lblTitulo3.Size = new System.Drawing.Size(0, 17);
            this.lblTitulo3.TabIndex = 5;
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Transparent;
            this.BtnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(263, 315);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(86, 29);
            this.BtnSair.TabIndex = 6;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = false;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // picImagem
            // 
            this.picImagem.Location = new System.Drawing.Point(31, 145);
            this.picImagem.Name = "picImagem";
            this.picImagem.Size = new System.Drawing.Size(150, 124);
            this.picImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImagem.TabIndex = 7;
            this.picImagem.TabStop = false;
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.Location = new System.Drawing.Point(263, 275);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(86, 27);
            this.BtnLimpar.TabIndex = 8;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // lblTitulo4
            // 
            this.lblTitulo4.AutoSize = true;
            this.lblTitulo4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo4.Location = new System.Drawing.Point(8, 305);
            this.lblTitulo4.Name = "lblTitulo4";
            this.lblTitulo4.Size = new System.Drawing.Size(110, 17);
            this.lblTitulo4.TabIndex = 9;
            this.lblTitulo4.Text = "VALOR TOTAL:";
            this.lblTitulo4.Click += new System.EventHandler(this.lblTitulo4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(377, 356);
            this.ControlBox = false;
            this.Controls.Add(this.lblTitulo4);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.picImagem);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.lblTitulo3);
            this.Controls.Add(this.listCaixa);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Cantina";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.ListBox listCaixa;
        private System.Windows.Forms.Label lblTitulo3;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.PictureBox picImagem;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Label lblTitulo4;
    }
}

