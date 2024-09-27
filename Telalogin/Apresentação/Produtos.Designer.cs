namespace Telalogin.Apresentação
{
    partial class Produtos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produtos));
            this.btnInformacoes = new System.Windows.Forms.Button();
            this.btnIncluirProduto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.cbSelecioneProduto = new System.Windows.Forms.ComboBox();
            this.lblSelecioneProduto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInformacoes
            // 
            this.btnInformacoes.Location = new System.Drawing.Point(171, 102);
            this.btnInformacoes.Name = "btnInformacoes";
            this.btnInformacoes.Size = new System.Drawing.Size(147, 60);
            this.btnInformacoes.TabIndex = 2;
            this.btnInformacoes.Text = "Visualizar informações";
            this.btnInformacoes.UseVisualStyleBackColor = true;
            this.btnInformacoes.Click += new System.EventHandler(this.btnInformacoes_Click);
            // 
            // btnIncluirProduto
            // 
            this.btnIncluirProduto.Location = new System.Drawing.Point(171, 197);
            this.btnIncluirProduto.Name = "btnIncluirProduto";
            this.btnIncluirProduto.Size = new System.Drawing.Size(147, 60);
            this.btnIncluirProduto.TabIndex = 3;
            this.btnIncluirProduto.Text = "Incluir produto ";
            this.btnIncluirProduto.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(121, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(171, 293);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(147, 60);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbSelecioneProduto
            // 
            this.cbSelecioneProduto.FormattingEnabled = true;
            this.cbSelecioneProduto.Location = new System.Drawing.Point(171, 45);
            this.cbSelecioneProduto.Name = "cbSelecioneProduto";
            this.cbSelecioneProduto.Size = new System.Drawing.Size(147, 21);
            this.cbSelecioneProduto.TabIndex = 8;
            // 
            // lblSelecioneProduto
            // 
            this.lblSelecioneProduto.AutoSize = true;
            this.lblSelecioneProduto.Location = new System.Drawing.Point(193, 29);
            this.lblSelecioneProduto.Name = "lblSelecioneProduto";
            this.lblSelecioneProduto.Size = new System.Drawing.Size(105, 13);
            this.lblSelecioneProduto.TabIndex = 9;
            this.lblSelecioneProduto.Text = "Selecione o produto:";
            // 
            // Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lblSelecioneProduto);
            this.Controls.Add(this.cbSelecioneProduto);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnIncluirProduto);
            this.Controls.Add(this.btnInformacoes);
            this.Name = "Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInformacoes;
        private System.Windows.Forms.Button btnIncluirProduto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.ComboBox cbSelecioneProduto;
        private System.Windows.Forms.Label lblSelecioneProduto;
    }
}