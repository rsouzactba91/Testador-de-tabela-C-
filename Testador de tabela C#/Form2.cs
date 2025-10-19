using System;
using System.Windows.Forms;

namespace Testador_de_tabela_C_
{
    public partial class Form2 : Form
    {
        private int tabelaSelecionada;

        // Construtor recebe a tabela selecionada
        public Form2(int tabela)
        {
            InitializeComponent();
            tabelaSelecionada = tabela;

            // Preenche os campos de acordo com a tabela selecionada
            if (tabelaSelecionada == 1)
            {
                txt30min.Text = GerenciarConfiguracoes.Tab1_Minutos30.ToString();
                txt1hora.Text = GerenciarConfiguracoes.Tab1_UmaHora.ToString();
                txtfracao.Text = GerenciarConfiguracoes.Tab1_Fracao.ToString();
                txtolerancia.Text = GerenciarConfiguracoes.Tab1_Tolerancia.ToString();
            }
            else if (tabelaSelecionada == 2)
            {
                txt30min.Text = GerenciarConfiguracoes.Tab2_Minutos30.ToString();
                txt1hora.Text = GerenciarConfiguracoes.Tab2_UmaHora.ToString();
                txtfracao.Text = GerenciarConfiguracoes.Tab2_Fracao.ToString();
                txtolerancia.Text = GerenciarConfiguracoes.Tab2_Tolerancia.ToString();
            }
        }

        // Botão Gravar: salva os valores no SettingManager
        private void btngravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tabelaSelecionada == 1)
                {
                    GerenciarConfiguracoes.Tab1_Minutos30 = decimal.Parse(txt30min.Text);
                    GerenciarConfiguracoes.Tab1_UmaHora = decimal.Parse(txt1hora.Text);
                    GerenciarConfiguracoes.Tab1_Fracao = decimal.Parse(txtfracao.Text);
                    GerenciarConfiguracoes.Tab1_Tolerancia = decimal.Parse(txtolerancia.Text);
                }
                else if (tabelaSelecionada == 2)
                {
                    GerenciarConfiguracoes.Tab2_Minutos30 = decimal.Parse(txt30min.Text);
                    GerenciarConfiguracoes.Tab2_UmaHora = decimal.Parse(txt1hora.Text);
                    GerenciarConfiguracoes.Tab2_Fracao = decimal.Parse(txtfracao.Text);
                    GerenciarConfiguracoes.Tab2_Tolerancia = decimal.Parse(txtolerancia.Text);
                }

                MessageBox.Show("Configurações salvas!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Fecha o Form2
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite valores válidos nos campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
