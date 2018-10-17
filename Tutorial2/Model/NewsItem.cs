using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial2.Model
{
    public class NewsItem
    {
        public int id { get; set; }
        public string Category { get; set; }
        public string Headline { get; set; }
        public string Subhead { get; set; }
        public string Dateline { get; set; }
        public string Image { get; set; }
    }
    public class NewsManager
    {
        public static void GetNews(string category, ObservableCollection<NewsItem> newsItems)
        {
            var allItems = getNewsItems();
            var filteredNewsItems = allItems.Where(p => p.Category == category).ToList();
            newsItems.Clear();
            filteredNewsItems.ForEach(p => newsItems.Add(p));
        }

        public static List<NewsItem> getNewsItems()
        {
            var items = new List<NewsItem>();
            items.Add(new NewsItem() { id = 1, Category = "Financial", Headline = "Lorem Ipsum", Subhead = "doro sit amet", Dateline = "Nunc tristique nec", Image = "Assets/images2/Financial.png" });
            items.Add(new NewsItem() { id = 2, Category = "Financial 2", Headline = "Lorem Ipsum 2", Subhead = "doro sit amet 2", Dateline = "Nunc tristique nec 2", Image = "Assets/images2/Financial3.png" });
            items.Add(new NewsItem() { id = 3, Category = "Financial 3", Headline = "Lorem Ipsum 3", Subhead = "doro sit amet 3", Dateline = "Nunc tristique nec 3", Image = "Assets/images2/Financial4.png" });
            items.Add(new NewsItem() { id = 4, Category = "Financial 4", Headline = "Lorem Ipsum 4", Subhead = "doro sit amet 4", Dateline = "Nunc tristique nec 4", Image = "Assets/images2/Financial5.png" });
            items.Add(new NewsItem() { id = 5, Category = "Financial 5", Headline = "Lorem Ipsum 5", Subhead = "doro sit amet 5", Dateline = "Nunc tristique nec 5", Image = "Assets/images2/Food.png" });
            items.Add(new NewsItem() { id = 6, Category = "Financial 6", Headline = "Lorem Ipsum 6", Subhead = "doro sit amet 6", Dateline = "Nunc tristique nec 6", Image = "Assets/images2/Food1.png" });
            items.Add(new NewsItem() { id = 7, Category = "Financial 7", Headline = "Lorem Ipsum 7", Subhead = "doro sit amet 7", Dateline = "Nunc tristique nec 7", Image = "Assets/images2/Food2.png" });
            items.Add(new NewsItem() { id = 8, Category = "Financial 8", Headline = "Lorem Ipsum 8", Subhead = "doro sit amet 8", Dateline = "Nunc tristique nec 8", Image = "Assets/images2/Food3.png" });
            items.Add(new NewsItem() { id = 9, Category = "Financial 9", Headline = "Lorem Ipsum 9", Subhead = "doro sit amet 9", Dateline = "Nunc tristique nec 9", Image = "Assets/images2/Food4.png" });
            items.Add(new NewsItem() { id = 10, Category = "Financial 10", Headline = "Lorem Ipsum 10", Subhead = "doro sit amet 10", Dateline = "Nunc tristique nec 10", Image = "Assets/images2/Food5.png" });
            return items;
        }

    }
}
