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
using System.Windows.Shapes;

namespace MultiplexTrack.Views
{
    /// <summary>
    /// Interaction logic for UserLoginView.xaml
    /// </summary>
    public partial class UserLoginView : Page
    {
        private Frame frame;
        public UserLoginView()
        {
            InitializeComponent();
        }

        public UserLoginView(Frame frame)
        {
            InitializeComponent();
            this.frame = frame;
        }
    }
}
