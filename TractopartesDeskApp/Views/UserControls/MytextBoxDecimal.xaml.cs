using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace TractopartesDeskApp.Views.UserControls
{
    public partial class MytextBoxDecimal : UserControl
    {
        public MytextBoxDecimal()
        {
            InitializeComponent();
            txttexto.Text= string.Empty;
        }
        public decimal Hint
        {
            get
            {
                return (decimal)GetValue(HintProperty);
            }
            set { SetValue(HintProperty, value); }

        }
        public static readonly DependencyProperty HintProperty =
            DependencyProperty.Register("Hint", typeof(decimal), typeof(MytextBoxDecimal));
        public class DecimalValidationRule : ValidationRule
        {
            public override ValidationResult Validate(object value, CultureInfo cultureInfo)
            {
                decimal result;
                bool isValid = decimal.TryParse(value as string, NumberStyles.Number, cultureInfo, out result);
                return new ValidationResult(isValid, "Please enter a valid decimal number.");
            }
        }
        public string Caption
        {
            get
            {
                return (string)GetValue(CaptionProperty);
            }
            set { SetValue(CaptionProperty, value); }

        }
        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register("Caption", typeof(string), typeof(MytextBoxDecimal));

        public static readonly DependencyProperty DbProperty =
           DependencyProperty.Register("ValueDb", typeof(decimal), typeof(MytextBoxDecimal));
        public decimal ValueDb
        {
            get
            {
                return (decimal)GetValue(DbProperty);
            }
            set { SetValue(DbProperty, value); }

        }

        private void texBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            Regex regex = new Regex(@"[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}

