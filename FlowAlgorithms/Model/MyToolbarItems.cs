using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FlowAlgorithms.Model
{
    //public class MyToolbarItems:Button
    //{
    //    public MyToolbarItems(string tooltipText, string path)
    //    {
    //        ToolTip = tooltipText;
    //        Background = new ImageBrush() { ImageSource = new BitmapImage(new Uri(path, UriKind.Relative)), Stretch=Stretch.Uniform};
    //    }        
    //}
    public class MyToolbarItems

    {

        public String Name { get; private set; }

        public Int32 ActionId { get; private set; }

        public ICommand Command { get; private set; }

        public BitmapImage Image { get; private set; }

        public MyToolbarItems(String name, Int32 id, ICommand command, string path)

        {
            
            Name = name;

            ActionId = id;

            Command = command;

            Image = new BitmapImage(new Uri(path,UriKind.Relative));

        }

    }

}

