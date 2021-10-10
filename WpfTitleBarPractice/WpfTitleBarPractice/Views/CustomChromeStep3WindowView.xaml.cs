namespace WpfTitleBarPractice.Views
{
    using System.Windows;

    /// <summary>
    /// CustomChromeStep3WindowView.xaml の相互作用ロジック
    /// </summary>
    public partial class CustomChromeStep3WindowView : Window
    {
        public CustomChromeStep3WindowView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// [閉じる]ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
