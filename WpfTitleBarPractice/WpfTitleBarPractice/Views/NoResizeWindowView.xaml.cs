namespace WpfTitleBarPractice.Views
{
    using System.Windows;

    /// <summary>
    /// NoResizeWindowView.xaml の相互作用ロジック
    /// </summary>
    public partial class NoResizeWindowView : Window
    {
        public NoResizeWindowView()
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
