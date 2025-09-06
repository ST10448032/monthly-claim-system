using System.Windows;
using System.Windows.Controls;

namespace Monthly_Claims_System
{
    public partial class MainWindow : Page
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new LecturerSubmitPage());
        }

        private void UploadDocuments_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new UploadDocumentsPage()); // ✅ now a Page
        }

        private void TrackStatus_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new TrackStatusPage()); // ✅ now a Page
        }

        private void VerifyClaims_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new VerifyApprovePage()); // ✅ now a Page
        }
    }
}

