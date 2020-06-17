using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DomainModel
{
    public class ClientModel : IClientModel
    {
        public string Names { get; set; }
        public string Ip { get; set; }
        public string Port { get; set; }
        public ClientModel(string names, string ip, string port)
        {
            Names = names;
            Ip = ip;
            Port = port;
        }
    }
}
