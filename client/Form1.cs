using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clienteTCPIP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(500, 300);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Ligar.Checked == true)
                {
                    TcpClient client = new TcpClient("127.0.0.1", 8080);

                    // Obter o stream de rede da conexão
                    NetworkStream stream = client.GetStream();

                    // Enviar dados para o servidor
                    string message = "1";
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                    client.Close();


                }
                else
                {
                    TcpClient client = new TcpClient("127.0.0.1", 8080);

                    // Obter o stream de rede da conexão
                    NetworkStream stream = client.GetStream();

                    // Enviar dados para o servidor
                    string message = "0";
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                    client.Close();
                }
            }
            catch(IOException error)
            {
                MessageBox.Show("Erro ao enviar comando: Erro " + error.ToString());
            }
        }
    }
}
