using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsoleApp1.Modelos
{

    public class Cripto
    {
        public List<CriptoMoedas>? Data { get; set; }
    }
    public class CriptoMoedas
    {
        public int Id { get; set; }
        public int Rank { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Slug { get; set; }
        public int Is_active { get; set; }

    }   

}
