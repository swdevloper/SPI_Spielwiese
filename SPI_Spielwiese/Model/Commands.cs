using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SPI_Spielwiese.Model
{
    public class Commands
    {



    }



    public static class CustomCommands
    {
        public static readonly RoutedUICommand Info = new RoutedUICommand
        (
            "Info",
            "Info",
            typeof(CustomCommands),
            new InputGestureCollection()
            {
                new KeyGesture(Key.I,ModifierKeys.Control)
            }
        );


    }

}
