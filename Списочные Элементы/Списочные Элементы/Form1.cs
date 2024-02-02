using Microsoft.VisualBasic.Devices;
using System.Diagnostics.Metrics;

namespace Списочные_Элементы
{


    public partial class Form1 : Form
    {
        private List<Country> countries;
        public class Country
        {
            public string Name { get; }
            public IReadOnlyList<City> Cities { get; }

            public Country(string name, IReadOnlyList<City> cities)
            {
                Name = name;
                Cities = cities;
            }
        }
        public class City
        {
            public string Name { get; }
            public IReadOnlyList<Street> Streets { get; }

            public City(string name, IReadOnlyList<Street> streets)
            {
                Name = name;
                Streets = streets;
            }
        }
        public class Street
        {
            private string v;
            private List<int> list;

            public string Name { get; }
            public IReadOnlyList<string> Houses { get; }

            public Street(string name, IReadOnlyList<string> houses)
            {
                Name = name;
                Houses = houses;
            }

            public Street(string v, List<int> list)
            {
                this.v = v;
                this.list = list;
            }
        }

        public Form1()
        {
            InitializeComponent();
            InitializeData();
            CountryList();
        }

        private void InitializeData()
        {

            countries = new List<Country>
            {
                new Country("Россия", new List<City> { new City("Москва", new List<Street> { new Street("Дубна", new List<int> { 1, 2, 3 }) }) }),
                new Country("США", new List<City> { new City("Нью-Йорк", new List<Street> { new Street("Broadway", new List<int> { 10, 20, 30 }) }) }),

            };
        }
        private void CountryList()
        {
            
            foreach (var country in countries)
            {
                comboBoxCountry.Items.Add(country.Name);
            }
        }
        private void CityList(int countryIndex)
        {;
            foreach (var city in countries[countryIndex].Cities)
            {
                comboBoxCity.Items.Add(city.Name);
            }
        }

        private void StreetList(int countryIndex, int cityIndex)
        {
            
            foreach (var street in countries[countryIndex].Cities[cityIndex].Streets)
            {
                comboBoxStreet.Items.Add(street.Name);
            }
        }
        private void HouseList(int countryIndex, int cityIndex, int streetIndex)
        {
            
            foreach (var house in countries[countryIndex].Cities[cityIndex].Streets[streetIndex].Houses)
            {
                comboBoxHouse.Items.Add(house);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int countryIndex = comboBoxCountry.SelectedIndex;
            CityList(countryIndex);
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            int countryIndex = comboBoxCountry.SelectedIndex;
            int cityIndex = comboBoxCity.SelectedIndex;
            StreetList(countryIndex, cityIndex);

        }

        private void comboBoxStreet_SelectedIndexChanged(object sender, EventArgs e)
        {
            int countryIndex = comboBoxCountry.SelectedIndex;
            int cityIndex = comboBoxCity.SelectedIndex;
            int streetIndex = comboBoxStreet.SelectedIndex;
            HouseList(countryIndex, cityIndex, streetIndex);
        }
    }
}
