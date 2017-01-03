using ListboxDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ListboxDemo.ViewModels
{
    public class TestViewModel : IViewModel
    {
        public Window MyWidnow { get; set; }

        public void OnCLosed(object sender, EventArgs e)
        {
           // Do something
        }

        public void OnLoaded(object sender, EventArgs e)
        {
            // Release memory
            var context = new MyDbContext();
            var studentData = context.Set<Student>().ToList();
            var teacherData = context.Set<Teacher>().ToList();
        }
    }
}
