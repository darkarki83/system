using Microsoft.Win32;
using System;
using System.Collections.Generic;

namespace SystemHW2
{
    class Program
    {
       // public string KeyName = @"Software\Artem Krol\MyApp\RecentOpenedFiles";
        static void SaveList(List<string> list)
        {
            try
            {
                using(RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Artem Krol\MyFiles"))
                {
                    int count = 1;
                    foreach (var item in list)
                        key.SetValue($"str{count++}", item);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static List<string> InputList()
        {
            var list = new List<string>();
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Artem Krol\MyFiles"))
                {
                    foreach (var item in key.GetValueNames())
                        list.Add(key.GetValue(item).ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return list;
        }

        static void Main(string[] args)
        {
            SaveList(new List<string>()
        {
            @"C:\Docs\Report1.docx",
            @"C:\Docs\Report2.docx",
            @"C:\Docs\Report3.docx",
            @"C:\Docs\Report4.docx",
            @"C:\Docs\Report5.docx",
            @"C:\Docs\Report56.docx",
            @"C:\Docs\Report54.docx",
            @"C:\Docs\Report53.docx",
            @"C:\Docs\Report52.docx",
            @"C:\Docs\Report51.docx",
            @"C:\Docs\Report9.docx"
        });

            List<string> list = InputList();
            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}
