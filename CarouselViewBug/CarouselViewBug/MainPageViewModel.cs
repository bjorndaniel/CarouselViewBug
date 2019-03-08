using System.Collections.ObjectModel;
using System.Linq;

namespace CarouselViewBug
{
    public class MainPageViewModel
    {
        public ObservableCollection<User> Users { get; set; }
        public MainPageViewModel()
        {
            Users = new ObservableCollection<User>(Enumerable.Range(1, 10).Select(_ =>
                 new User
                 {
                     Id = _,
                     Name = $"User_{_}"
                 }
             ));
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
