using FlowAlgorithms.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace FlowAlgorithms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ObservableCollection<MyToolbarItems> myToolbarItems { get; set; } = new ObservableCollection<MyToolbarItems>()
        {
            new MyToolbarItems("New File",0,null,"Icons/NewFile.png"),
            new MyToolbarItems("Open File",1,null,"Icons/OpenFile.png"),
            new MyToolbarItems("Save File",2,null,"Icons/SaveFile.png"),
            new MyToolbarItems("Save As",3,null,"Icons/SaveFileAs.png"),
            new MyToolbarItems("Open From Server",4,null,"Icons/OpenFileFromServer.png"),
            new MyToolbarItems("Save On Server",5,null,"Icons/SaveFileOnServer.png"),
            new MyToolbarItems("Login",6,null,"Icons/Login.png"),
            new MyToolbarItems("Settings",7,null,"Icons/Settings.png"),
        };
        public MainWindow()
        {
            InitializeComponent();
        }
    }


}
