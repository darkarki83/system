using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spetial_sait
{
    public partial class ServerForm : Form
    {
        public List<UsersList> UsersLists { get; set; }
        private TcpListener listner;

        public ServerForm()
        {
            InitializeComponent();
            UsersLists = new List<UsersList>();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                // Создаем экземпляр класса TcpListener.
                // Хост и порт вводит пользователь.
                listner = new TcpListener(
                    IPAddress.Parse(textBoxIp.Text.Trim()),
                    Convert.ToInt32(textBoxPort.Text.Trim()));
                // Начинаем прослушивание клиентов
                listner.Start();

                // Создаем отдельный поток для чтения сообщения и запускаем его
                var thread = new Thread(new ThreadStart(ClientThreadProc));
                thread.IsBackground = true;
                thread.Start();
            }
            catch (SocketException sockEx)
            {
                MessageBox.Show("Ошибка сокета: " + sockEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void ClientThreadProc()
        {
            while (true)
            {
                // Сообщаем клиенту о готовности к соединению
                TcpClient client = listner.AcceptTcpClient();
                // Читаем данные из сети в формате Unicode
                var stream = new StreamReader(client.GetStream(), Encoding.Unicode);
                

                string s = stream.ReadLine();

                string name = string.Empty;
                string massage = string.Empty;
                bool inName = false;
                foreach (var item in s)
                {
                    if (item == ':' && inName == false)
                    {
                        inName = true;
                    }
                    else if(item != ':' && inName == false)
                    {
                        name += item;
                    }
                    else if (item != ':' && inName == true)
                    {
                        massage += item;
                    }
                }
                inName = false;
                name = name.Trim();
                massage = massage.Trim();
                foreach (var user in UsersLists)
                {
                    if(user.Name == name)
                    {
                        user.Masseges.Add(massage);
                        inName = true;
                    }
                }
                if(inName == false)
                {
                    var user = new UsersList();
                    user.Name = name;
                    user.Masseges.Add(massage);
                    UsersLists.Add(user);
                }
                // Добавляем полученное сообщение в список
                listBoxHapen.Items.Add(s);
                client.Close();
                // При получении сообщения EXIT завершаем работу приложения
                if (s.ToUpper() == "EXIT")
                {
                    listner.Stop();
                    Close();
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (listner != null)
                listner.Stop();
        }
    }
    public class UsersList
    {
        public string Name { get; set; }
        public List<string> Masseges { get; set; }
        public UsersList()
        {
            Masseges = new List<string>();
        }
    }
}
