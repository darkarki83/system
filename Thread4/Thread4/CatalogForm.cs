using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Thread4
{
    public partial class CatalogForm : Form
    {
        private string PathA { get; set; }
        private double catalogSize = 0;
        public CatalogForm(string path)
        {
            InitializeComponent();
            try
            {
                PathA = path;
            }
            catch(Exception ex)
            {
                PathA = "D:\\";
            }
        }

        private void CatalogForm_Load_1(object sender, EventArgs e)
        {
            var t = new Thread(new ThreadStart(ThreadProc1));
            t.Start();
        }
        private void CatalogForm_Enter_1(object sender, EventArgs e)
        {
            var t = new Thread(new ThreadStart(ThreadProc1));
            t.Start();
        }
        private void ThreadProc1()
        {
            while (true)
            {
                if (!Path.HasExtension(PathA))
                {
                    string[] l;
                    try
                    {
                        l = Directory.GetDirectories(PathA);
                    }
                    catch (Exception ex)
                    {
                        PathA = "D:\\";
                        l = Directory.GetDirectories(PathA);
                    }
                    SetTextFolderSafe(l.Length.ToString());
                }

                if (!Path.HasExtension(PathA))
                {
                    string[] File = Directory.GetFiles(PathA);
                    SetTextFilesSafe(File.Length.ToString());
                }

                if (!Path.HasExtension(PathA))
                {
                    catalogSize = sizeOfFolder(PathA, ref catalogSize); //Вызываем наш рекурсивный метод
                    if (catalogSize != 0)
                    {
                        SetTextSizeSafe(catalogSize.ToString());
                    }
                    else
                    {
                        SetTextSizeSafe("0");
                    }
                }
                Thread.Sleep(2000);
            }
        }

        static double sizeOfFolder(string folder, ref double catalogSize)
        {
            try
            {
                //В переменную catalogSize будем записывать размеры всех файлов, с каждым
                //новым файлом перезаписывая данную переменную
                DirectoryInfo di = new DirectoryInfo(folder);
                DirectoryInfo[] diA = di.GetDirectories();
                FileInfo[] fi = di.GetFiles();
                //В цикле пробегаемся по всем файлам директории di и складываем их размеры
                foreach (FileInfo f in fi)
                {
                    //Записываем размер файла в байтах
                    catalogSize = catalogSize + f.Length;
                }
                //В цикле пробегаемся по всем вложенным директориям директории di 
                foreach (DirectoryInfo df in diA)
                {
                    //рекурсивно вызываем наш метод
                    sizeOfFolder(df.FullName, ref catalogSize);
                }
                //1ГБ = 1024 Байта * 1024 КБайта * 1024 МБайта
                return Math.Round((double)(catalogSize / 1024 / 1024 / 1024), 1);
            }
            //Начинаем перехватывать ошибки
            //DirectoryNotFoundException - директория не найдена
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Директория не найдена. Ошибка: " + ex.Message);
                return 0;
            }
            //UnauthorizedAccessException - отсутствует доступ к файлу или папке
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine("Отсутствует доступ. Ошибка: " + ex.Message);
                return 0;
            }
            //Во всех остальных случаях
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка. Обратитесь к администратору. Ошибка: " + ex.Message);
                return 0;
            }
        }

        private void SetTextFolderSafe(string text)
        {
            if (InvokeRequired)
                BeginInvoke(new Action<string>(s => { SetTextFolder(s); }), text);
            else
                SetTextFolder(text);
        }

        private void SetTextFilesSafe(string text)
        {
            if (InvokeRequired)
                BeginInvoke(new Action<string>(s => { SetTextFiles(s); }), text);
            else
                SetTextFiles(text);
        }

        private void SetTextSizeSafe(string text)
        {
            if (InvokeRequired)
                BeginInvoke(new Action<string>(s => { SetTextSize(s); }), text);
            else
                SetTextSize(text);
        }

        private void SetTextFolder(string text)
        {
            textFolder.Text = text;
        }
        private void SetTextFiles(string text)
        {
            textFiles.Text = text;
        }
        private void SetTextSize(string text)
        {
            textSize.Text = text;
        }
    }
}
