using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ListboxDemo.ViewModels
{
    public interface IViewModel
    {
        Window MyWidnow { get; set; }
        void OnLoaded(object sender, EventArgs e);
        void OnCLosed(object sender, EventArgs e);
    }
}
