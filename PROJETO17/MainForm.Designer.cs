/*
 * Created by SharpDevelop.
 * User: Usuário
 * Date: 17/06/2026
 * Time: 11:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PROJETO17
{
	partial class frmCadastro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtnome;
		private System.Windows.Forms.TextBox txtemail;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnadd;
		private System.Windows.Forms.Button btnsalvar;
		private System.Windows.Forms.Button btnalterar;
		private System.Windows.Forms.Button btnexcluir;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnconsultartodos;
		private System.Windows.Forms.Button btnpesquisar;
		private System.Windows.Forms.TextBox txtpesquisar;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.MaskedTextBox mskfone;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
			this.label1 = new System.Windows.Forms.Label();
			this.txtnome = new System.Windows.Forms.TextBox();
			this.txtemail = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnadd = new System.Windows.Forms.Button();
			this.btnsalvar = new System.Windows.Forms.Button();
			this.btnalterar = new System.Windows.Forms.Button();
			this.btnexcluir = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.btnconsultartodos = new System.Windows.Forms.Button();
			this.btnpesquisar = new System.Windows.Forms.Button();
			this.txtpesquisar = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.mskfone = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(23, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome";
			// 
			// txtnome
			// 
			this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtnome.Location = new System.Drawing.Point(23, 52);
			this.txtnome.MaxLength = 50;
			this.txtnome.Name = "txtnome";
			this.txtnome.Size = new System.Drawing.Size(379, 20);
			this.txtnome.TabIndex = 2;
			// 
			// txtemail
			// 
			this.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.txtemail.Location = new System.Drawing.Point(22, 131);
			this.txtemail.MaxLength = 150;
			this.txtemail.Name = "txtemail";
			this.txtemail.Size = new System.Drawing.Size(379, 20);
			this.txtemail.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Email";
			// 
			// btnadd
			// 
			this.btnadd.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnadd.Location = new System.Drawing.Point(22, 169);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(114, 38);
			this.btnadd.TabIndex = 5;
			this.btnadd.Text = "Adicionar";
			this.btnadd.UseVisualStyleBackColor = false;
			// 
			// btnsalvar
			// 
			this.btnsalvar.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnsalvar.Location = new System.Drawing.Point(196, 169);
			this.btnsalvar.Name = "btnsalvar";
			this.btnsalvar.Size = new System.Drawing.Size(115, 38);
			this.btnsalvar.TabIndex = 6;
			this.btnsalvar.Text = "Salvar";
			this.btnsalvar.UseVisualStyleBackColor = false;
			// 
			// btnalterar
			// 
			this.btnalterar.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnalterar.Location = new System.Drawing.Point(367, 169);
			this.btnalterar.Name = "btnalterar";
			this.btnalterar.Size = new System.Drawing.Size(128, 38);
			this.btnalterar.TabIndex = 7;
			this.btnalterar.Text = "Alterar";
			this.btnalterar.UseVisualStyleBackColor = false;
			// 
			// btnexcluir
			// 
			this.btnexcluir.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnexcluir.Location = new System.Drawing.Point(532, 169);
			this.btnexcluir.Name = "btnexcluir";
			this.btnexcluir.Size = new System.Drawing.Size(122, 38);
			this.btnexcluir.TabIndex = 8;
			this.btnexcluir.Text = "Excluir";
			this.btnexcluir.UseVisualStyleBackColor = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(23, 213);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(472, 129);
			this.dataGridView1.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(28, 367);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(156, 23);
			this.label3.TabIndex = 10;
			this.label3.Text = "Digite nome para consulta:";
			// 
			// btnconsultartodos
			// 
			this.btnconsultartodos.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnconsultartodos.Location = new System.Drawing.Point(515, 311);
			this.btnconsultartodos.Name = "btnconsultartodos";
			this.btnconsultartodos.Size = new System.Drawing.Size(139, 34);
			this.btnconsultartodos.TabIndex = 11;
			this.btnconsultartodos.Text = "Consulta Todos";
			this.btnconsultartodos.UseVisualStyleBackColor = false;
			// 
			// btnpesquisar
			// 
			this.btnpesquisar.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnpesquisar.Location = new System.Drawing.Point(515, 350);
			this.btnpesquisar.Name = "btnpesquisar";
			this.btnpesquisar.Size = new System.Drawing.Size(139, 34);
			this.btnpesquisar.TabIndex = 12;
			this.btnpesquisar.Text = "Pesquisar";
			this.btnpesquisar.UseVisualStyleBackColor = false;
			// 
			// txtpesquisar
			// 
			this.txtpesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtpesquisar.Location = new System.Drawing.Point(168, 364);
			this.txtpesquisar.MaxLength = 50;
			this.txtpesquisar.Name = "txtpesquisar";
			this.txtpesquisar.Size = new System.Drawing.Size(327, 20);
			this.txtpesquisar.TabIndex = 13;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(487, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(167, 92);
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// label4
			// 
			this.label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(487, 116);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(150, 23);
			this.label4.TabIndex = 15;
			this.label4.Text = "Telefone";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// mskfone
			// 
			this.mskfone.Location = new System.Drawing.Point(487, 131);
			this.mskfone.Mask = "(99)9999-9999";
			this.mskfone.Name = "mskfone";
			this.mskfone.Size = new System.Drawing.Size(167, 20);
			this.mskfone.TabIndex = 17;
			// 
			// frmCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(666, 403);
			this.Controls.Add(this.mskfone);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.txtpesquisar);
			this.Controls.Add(this.btnpesquisar);
			this.Controls.Add(this.btnconsultartodos);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnexcluir);
			this.Controls.Add(this.btnalterar);
			this.Controls.Add(this.btnsalvar);
			this.Controls.Add(this.btnadd);
			this.Controls.Add(this.txtemail);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtnome);
			this.Controls.Add(this.label1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "frmCadastro";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Cadastro de Pessoas";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
