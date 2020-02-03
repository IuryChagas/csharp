namespace Car_Customizer.Entities {
    public class Model {
        public string Brand { get; set; }
        public string Model1 { get; set; }
        public string Model2 { get; set; }
        public Model (string brand, string model1, string model2) {
            Brand = brand; 
            Model1 = model1;
            Model2 = model2;
        }
    }
}