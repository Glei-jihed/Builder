 using Builder;

 
 namespace Builder
 {
     public class HouseBuilder
    {
        private string address;
        private string type;
        private string color;
        private int windows;
        private bool swimmingPool;
        private bool garage;
    

            public HouseBuilder WithAddress(string address)
            {
            this.address = address;
            return this;
            }

            public HouseBuilder WithType(string type){
            this.type = type;
            return this;
            }

            public HouseBuilder WithColor(string color)
            {
                this.color = color;
                return this;
            }

            public HouseBuilder WithWindows(int windows)
            {
                this.windows = windows;
                return this;
            }

            public HouseBuilder WithSwimmingPool(bool swimmingPool)
            {
                this.swimmingPool = swimmingPool;
                return this;
            }

            public HouseBuilder WithGarage(bool garage)
            {
                this.garage = garage;
                return this;
        }

         public House Build()
        {
            return new House(address, type, color, windows, swimmingPool, garage);
        }
    }
 }
