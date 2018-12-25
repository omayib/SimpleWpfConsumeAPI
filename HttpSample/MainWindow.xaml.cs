using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HttpSample
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            getTheData();
        }
        private void Button_Click_Article(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("aaaa");
            Article article = ((Button)sender).Tag as Article;
            Console.WriteLine("article : "+ article.Id);
            DetailNewsWindow detailWindow = new DetailNewsWindow(article.Id);
            detailWindow.Show();
        }
        private async Task getTheData()
        {
            List<Article> getArticles = await ApiController.GetPostAsync();
            icTodoList.ItemsSource = getArticles;
        }
    }
}
