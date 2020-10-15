using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace CinemaWpfTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public ObservableCollection<Movie> MoviesList = new ObservableCollection<Movie>();
        public ObservableCollection<Order> OrdersList = new ObservableCollection<Order>();

        public MainWindow()
        {
            InitializeComponent();

            //using (DatabaseContainer db = new DatabaseContainer())
            //{
            //    Movie movie1 = new Movie { Name = "Терминатор"};
            //    Movie movie2 = new Movie { Name = "Гарри Поттер" };
            //    Movie movie3 = new Movie { Name = "Фиксики" };

            //    db.Movies.Add(movie1);
            //    db.Movies.Add(movie2);
            //    db.Movies.Add(movie3);
            //    db.SaveChanges();
            //}
        }

        private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
        {
            ReloadMoviesList();
            ReloadOrdersList();
        }

        private void ReloadMoviesList()
        {
            using (DatabaseContainer db = new DatabaseContainer())
            {
                MoviesList = new ObservableCollection<Movie>(db.Movies.ToList());
                MoviesDG.ItemsSource = MoviesList;
            }
        }

        private void ReloadOrdersList()
        {
            using (DatabaseContainer db = new DatabaseContainer())
            {
                OrdersList = new ObservableCollection<Order>(db.Orders.ToList());
                OrdersDG.ItemsSource = OrdersList;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (DatabaseContainer db = new DatabaseContainer())
            {
                Order order = new Order
                {
                    MovieId = ((Movie) MoviesDG.SelectedItem).Id,
                    Count = Convert.ToInt32(TicketsCount.Text)
                };
                db.Orders.Add(order);
                db.SaveChanges();
            }
            ReloadOrdersList();
        }
    }
}
