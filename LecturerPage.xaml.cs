using System.Windows;
using System.Windows.Controls;

namespace Monthly_Claims_System
{
    public partial class LecturerSubmitPage : Page
    {
        public LecturerSubmitPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string moduleCode = ModuleCodeTextBox.Text;
            string hoursWorkedText = HoursWorkedTextBox.Text;
            string rateText = RateTextBox.Text;

            if (string.IsNullOrWhiteSpace(moduleCode) ||
                string.IsNullOrWhiteSpace(hoursWorkedText) ||
                string.IsNullOrWhiteSpace(rateText))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!double.TryParse(hoursWorkedText, out double hoursWorked) ||
                !double.TryParse(rateText, out double rate))
            {
                MessageBox.Show("Enter valid numbers for Hours Worked and Rate.");
                return;
            }

            double total = hoursWorked * rate;
            MessageBox.Show($"Claim Submitted!\nModule: {moduleCode}\nHours: {hoursWorked}\nRate: {rate:C}\nTotal: {total:C}");
        }
    }
}
