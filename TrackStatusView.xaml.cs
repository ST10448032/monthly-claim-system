using System.Windows;
using System.Windows.Controls;

namespace Monthly_Claims_System
{
    public partial class TrackStatusPage : Page
    {
        public TrackStatusPage()
        {
            InitializeComponent();
        }

        private void CheckStatus_Click(object sender, RoutedEventArgs e)
        {
            string claimId = ClaimIdTextBox.Text.Trim();

            if (string.IsNullOrEmpty(claimId))
            {
                MessageBox.Show("Please enter a Claim ID.", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Dummy example – replace with database/service lookup
            if (claimId == "123")
                StatusResultTextBlock.Text = "Status: Approved";
            else if (claimId == "456")
                StatusResultTextBlock.Text = "Status: Pending";
            else
                StatusResultTextBlock.Text = "Status: Not Found";
        }
    }
}
