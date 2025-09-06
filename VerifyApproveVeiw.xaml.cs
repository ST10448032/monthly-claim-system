
using System.Windows;
using System.Windows.Controls;

namespace Monthly_Claims_System
{
    public partial class VerifyApprovePage : Page
    {
        public VerifyApprovePage()
        {
            InitializeComponent();
        }

        private void Verify_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim has been verified successfully!", "Verification",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Approve_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim has been approved!", "Approval",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Reject_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim has been rejected!", "Rejection",
                MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
