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

namespace MultiplexTrack.View
{
    /// <summary>
    /// Interaction logic for UserRegisterView.xaml
    /// </summary>
    public partial class UserRegisterView : Page
    {
        private Frame _frame;
        public UserRegisterView()
        {
            InitializeComponent();
        }

        public UserRegisterView(Frame frame)
        {
            InitializeComponent();
            this._frame = frame;
        }
    }
}
