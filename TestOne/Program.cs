using System;
using System.Collections.Generic;

namespace TestOne
{
    public class Program
    {
        //public List<UsersList> UsersLists { get; set; }

        public Program()
        {
            //UsersLists = new List<UsersList>();
        }
        static void Main(string[] args)
        {

            var UsersLists = new List<UsersList>();
            //Console.WriteLine("Hello World!");
            string s = "art:dffgg fddfdf dffdfdfergfre   dfgerger  errfg";

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



            foreach(var item in UsersLists)
            {
                Console.WriteLine(item.Name);
                foreach(var lines in item.Masseges)
                {
                    Console.WriteLine(lines);
                }
            }
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
