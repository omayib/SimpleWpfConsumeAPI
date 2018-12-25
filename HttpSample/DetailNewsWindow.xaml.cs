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
using System.Windows.Shapes;

namespace HttpSample
{
    /// <summary>
    /// Interaction logic for DetailNewsWindow.xaml
    /// </summary>
    public partial class DetailNewsWindow : Window
    {
        private string newsId;
        public DetailNewsWindow(string newsId)
        {
            InitializeComponent();
            this.newsId = newsId;
            getDetailNews(this.newsId);
        }

        private async Task getDetailNews(string id)
        {
            Article article = await ApiController.getPostDetailAsync(id);
            titleText.Content = article.Title;
            bodyText.Text = article.Body;
        }

        public DetailNewsWindow()
        {
            InitializeComponent();
        }
    }
}
