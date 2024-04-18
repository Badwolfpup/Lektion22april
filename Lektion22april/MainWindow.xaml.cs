using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lektion22april
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyCollectionChanged, INotifyPropertyChanged
    {
        public ObservableCollection<Månad> AntalDagarIMånad { get; set; } 
        private string[] månadsnamn = { "Januari", "Februari", "Mars", "April", "Maj", "Juni", "Juli", "Augusti", "September", "Oktober", "November", "December" };

        private Månad _aktuellmånad;

        public Månad Aktuellmånad
        {
            get {  return _aktuellmånad;}
            set
            {
                if(_aktuellmånad != value)
                {
                    _aktuellmånad = value;
                    OnPropertyChanged(nameof(Aktuellmånad));
                }
            }
        }

        private int vilkenmånad = 0;


        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            AntalDagarIMånad = new ObservableCollection<Månad>();
            GenereraMånader();
            Aktuellmånad = AntalDagarIMånad[vilkenmånad];
        }

        public event NotifyCollectionChangedEventHandler? CollectionChanged;
        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void GenereraMånader()
        {
            for (int i = 0; i < 12; i++)
            {
                AntalDagarIMånad.Add(new Månad(månadsnamn[i]));
            }
        }

        private void TextBlock_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (vilkenmånad > 10) vilkenmånad = 0; 
            else vilkenmånad++;
                
            Aktuellmånad = AntalDagarIMånad[vilkenmånad];
        }

        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (vilkenmånad == 0) vilkenmånad = 11;
            else vilkenmånad--; ;
            Aktuellmånad = AntalDagarIMånad[vilkenmånad];

        }
    }


}