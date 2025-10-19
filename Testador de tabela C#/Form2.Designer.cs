namespace Testador_de_tabela_C_
{
    partial class Form2
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtolerancia = new TextBox();
            txt30min = new TextBox();
            txt1hora = new TextBox();
            txtfracao = new TextBox();
            btngravar = new Button();
            txttabela = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 60);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Tolerância";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 92);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "30 Minutos";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 129);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 3;
            label3.Text = "1 Hora";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 168);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "Fração";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(157, 21);
            label5.TabIndex = 5;
            label5.Text = "Tabela Selecionada";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtolerancia
            // 
            txtolerancia.BorderStyle = BorderStyle.FixedSingle;
            txtolerancia.Location = new Point(136, 52);
            txtolerancia.Name = "txtolerancia";
            txtolerancia.Size = new Size(40, 23);
            txtolerancia.TabIndex = 6;
            // 
            // txt30min
            // 
            txt30min.BorderStyle = BorderStyle.FixedSingle;
            txt30min.Location = new Point(136, 84);
            txt30min.Name = "txt30min";
            txt30min.Size = new Size(40, 23);
            txt30min.TabIndex = 7;
            // 
            // txt1hora
            // 
            txt1hora.BorderStyle = BorderStyle.FixedSingle;
            txt1hora.Location = new Point(136, 121);
            txt1hora.Name = "txt1hora";
            txt1hora.Size = new Size(40, 23);
            txt1hora.TabIndex = 8;
            // 
            // txtfracao
            // 
            txtfracao.BorderStyle = BorderStyle.FixedSingle;
            txtfracao.Location = new Point(136, 160);
            txtfracao.Name = "txtfracao";
            txtfracao.Size = new Size(40, 23);
            txtfracao.TabIndex = 9;
            // 
            // btngravar
            // 
            btngravar.Location = new Point(75, 218);
            btngravar.Name = "btngravar";
            btngravar.Size = new Size(84, 36);
            btngravar.TabIndex = 11;
            btngravar.Text = "Gravar";
            btngravar.UseVisualStyleBackColor = true;
            btngravar.Click += btngravar_Click;
            // 
            // txttabela
            // 
            txttabela.BorderStyle = BorderStyle.None;
            txttabela.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txttabela.Location = new Point(175, 14);
            txttabela.Name = "txttabela";
            txttabela.Size = new Size(40, 26);
            txttabela.TabIndex = 12;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 275);
            Controls.Add(txttabela);
            Controls.Add(btngravar);
            Controls.Add(txtfracao);
            Controls.Add(txt1hora);
            Controls.Add(txt30min);
            Controls.Add(txtolerancia);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Show which tabela was passed in (partial class can access the private field)
            txttabela.Text = tabelaSelecionada.ToString();

            // Optionally ensure textboxes are pre-filled (constructor already does this,
            // so keep this only if you need runtime refresh)
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtolerancia;
        private TextBox txt30min;
        private TextBox txt1hora;
        private TextBox txtfracao;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btngravar;
        private TextBox txttabela;
    }
}