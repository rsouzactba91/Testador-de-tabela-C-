namespace Testador_de_tabela_C_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            testar = new Button();
            GerenciaTabelas = new Button();
            TxtTabelaSelecionada = new TextBox();
            tabela_label = new Label();
            Calcular = new Button();
            Label2 = new Label();
            Label1 = new Label();
            saida = new MaskedTextBox();
            entrada = new MaskedTextBox();
            SuspendLayout();
            // 
            // testar
            // 
            testar.Location = new Point(316, 72);
            testar.Name = "testar";
            testar.Size = new Size(115, 43);
            testar.TabIndex = 17;
            testar.Text = "Testar registro";
            testar.UseVisualStyleBackColor = true;
            testar.Click += testar_Click;
            // 
            // GerenciaTabelas
            // 
            GerenciaTabelas.Location = new Point(316, 9);
            GerenciaTabelas.Margin = new Padding(3, 2, 3, 2);
            GerenciaTabelas.Name = "GerenciaTabelas";
            GerenciaTabelas.Size = new Size(115, 44);
            GerenciaTabelas.TabIndex = 16;
            GerenciaTabelas.Text = "Gerenciar";
            GerenciaTabelas.UseVisualStyleBackColor = true;
            GerenciaTabelas.Click += GerenciaTabelas_Click;
            // 
            // TxtTabelaSelecionada
            // 
            TxtTabelaSelecionada.BorderStyle = BorderStyle.FixedSingle;
            TxtTabelaSelecionada.Font = new Font("Segoe UI", 12F);
            TxtTabelaSelecionada.Location = new Point(211, 33);
            TxtTabelaSelecionada.Name = "TxtTabelaSelecionada";
            TxtTabelaSelecionada.Size = new Size(45, 29);
            TxtTabelaSelecionada.TabIndex = 15;
            TxtTabelaSelecionada.TextAlign = HorizontalAlignment.Center;
            // 
            // tabela_label
            // 
            tabela_label.AutoSize = true;
            tabela_label.Location = new Point(183, 15);
            tabela_label.Name = "tabela_label";
            tabela_label.Size = new Size(104, 15);
            tabela_label.TabIndex = 14;
            tabela_label.Text = "tabela selecionada";
            // 
            // Calcular
            // 
            Calcular.Location = new Point(183, 204);
            Calcular.Name = "Calcular";
            Calcular.Size = new Size(178, 63);
            Calcular.TabIndex = 13;
            Calcular.Text = "Calcular";
            Calcular.UseVisualStyleBackColor = true;
            Calcular.Click += Calcular_Click;
            // 
            // Label2
            // 
            Label2.BorderStyle = BorderStyle.FixedSingle;
            Label2.Location = new Point(13, 72);
            Label2.Name = "Label2";
            Label2.Size = new Size(107, 23);
            Label2.TabIndex = 12;
            Label2.Text = "Horário de saída";
            Label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.BorderStyle = BorderStyle.FixedSingle;
            Label1.FlatStyle = FlatStyle.System;
            Label1.Location = new Point(12, 9);
            Label1.Name = "Label1";
            Label1.Size = new Size(108, 17);
            Label1.TabIndex = 11;
            Label1.Text = "Horário de entrada";
            Label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // saida
            // 
            saida.BorderStyle = BorderStyle.FixedSingle;
            saida.Location = new Point(13, 98);
            saida.Mask = "00/00/0000 90:00";
            saida.Name = "saida";
            saida.Size = new Size(107, 23);
            saida.TabIndex = 10;
            saida.ValidatingType = typeof(DateTime);
            // 
            // entrada
            // 
            entrada.BorderStyle = BorderStyle.FixedSingle;
            entrada.Location = new Point(13, 29);
            entrada.Mask = "00/00/0000 90:00";
            entrada.Name = "entrada";
            entrada.Size = new Size(107, 23);
            entrada.TabIndex = 9;
            entrada.ValidatingType = typeof(DateTime);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 283);
            Controls.Add(testar);
            Controls.Add(GerenciaTabelas);
            Controls.Add(TxtTabelaSelecionada);
            Controls.Add(tabela_label);
            Controls.Add(Calcular);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(saida);
            Controls.Add(entrada);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal Button testar;
        internal Button GerenciaTabelas;
        internal TextBox TxtTabelaSelecionada;
        internal Label tabela_label;
        internal Button Calcular;
        internal Label Label2;
        internal Label Label1;
        internal MaskedTextBox saida;
        internal MaskedTextBox entrada;
    }
}
