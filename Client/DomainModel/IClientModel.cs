using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.DomainModel
{
    public interface IClientModel
    {
        string Names { get; set; }
        string Ip { get; set; }
        string Port { get; set; }
    }
}
