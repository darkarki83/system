using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simafor.Common
{
    public interface IPresenter<T> where T : IView
    {
        T View { get; set; }
    }
}
