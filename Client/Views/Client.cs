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
    public partial class ClientForm : Form , IClientView
    {
        private TcpClient client;
        private IPEndPoint endPoint;
        public ClientForm()
        {
            InitializeComponent();
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем экземпляр класса IPEndPoint
                var endPoint = new IPEndPoint(
                    IPAddress.Parse("127.0.0.1"),
                    Convert.ToInt32("80"));
                client = new TcpClient();
                // Устанавливаем соединение с использованием данных IP и номера порта
                client.Connect(endPoint);
                // Получаем сетевой поток
                NetworkStream nstream = client.GetStream();
                // Преобразуем строки сообщения в массив байт
                byte[] message = Encoding.Unicode.GetBytes(textBoxName.Text.Trim() + ":" + textBoxMassage.Text.Trim());
                // Записываем весь массив в сетевой поток
                nstream.Write(message, 0, message.Length);
                // Закрываем клиентский сокет
                client.Close();
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
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (client != null)
                client.Close();
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {

        }

       
    }
}
