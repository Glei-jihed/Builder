public class House {
    public string Address;
    public  string Type;
    public  string Color;
    public  int Windows;
    public  bool Garage;
    public  bool SwimmingPool;

    public House(string address, string type, string color, int windows, bool swimmingPool, bool garage) {
        Address = address;
        Type = type;
        Color = color;
        Windows = windows;
        SwimmingPool = swimmingPool;
        Garage = garage;
    }
}