using Microsoft.Win32;
using System;
using System.Diagnostics;

namespace SystemHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Artem Krol"))
                {
                    if (key != null)
                    {
                        object o = key.GetValue("Title");
                        Console.WriteLine(o.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run"))
                {
                    key.SetValue("Artem Krol Super Prog", $"{ Process.GetCurrentProcess().MainModule.FileName}");
                
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Artem Krol"))
                {
                    key.SetValue("Title", $"{DateTime.Now:dd.MM.yyyy HH:mm:ss}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
