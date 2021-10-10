namespace WpfTitleBarPractice
{
    using System.Windows;
    using WpfTitleBarPractice.Views;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// [標準クロームのウィンドウ]ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StandardChromeWindowButton_Click(object sender, RoutedEventArgs e)
        {
            var subWindow = new StandardChromeWindowView();
            subWindow.Show();
        }

        /// <summary>
        /// [クローム無しウィンドウ]ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoChromeWindowButton_Click(object sender, RoutedEventArgs e)
        {
            var subWindow = new NoChromeWindowView();
            subWindow.Show();
        }

        /// <summary>
        /// [リサイズ無しウィンドウ]ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoResizeWindowButton_Click_1(object sender, RoutedEventArgs e)
        {
            var subWindow = new NoResizeWindowView();
            subWindow.Show();
        }

        /// <summary>
        /// [カスタム クローム ウィンドウ（ステップ１）]ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomChromeStep1Button_Click(object sender, RoutedEventArgs e)
        {
            var subWindow = new CustomChromeStep1WindowView();
            subWindow.Show();
        }

        /// <summary>
        /// [カスタム クローム ウィンドウ（ステップ２）]ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomChromeStep2Button_Click(object sender, RoutedEventArgs e)
        {
            var subWindow = new CustomChromeStep2WindowView();
            subWindow.Show();
        }

        /// <summary>
        /// [カスタム クローム ウィンドウ（ステップ３）]ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomChromeStep3Button_Click(object sender, RoutedEventArgs e)
        {
            var subWindow = new CustomChromeStep3WindowView();
            subWindow.Show();
        }

        private void CustomeChromeWindowButton_Click(object sender, RoutedEventArgs e)
        {
            var subWindow = new CustomChromeWindowView();
            subWindow.Show();
        }
    }
}
