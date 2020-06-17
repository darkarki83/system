using Client.Presenters;
using Client.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class LogInForm : Form , ILogInView
    {
        public event EventHandler LogIn;
        public string Names { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }

        private TcpClient client;
        private IPEndPoint endPoint;

        public LogInForm()
        {
            InitializeComponent();
            buttonLogIn.Enabled = false;
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {

            Names = textBoxName.Text;
            Ip = textBoxIP.Text;
            Port = textBoxServer.Text;
            try
            {
                endPoint = new IPEndPoint(
                        IPAddress.Parse(Ip),
                        Convert.ToInt32(Port));
                client = new TcpClient();
                // Устанавливаем соединение с использованием данных IP и номера порта
                client.Connect(endPoint);

                client.Close();
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (SocketException sockEx)
            {
                MessageBox.Show("Ошибка сокета:" + sockEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка:" + ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            if (textBoxName.TextLength > 0 && textBoxIP.TextLength > 0 && textBoxServer.TextLength > 0)
                buttonLogIn.Enabled = true;
        }
    }
}
