namespace Car_Customizer.Entities {
    public class Vehicle {
        public string  Brand { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }
        public string Color { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public int Speed { get; set; }
        public float Km { get; set; }
        public int LitersFuel { get; set; }
        
    /// Constructors
        public Vehicle(){
            // utilizando para Instância objetos sem ter que setar valores

        }
        // public Vehicle (string  brand, string model, string licenseplate, string color, double price, bool isactive, int speed, float km, int litersfuel){
        //     Brand = brand;
        //     Model = model;
        //     LicensePlate = licenseplate;
        //     Color = color;
        //     Price = price;
        //     IsActive = isactive;
        //     Speed = speed;
        //     Km = km;
        //     LitersFuel = litersfuel;
        // }
   
        public int SpeedUp(){
            return 0;
        }
        public double Tofuel(){
            return 0;
        }
        public string Stop() {
            return null;
        }
        public string ToPaint(){
            return null;
        }
        public string TurnOn(){
            return null;
        }
        public string TurnOff() {
            return null;
        }
    }
}