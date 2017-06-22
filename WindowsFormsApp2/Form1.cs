using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Ahorcado : Form
    {
        AhorcadoWS.ECCI_AhorcadoPortClient ahorcadows;
        public Ahorcado()
        {
            InitializeComponent();
            //se crea la conexión con el servidor
            ahorcadows = new AhorcadoWS.ECCI_AhorcadoPortClient();
            this.dgBest.Columns.Add("0", "Posición");
            this.dgBest.Columns.Add("1","Nombre");
            this.dgBest.Columns.Add("2", "Tiempos");
            for (int i = 0; i < 10; i++)
            {
                this.dgBest.Rows.Add();
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.tbJugador.Text=="")
            {
                MessageBox.Show("digite nombre del jugador");
            }
            else
            {
                //this.tbJugador.Enabled = false;
                String palabra = ahorcadows.obtenerPalabra(tbJugador.Text);
                String intentos = ahorcadows.ganador();
                this.tbIntentos.Text = intentos;
                this.tbAhorcado.Text = palabra;
                this.lblGanador.Text = "";
                this.btnFinish.Enabled = true;
                //this.btnRefresh.Enabled = true;
                this.btnEnviar.Enabled = true;
                this.tbDigite.Enabled = true;
                this.btnStart.Enabled = false;
            }

        }


        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.btnFinish.Enabled = false;
            //this.btnRefresh.Enabled = false;
            this.btnEnviar.Enabled = false;
            this.tbDigite.Enabled = false;
            this.btnStart.Enabled = true;
            tbAhorcado.Text = "";
            tbIntentos.Text = "";
            tbDigite.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            String texto = ahorcadows.obtenerDiez();
            StringReader strReader = new StringReader(texto);
            int fila = 0;
            while (true)
            {
                String aLine = strReader.ReadLine();
                if (aLine != null)
                {
                    string[] words = aLine.Split(',');
                    this.dgBest.Rows[fila].Cells[0].Value = fila+1;
                    this.dgBest.Rows[fila].Cells[1].Value = words[0];
                    this.dgBest.Rows[fila].Cells[2].Value = words[1];
                    fila++;
                }
                else
                {
                    break;
                }
            }
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            String text=ahorcadows.intento(this.tbDigite.Text);
            this.tbDigite.Text = "";
            this.tbAhorcado.Text = text;
            String win = ahorcadows.ganador();

            if (win == "-1")
            {
                this.lblGanador.Text = "Has ganado";
                this.btnFinish.PerformClick();
            }
            else if(win == "0")
            {
                this.lblGanador.Text = "Has perdido";
                this.btnFinish.PerformClick();
            }
            else
            {
                this.tbIntentos.Text = win;

            }
        }

    }
}
