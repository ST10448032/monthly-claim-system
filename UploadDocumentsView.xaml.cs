using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Monthly_Claims_System
{
    public partial class UploadDocumentsPage : Page
    {
        private string selectedFilePath;

        public UploadDocumentsPage()
        {
            InitializeComponent();
        }

        private void ChooseFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "Select a Document",
                Filter = "All Files (*.*)|*.*|PDF Files (*.pdf)|*.pdf|Word Documents (*.docx)|*.docx|Images (*.jpg;*.png)|*.jpg;*.png"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                selectedFilePath = openFileDialog.FileName;
                SelectedFilePathTextBlock.Text = $"File Selected: {selectedFilePath}";
            }
        }

        private void Upload_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(selectedFilePath) || !File.Exists(selectedFilePath))
            {
                MessageBox.Show("Please choose a file before uploading.", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            string fileName = Path.GetFileName(selectedFilePath);
            MessageBox.Show($"File '{fileName}' uploaded successfully!", "Upload Complete",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
