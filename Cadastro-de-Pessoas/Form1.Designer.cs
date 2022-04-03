namespace Cadastro_de_Pessoas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.mtCPF = new System.Windows.Forms.MaskedTextBox();
            this.mtData = new System.Windows.Forms.MaskedTextBox();
            this.tbCidade = new System.Windows.Forms.TextBox();
            this.cbUF = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgDadosPessoas = new System.Windows.Forms.DataGridView();
            this.cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_NASCIMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDadosPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cidade de Nascimento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "UF:";
            // 
            // tbNome
            // 
            this.tbNome.Enabled = false;
            this.tbNome.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNome.Location = new System.Drawing.Point(76, 78);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(496, 26);
            this.tbNome.TabIndex = 5;
            // 
            // mtCPF
            // 
            this.mtCPF.Enabled = false;
            this.mtCPF.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtCPF.Location = new System.Drawing.Point(76, 118);
            this.mtCPF.Mask = "000.000.000-00";
            this.mtCPF.Name = "mtCPF";
            this.mtCPF.Size = new System.Drawing.Size(154, 26);
            this.mtCPF.TabIndex = 6;
            // 
            // mtData
            // 
            this.mtData.Enabled = false;
            this.mtData.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtData.Location = new System.Drawing.Point(464, 118);
            this.mtData.Mask = "00/00/0000";
            this.mtData.Name = "mtData";
            this.mtData.Size = new System.Drawing.Size(108, 26);
            this.mtData.TabIndex = 7;
            this.mtData.ValidatingType = typeof(System.DateTime);
            // 
            // tbCidade
            // 
            this.tbCidade.Enabled = false;
            this.tbCidade.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCidade.Location = new System.Drawing.Point(236, 161);
            this.tbCidade.Name = "tbCidade";
            this.tbCidade.Size = new System.Drawing.Size(240, 26);
            this.tbCidade.TabIndex = 8;
            // 
            // cbUF
            // 
            this.cbUF.Enabled = false;
            this.cbUF.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUF.FormattingEnabled = true;
            this.cbUF.IntegralHeight = false;
            this.cbUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbUF.Location = new System.Drawing.Point(526, 161);
            this.cbUF.Name = "cbUF";
            this.cbUF.Size = new System.Drawing.Size(46, 26);
            this.cbUF.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(414, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cadastro único de pessoas";
            // 
            // dgDadosPessoas
            // 
            this.dgDadosPessoas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDadosPessoas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgDadosPessoas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgDadosPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDadosPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cpf,
            this.nome,
            this.DT_NASCIMENTO});
            this.dgDadosPessoas.Location = new System.Drawing.Point(15, 233);
            this.dgDadosPessoas.Name = "dgDadosPessoas";
            this.dgDadosPessoas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgDadosPessoas.Size = new System.Drawing.Size(557, 205);
            this.dgDadosPessoas.TabIndex = 12;
            // 
            // cpf
            // 
            this.cpf.HeaderText = "CPF";
            this.cpf.Name = "cpf";
            // 
            // nome
            // 
            this.nome.HeaderText = "NOME";
            this.nome.Name = "nome";
            // 
            // DT_NASCIMENTO
            // 
            this.DT_NASCIMENTO.HeaderText = "Dt_Nascimento";
            this.DT_NASCIMENTO.Name = "DT_NASCIMENTO";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(15, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 28);
            this.button1.TabIndex = 13;
            this.button1.Text = "Incluir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(158, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 28);
            this.button2.TabIndex = 14;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(303, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 28);
            this.button3.TabIndex = 15;
            this.button3.Text = "Excluir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgDadosPessoas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbUF);
            this.Controls.Add(this.tbCidade);
            this.Controls.Add(this.mtData);
            this.Controls.Add(this.mtCPF);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Pessoas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDadosPessoas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.MaskedTextBox mtCPF;
        private System.Windows.Forms.MaskedTextBox mtData;
        private System.Windows.Forms.TextBox tbCidade;
        private System.Windows.Forms.ComboBox cbUF;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgDadosPessoas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_NASCIMENTO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

