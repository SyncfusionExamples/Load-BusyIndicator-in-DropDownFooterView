using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoadBusyIndicator
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<string> CountryList { get; set; }
        public MainPage()
        {
            InitializeComponent();
        }

        //Set the collection to Combobox DataSource
        private void LoadItems()
        {
            CountryList = new ObservableCollection<string>();
            if (comboBox.DataSource == null)
            {
                CountryList.Add("India");
                CountryList.Add("Uganda");
                CountryList.Add("Ukraine");
                CountryList.Add("Canada");
                CountryList.Add("United Arab Emirates");
                CountryList.Add("France");
                CountryList.Add("United Kingdom");
                CountryList.Add("China");
                CountryList.Add("United States");
                CountryList.Add("Japan");
                CountryList.Add("Angola");
                CountryList.Add("Africa");
                CountryList.Add("Brazil");
                CountryList.Add("France");
                CountryList.Add("Canada");
                CountryList.Add("Nepal");
                CountryList.Add("Sweden");
                CountryList.Add("Singapore");
                comboBox.DataSource = CountryList;
            }
        }

        
        private async void DataChanged()
        {
            await Task.Delay(4000);
            busyindicator.IsBusy = false; //To hide the busy indicator 
            comboBox.DropDownFooterViewHeight = 0;
            if (comboBox.DataSource == null)
            {
                LoadItems();
            }
        }

        //Value changed event to display the suggestions based on user input
        private void comboBox_ValueChanged(object sender, Syncfusion.XForms.ComboBox.ValueChangedEventArgs e)
        {
            DataChanged();

        }
    }
}
