using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListboxDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var data = new List<Person>();
            data.Add(new Person() { Name = "Person 1", Designation = "Developer", Id =1 });
            data.Add(new Person() { Name = "Person 2", Designation = "Manager", Id = 2 });
            data.Add(new Person() { Name = "Person 3", Designation = "Teacher", Id = 3 });
            data.Add(new Person() { Name = "Person 4", Designation = "Developer", Id = 4 });
            data.Add(new Person() { Name = "Person 5", Designation = "Manager", Id = 5 });
            data.Add(new Person() { Name = "Person 6", Designation = "Teacher", Id = 6 });
            data.Add(new Person() { Name = "Person 7", Designation = "Developer", Id = 7 });
            data.Add(new Person() { Name = "Person 8", Designation = "Manager", Id = 8 });
            data.Add(new Person() { Name = "Person 9", Designation = "Teacher", Id = 9 });
            data.Add(new Person() { Name = "Person 10", Designation = "Developer", Id = 10 });
            data.Add(new Person() { Name = "Person 11", Designation = "Manager", Id = 11 });

            myListbox.ItemsSource = data;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Designation { get; set; }
    }


}
