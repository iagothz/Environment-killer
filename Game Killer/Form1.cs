using System.Diagnostics;
using Timer = System.Windows.Forms.Timer;

namespace Game_Killer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        byte status = 0;
        private Timer timer1;
        private void Form1_Load(object sender, EventArgs e)
        {
            string sts = "Status: Inativo";
            lbl_status.Text = sts;
            lbl_info1.Text = "";
            lbl_info2.Text = "";
            lbl_info3.Text = "";
        }
        private void cbox_ativo_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbox_ativo.Checked)
            {
                lbl_status.Text = "Status: Ativo";
                status = 1;
                initTimer();
            }
            else
            {
                lbl_status.Text = "Status: Inativo";
                status = 0;
                stopTimer();
                lbl_info1.Text = "";
                lbl_info2.Text = "";
                lbl_info3.Text = "";
            }
        }
        public void initTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Verificacao();
        }
        public void stopTimer()
        {
            timer1.Stop();
        }
        public void Verificacao()
        {
            //Codigo que o ChatGPT simplificou

            //Cria uma variavel lista com as 3 checkbox, o nome dos processos, os labels a serem escritos e a mensagem a colocar na label
            var verificacoes = new List<(CheckBox checkBox, string[] processos, Label label, string mensagem)>
            {
                (check_jogos, new string[] { "XboxPcApp", "Battle.net", "EADesktop", "EAConnect_microsoft", "GalaxyClient", "steam", "upc" }, lbl_info1, "Bloqueando execução de apps de jogos como Xbox,\n Battle.net, EA, GOG, Steam e Ubisoft."),
                (check_video, new string[] { "Netflix", "PrimeVideo", "DisneyPlus"}, lbl_info2, "Bloqueando execução de apps de víde como Netflix,\n Prime Video e Disney+."),
                (check_musica, new string[] { "spotify", "deezer"}, lbl_info3, "Bloqueando execução de apps de música como Spotify\n e Deezer.")
            };

            // Para cada verificação que ele fizer na variavel lista
            foreach (var verificacao in verificacoes)
            {
                //Se a checkbox verificada na primeira posição da lista da variável estiver marcada
                if (verificacao.checkBox.Checked)
                {
                    //Para cada processo descrito na lista de nome de processos criada na segunda posição da lista da variável
                    foreach (var processo in verificacao.processos)
                    {
                        //Para cada processo descrito na lista, pega o nome do processo
                        foreach (var process in Process.GetProcessesByName(processo))
                        {
                            //Encerra o processo
                            process.Kill();
                        }
                    }
                    //aasdhasdcasasd
                    verificacao.label.Text = verificacao.mensagem;
                }
            }
            /* -Codigo que eu fiz
            if (check_jogos.Checked)
            {
                List<string> games = new List<string>
                {
                    "XboxPcApp", "Battle.net", "EADesktop", "EAConnect_microsoft", "GalaxyClient", "steam", "upc"
                };
                for (int i = 0; i < games.Count; i++)
                {
                    foreach (var process in Process.GetProcessesByName(games[i]))
                    {
                        process.Kill();
                    }
                }
                lbl_info1.Text = "Bloqueando execução de apps de jogos como Xbox,\n Battle.net, EA, GOG, Steam e Ubisoft.";
            }
            if (check_video.Checked)
            {
                //Netflix 
                foreach (var process in Process.GetProcessesByName("Netflix"))
                {
                    process.Kill();
                }
                lbl_info2.Text = "Bloqueando execução de apps de víde como Netflix,\n Prime Video e Disney+.";
            }
            if (check_musica.Checked)
            {
                //Spotify 
                foreach (var process in Process.GetProcessesByName("Spotify"))
                {
                    process.Kill();
                }
                lbl_info3.Text = "Bloqueando execução de apps de música como Spotify\n e Deezer.";
            }*/
        }
        private void check_musica_CheckedChanged(object sender, EventArgs e)
        {
            if (!check_musica.Checked)
            {
                lbl_info3.Text = "";
            }
        }
        private void check_video_CheckedChanged(object sender, EventArgs e)
        {
            if (!check_video.Checked)
            {
                lbl_info2.Text = "";
            }
        }
        private void check_jogos_CheckedChanged(object sender, EventArgs e)
        {
            if (!check_jogos.Checked)
            {
                lbl_info1.Text = "";
            }
        }
        private void cbox_horario_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbox_horario.Checked)
            {
                cbox_horario.Text = "Ativado por horário";
            }
            else
            {
                cbox_horario.Text = "Ativar por horário";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
