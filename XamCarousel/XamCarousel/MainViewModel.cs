using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamCarousel
{
    public class MainViewModel:BaseViewModel
    {
        public MainViewModel()
        {
            Options = new ObservableCollection<OptionValue>();
        }

        public ICommand LabelTapCommand => new Command<int>((id) =>
        {
            Console.WriteLine($"Navigation to {id}");
            Position = id;
        });

        public void Init()
        {
            Options.Clear();
            Options.Add(new OptionValue(0,"a"));
            Options.Add(new OptionValue(1,"b"));
            Options.Add(new OptionValue(2,"c"));
            Options.Add(new OptionValue(3,"d"));
            Options.Add(new OptionValue(4,"e"));
        }

        private int position;

        public int Position
        {
            get => position;
            set
            {
                position = value;
                OnPropChanged();
            }
        }

        public ObservableCollection<OptionValue> Options { get; }
    }

    public class OptionValue
    {
        public OptionValue(int id, string title)
        {
            Id = id;
            Title = title;
        }
        public int Id { get; set; }
        public string Title { get; set; }
    }

}
