using Microsoft.VisualBasic.Devices;
using System.Diagnostics.Metrics;

namespace Списочные_Элементы {


    public partial class Form1 : Form {
        public Form1 () {
            InitializeComponent ();

            IReadOnlyList<Country> countries = InitializeData ();  // countries теперь локальная переменная
            PopulateCountryList (countries);
        }

        private IReadOnlyList<Country> InitializeData () {
            return new Country[] {
                new Country("Россия",
                    new City("Москва",
                        new Street("Дубна", new House (1), new House (2)),
                        new Street("Ленинский проспект", new House (1), new House (2))
                    ),
                    new City("Санкт-Петербург",
                        new Street("Московское шоссе", new House (3), new House (4)),
                        new Street("Ленинский проспект", new House (1), new House (2))
                    )
                ),
                new Country("США",
                    new City("Нью-Йорк",
                        new Street("Broadway", new House (20), new House (30)),
                        new Street ("13 Avenue", new House (50), new House (60))
                    )
                ),
            };
        }
        private void PopulateCountryList (IEnumerable<Country> countries) {
            foreach (var country in countries)
                comboBoxCountry.Items.Add (country);  // Добавляем объект, а не строку
        }
        private void PopulateCityList (IEnumerable<City> cities) {
            foreach (var city in cities)
                comboBoxCity.Items.Add (city);  // Добавляем объект, а не строку
        }
        private void PopulateStreetList (IEnumerable<Street> streets) {
            foreach (var street in streets)
                comboBoxStreet.Items.Add (street);  // Добавляем объект, а не строку
        }
        private void PopulateHouseList (IEnumerable<House> houses) {
            foreach (var house in houses)
                comboBoxHouse.Items.Add (house);  // Добавляем объект, а не строку
        }

        private void comboBoxCountry_SelectedIndexChanged (object sender, EventArgs e) {
            Country? selectedCountry = (Country?) comboBoxCountry.SelectedItem;
            if (selectedCountry is null) return;
            comboBoxCity.Items.Clear ();
            comboBoxStreet.Items.Clear ();
            comboBoxHouse.Items.Clear ();
            PopulateCityList (selectedCountry.Cities);
        }

        private void comboBoxCity_SelectedIndexChanged (object sender, EventArgs e) {
            City? selectedCity = (City?) comboBoxCity.SelectedItem;
            if (selectedCity is null) return;
            comboBoxStreet.Items.Clear ();
            comboBoxHouse.Items.Clear ();
            PopulateStreetList (selectedCity.Streets);
        }

        private void comboBoxStreet_SelectedIndexChanged (object sender, EventArgs e) {
            Street? selectedStreet = (Street?) comboBoxStreet.SelectedItem;
            if (selectedStreet is null) return;
            comboBoxHouse.Items.Clear ();
            PopulateHouseList (selectedStreet.Houses);
        }
    }
}
