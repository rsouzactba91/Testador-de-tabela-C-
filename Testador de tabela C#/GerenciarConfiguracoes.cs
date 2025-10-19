using System;

namespace Testador_de_tabela_C_
{
    internal static class GerenciarConfiguracoes
    {
        // Tabela 1
        public static decimal Tab1_Tolerancia
        {
            get => Properties.Settings.Default.Tab1_Tolerancia;
            set { Properties.Settings.Default.Tab1_Tolerancia = value; Properties.Settings.Default.Save(); }
        }

        public static decimal Tab1_Minutos30
        {
            get => Properties.Settings.Default.Tab1_Minutos30;
            set { Properties.Settings.Default.Tab1_Minutos30 = value; Properties.Settings.Default.Save(); }
        }

        public static decimal Tab1_UmaHora
        {
            get => Properties.Settings.Default.Tab1_UmaHora;
            set { Properties.Settings.Default.Tab1_UmaHora = value; Properties.Settings.Default.Save(); }
        }

        public static decimal Tab1_Fracao
        {
            get => Properties.Settings.Default.Tab1_Fracao;
            set { Properties.Settings.Default.Tab1_Fracao = value; Properties.Settings.Default.Save(); }
        }

        // Tabela 2
        public static decimal Tab2_Tolerancia
        {
            get => Properties.Settings.Default.Tab2_Tolerancia;
            set { Properties.Settings.Default.Tab2_Tolerancia = value; Properties.Settings.Default.Save(); }
        }

        public static decimal Tab2_Minutos30
        {
            get => Properties.Settings.Default.Tab2_Minutos30;
            set { Properties.Settings.Default.Tab2_Minutos30 = value; Properties.Settings.Default.Save(); }
        }

        public static decimal Tab2_UmaHora
        {
            get => Properties.Settings.Default.Tab2_UmaHora;
            set { Properties.Settings.Default.Tab2_UmaHora = value; Properties.Settings.Default.Save(); }
        }

        public static decimal Tab2_Fracao
        {
            get => Properties.Settings.Default.Tab2_Fracao;
            set { Properties.Settings.Default.Tab2_Fracao = value; Properties.Settings.Default.Save(); }
        }

        // Última tabela usada
        public static int UltimaTabela
        {
            get => Properties.Settings.Default.UltimaTabela;
            set { Properties.Settings.Default.UltimaTabela = value; Properties.Settings.Default.Save(); }
        }
    }
}
