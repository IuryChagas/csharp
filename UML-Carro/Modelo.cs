using System.Collections.Generic;

namespace UML_Carro {
    public class Modelo {
        public string Marca { get; set; }
        public string Modelo1 { get; set; }
        public string Modelo2 { get; set; }
        public Modelo (string marca, string modelo1, string modelo2) {
            Marca = marca; 
            Modelo1 = modelo1;
            Modelo2 = modelo2;
        }
    }
}