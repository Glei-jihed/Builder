using Xunit;

namespace Builder
{
    public class Enonce
    {
        private string address = "123 rue pipo";
        private string type = "Appartement";
        private string color = "Gris";
        private int windows = 5;
        private bool swimmingPool = true;
        private bool garage = false;

    
        public void Q01_Creer_une_classe_House()
        {
           House house = new House(address, type, color, windows, swimmingPool, garage);
           Assert.NotNull(house);
           Assert.Equal(address, house.Address);
           Assert.Equal(type, house.Type);
           Assert.Equal(color, house.Color);
           Assert.Equal(windows, house.Windows);
           Assert.Equal(swimmingPool, house.SwimmingPool);
           Assert.Equal(garage, house.Garage);
        }

        [Fact]
        public void Q02_Creer_une_classe_HouseBuilder()
        {
           HouseBuilder houseBuilder = new HouseBuilder();

           Assert.NotNull(houseBuilder);
        }

        [Fact]
        public void Q03_Creer_une_methode_pour_stocker_l_adresse_d_une_maison()
        {
           HouseBuilder houseBuilder = new HouseBuilder();

           houseBuilder = houseBuilder
                               .WithAddress(address);

           Assert.NotNull(houseBuilder);
        }

        [Fact]
        public void Q04_Creer_une_methode_build_qui_renvoit_une_maison_initialise_avec_une_adresse()
        {

           HouseBuilder houseBuilder = new HouseBuilder();

           House house =
                   houseBuilder
                       .WithAddress(address)
                       .Build();

           Assert.Equal(address, house.Address);
        }

        [Fact]
        public void Q05_Repeter_pour_les_proprietes_manquantes()
        {
           HouseBuilder houseBuilder = new HouseBuilder();

           House house = houseBuilder
                       .WithAddress(address)
                       .WithType(type)
                       .WithColor(color)
                       .WithWindows(windows)
                       .WithSwimmingPool(swimmingPool)
                       .WithGarage(garage)
                       .Build();

           Assert.Equal(address, house.Address);
           Assert.Equal(type, house.Type);
           Assert.Equal(color, house.Color);
           Assert.Equal(windows, house.Windows);
           Assert.Equal(swimmingPool, house.SwimmingPool);
           Assert.Equal(garage, house.Garage);
        }
    }
}