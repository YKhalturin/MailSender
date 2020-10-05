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

namespace WpfTestMailSender.Views
{
    /// <summary>
    /// Interaction logic for RecipientEditor.xaml
    /// </summary>
    public partial class RecipientEditor : UserControl
    {
        public RecipientEditor()
        {
            InitializeComponent();
        }

        private void OnValidationError(object sender, ValidationErrorEventArgs e)
        {
            var control = (Control) e.OriginalSource;
            if (e.Action == ValidationErrorEventAction.Added)
            {
                control.ToolTip = e.Error.ErrorContent.ToString();

            }
            else
            {
                control.ClearValue(ToolTipProperty);
            }
        }
    }
}
