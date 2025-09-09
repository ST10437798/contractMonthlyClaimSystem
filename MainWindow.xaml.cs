using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace WpfClaimSystem
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim submitted successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void UploadDocuments_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Documents uploaded successfully!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void TrackClaimStatus_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim status is currently settled.", "Claim Status", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void VerifyClaims_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claims verified and ready for approval.", "Verification", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void ApproveClaims_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claims approved!", "Approval", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}