namespace Testador_de_tabela_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configura os MaskedTextBox
            entrada.Mask = "00/00/0000 00:00";
            saida.Mask = "00/00/0000 00:00";

            // Carrega a última tabela usando SettingManager
            int ultima = GerenciarConfiguracoes.UltimaTabela;
            TxtTabelaSelecionada.Text = (ultima > 0) ? ultima.ToString() : "1";

            // Define a hora atual nos MaskedTextBox
            DateTime now = DateTime.Now;
            entrada.Text = now.AddHours(-1).ToString("dd/MM/yyyy HH:mm");
            saida.Text = now.ToString("dd/MM/yyyy HH:mm");
        }
        private decimal CalcularValorTabela1(int totalHoras, int totalMinutos)
        {
            decimal valor = 0;

            // Obtém valores das configurações ou usa padrão
            decimal valorAte30Min = GerenciarConfiguracoes.Tab1_Minutos30 > 0 ? GerenciarConfiguracoes.Tab1_Minutos30 : 13m;
            decimal valorAte3Horas = GerenciarConfiguracoes.Tab1_UmaHora > 0 ? GerenciarConfiguracoes.Tab1_UmaHora : 19m;
            decimal valorExtra = GerenciarConfiguracoes.Tab1_Fracao > 0 ? GerenciarConfiguracoes.Tab1_Fracao : 2.5m;

            if (totalHoras == 0 && totalMinutos <= 15)
            {
                valor = 0;
            }
            else if (totalHoras == 0 && totalMinutos > 15 && totalMinutos <= 30)
            {
                valor = valorAte30Min;
            }
            else if (totalHoras < 3)
            {
                valor = valorAte3Horas;
            }
            else if (totalHoras >= 3)
            {
                valor = valorAte3Horas;

                int minutosExtras = (totalHoras * 60 + totalMinutos) - (3 * 60);
                if (minutosExtras > 0)
                {
                    int blocosDe15Min = (int)Math.Ceiling(minutosExtras / 15.0);
                    valor += blocosDe15Min * valorExtra;
                }
            }

            return valor;
        }

        private decimal CalcularValorTabela2(int totalHoras, int totalMinutos)
        {
            decimal valor = 0;

            decimal valorAte30Min = GerenciarConfiguracoes.Tab2_Minutos30 > 0 ? GerenciarConfiguracoes.Tab2_Minutos30 : 15m;
            decimal valorAte3Horas = GerenciarConfiguracoes.Tab2_UmaHora > 0 ? GerenciarConfiguracoes.Tab2_UmaHora : 22m;
            decimal valorExtra = GerenciarConfiguracoes.Tab2_Fracao > 0 ? GerenciarConfiguracoes.Tab2_Fracao : 3m;

            if (totalHoras == 0 && totalMinutos <= 15)
            {
                valor = 0;
            }
            else if (totalHoras == 0 && totalMinutos > 15 && totalMinutos <= 30)
            {
                valor = valorAte30Min;
            }
            else if (totalHoras < 3)
            {
                valor = valorAte3Horas;
            }
            else if (totalHoras >= 3)
            {
                valor = valorAte3Horas;

                int minutosExtras = (totalHoras - 3) * 60 + totalMinutos;
                if (minutosExtras > 0)
                {
                    int blocosDe15Min = (int)Math.Ceiling(minutosExtras / 15.0);
                    valor += blocosDe15Min * valorExtra;
                }
            }

            return valor;
        }



        private void Calcular_Click(object sender, EventArgs e)
        {
            string entradaTexto = entrada.Text;
            string saidaTexto = saida.Text;
            int tabelaSelecionada;

            if (!int.TryParse(TxtTabelaSelecionada.Text, out tabelaSelecionada))
            {
                MessageBox.Show("Por favor, selecione uma tabela válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Salva a última tabela
            GerenciarConfiguracoes.UltimaTabela = tabelaSelecionada;


            // Converte para DateTime
            if (DateTime.TryParseExact(entradaTexto, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime entradaHora) &&
                DateTime.TryParseExact(saidaTexto, "dd/MM/yyyy HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime saidaHora))
            {
                if (saidaHora < entradaHora)
                    saidaHora = saidaHora.AddDays(1);

                TimeSpan diferenca = saidaHora - entradaHora;
                int totalHoras = (int)Math.Floor(diferenca.TotalMinutes / 60);
                int minutosRestantes = (int)(diferenca.TotalMinutes % 60);

                decimal valorCobrado = 0;

                switch (tabelaSelecionada)
                {
                    case 1:
                        valorCobrado = CalcularValorTabela1(totalHoras, minutosRestantes);
                        break;
                    case 2:
                        valorCobrado = CalcularValorTabela2(totalHoras, minutosRestantes);
                        break;
                    default:
                        MessageBox.Show("Tabela não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                DateTime saidaate;
                if (totalHoras == 3 && minutosRestantes == 0)
                    saidaate = saidaHora;
                else if (totalHoras < 3)
                    saidaate = entradaHora.AddHours(3);
                else
                    saidaate = saidaHora.AddMinutes(15);

                TimeSpan temporestante = saidaate - saidaHora;
                if (totalHoras == 3 && minutosRestantes == 0)
                    temporestante = TimeSpan.Zero;

                MessageBox.Show(
                    "Tabela selecionada: " + tabelaSelecionada + Environment.NewLine +
                    "Tempo total: " + totalHoras + " horas e " + minutosRestantes + " minutos" + Environment.NewLine +
                    "Valor a pagar: R$ " + valorCobrado.ToString("N2") + Environment.NewLine +
                    "Saída até: " + saidaate.ToString("dd/MM/yyyy HH:mm") + Environment.NewLine +
                    "Tempo restante: " + temporestante.Hours + " horas e " + temporestante.Minutes + " minutos",
                    "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Por favor, insira horários válidos no formato dd/MM/yyyy HH:mm.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GerenciaTabelas_Click(object sender, EventArgs e)
        {
            int tabela = int.Parse(TxtTabelaSelecionada.Text);
            Form2 formGerenciar = new Form2(tabela);

            // Abre como janela modal
            formGerenciar.Show();
        }

        private void testar_Click(object sender, EventArgs e)
        {
            Form3 formTestar = new Form3();
            formTestar.Show();
        }
    }
}
