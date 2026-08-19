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
		private System.Windows.Forms.MaskedTextBox txtfone;
		
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
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
			this.txtfone = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(29, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 35);
			this.label1.TabIndex = 0;
			this.label1.Text = "Nome:\r\n";
			// 
			// txtnome
			// 
			this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtnome.Location = new System.Drawing.Point(38, 138);
			this.txtnome.MaxLength = 50;
			this.txtnome.Name = "txtnome";
			this.txtnome.Size = new System.Drawing.Size(389, 23);
			this.txtnome.TabIndex = 2;
			this.txtnome.TextChanged += new System.EventHandler(this.txtnome_TextChanged);
			// 
			// txtemail
			// 
			this.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.txtemail.Location = new System.Drawing.Point(38, 290);
			this.txtemail.MaxLength = 150;
			this.txtemail.Name = "txtemail";
			this.txtemail.Size = new System.Drawing.Size(389, 23);
			this.txtemail.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(29, 211);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 47);
			this.label2.TabIndex = 3;
			this.label2.Text = "Email:\r\n\r\n";
			// 
			// btnadd
			// 
			this.btnadd.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnadd.Location = new System.Drawing.Point(38, 347);
			this.btnadd.Name = "btnadd";
			this.btnadd.Size = new System.Drawing.Size(217, 73);
			this.btnadd.TabIndex = 5;
			this.btnadd.Text = "Adicionar";
			this.btnadd.UseVisualStyleBackColor = false;
			this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
			// 
			// btnsalvar
			// 
			this.btnsalvar.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnsalvar.Location = new System.Drawing.Point(279, 347);
			this.btnsalvar.Name = "btnsalvar";
			this.btnsalvar.Size = new System.Drawing.Size(255, 66);
			this.btnsalvar.TabIndex = 6;
			this.btnsalvar.Text = "Salvar";
			this.btnsalvar.UseVisualStyleBackColor = false;
			this.btnsalvar.Click += new System.EventHandler(this.btnsalvar_Click);
			// 
			// btnalterar
			// 
			this.btnalterar.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnalterar.Location = new System.Drawing.Point(580, 347);
			this.btnalterar.Name = "btnalterar";
			this.btnalterar.Size = new System.Drawing.Size(264, 66);
			this.btnalterar.TabIndex = 7;
			this.btnalterar.Text = "Alterar";
			this.btnalterar.UseVisualStyleBackColor = false;
			this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
			// 
			// btnexcluir
			// 
			this.btnexcluir.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnexcluir.Location = new System.Drawing.Point(904, 347);
			this.btnexcluir.Name = "btnexcluir";
			this.btnexcluir.Size = new System.Drawing.Size(278, 66);
			this.btnexcluir.TabIndex = 8;
			this.btnexcluir.Text = "Excluir";
			this.btnexcluir.UseVisualStyleBackColor = false;
			this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(38, 439);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1144, 294);
			this.dataGridView1.TabIndex = 9;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label3
			// 
			this.label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(70, 772);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(316, 44);
			this.label3.TabIndex = 10;
			this.label3.Text = "Digite nome para consulta:";
			// 
			// btnconsultartodos
			// 
			this.btnconsultartodos.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnconsultartodos.Location = new System.Drawing.Point(1221, 571);
			this.btnconsultartodos.Name = "btnconsultartodos";
			this.btnconsultartodos.Size = new System.Drawing.Size(452, 120);
			this.btnconsultartodos.TabIndex = 11;
			this.btnconsultartodos.Text = "Consulta Todos";
			this.btnconsultartodos.UseVisualStyleBackColor = false;
			this.btnconsultartodos.Click += new System.EventHandler(this.btnconsultartodos_Click);
			// 
			// btnpesquisar
			// 
			this.btnpesquisar.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.btnpesquisar.Location = new System.Drawing.Point(1221, 697);
			this.btnpesquisar.Name = "btnpesquisar";
			this.btnpesquisar.Size = new System.Drawing.Size(452, 119);
			this.btnpesquisar.TabIndex = 12;
			this.btnpesquisar.Text = "Pesquisar";
			this.btnpesquisar.UseVisualStyleBackColor = false;
			// 
			// txtpesquisar
			// 
			this.txtpesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtpesquisar.Location = new System.Drawing.Point(392, 778);
			this.txtpesquisar.MaxLength = 50;
			this.txtpesquisar.Name = "txtpesquisar";
			this.txtpesquisar.Size = new System.Drawing.Size(790, 23);
			this.txtpesquisar.TabIndex = 13;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(1201, 38);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(472, 275);
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// label4
			// 
			this.label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(1201, 358);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 25);
			this.label4.TabIndex = 15;
			this.label4.Text = "Telefone";
			// 
			// txtfone
			// 
			this.txtfone.Location = new System.Drawing.Point(1384, 360);
			this.txtfone.Mask = "(99)9999-9999";
			this.txtfone.Name = "txtfone";
			this.txtfone.Size = new System.Drawing.Size(289, 23);
			this.txtfone.TabIndex = 17;
			// 
			// frmCadastro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.ClientSize = new System.Drawing.Size(1713, 1033);
			this.Controls.Add(this.txtfone);
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
