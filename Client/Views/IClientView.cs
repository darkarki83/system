using Client.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Views
{
    public interface IClientView : IView
    {
        event EventHandler GetConectInfo;

        string Names { get; set; }
        string Ip { get; set; }
        string Port { get; set; }
    }
}
