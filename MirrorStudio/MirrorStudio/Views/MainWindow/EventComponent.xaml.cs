using MirrorStudio.Enums;
using MirrorStudio.Models;
using MirrorStudio.Models.Events;
using MirrorStudio.Templates;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace MirrorStudio.Views.MainWindow
{
    public partial class EventComponent : UserControl
    {
        private ObservableCollection<EventModel>? eventModels;


        public EventComponent()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            eventModels = EventModelTemplate.EventModels;

            EventListBox.ItemsSource = eventModels;
        }

        private void EventListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
