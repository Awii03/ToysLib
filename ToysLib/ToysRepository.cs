using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysLib
{


    //Koden under definere min toys repository klasse i toyslib projektet.
    //Klassen under repræsentere mit legetøjslager og indeholder metoder til at hente data fra dette lager.
    public class ToysRepository 
    {
        //Her har jeg en privat liste af mine toy objektor som repræsentere mit legetøjslager 
        private List<Toy> toys = new List<Toy>
        {
            new Toy{Id = 1, Brand = "Lego", Model = "Star Wars", Price = 19},
            new Toy{Id = 2, Brand = "Playmobil", Model = "Pirate", Price = 25},
            new Toy{Id = 3, Brand = "Barbie", Model = "Princess", Price = 15},
            new Toy{Id = 4, Brand = "Playmobil", Model = "Knights", Price = 30},
            new Toy{Id = 5, Brand = "Lego", Model = "City", Price = 20},
        };



        //Metoden under atger et id som input og returnerer det legetøj, der matcher det givne id.
        //Hvis der ikke findes noget legetøj med det givne id, kastes en ArgumentException. 
        public Toy GetById(int id) 
        {
            Toy? toy = toys.FirstOrDefault(t => t.Id == id);
            if (toy == null)
            {
                throw new ArgumentException("Toy not found");
            }
            return toy;
        }




        //Metoden under returnerer en liste af legetøj.
        //Den tager to valgfrie parametre: pris og mærke.
        //Hvis en pris er angivet, returneres kun legetøj med en pris mindre end eller lig med den angivne pris.
        //Hvis et mærke er angivet, returneres kun legetøj af det angivne mærke.
        public List <Toy> GetAll(int price = 0, string? brand = null) 
        {
            List<Toy> toys = new List<Toy>();
            if (price > 0)
            {
                toys = this.toys.Where(t => t.Price <= price).ToList();
            }
            else
            {
                toys = this.toys;
            }
            if (brand != null)
            { 
                toys = toys.Where(t => t.Brand == brand).ToList();
            }
            return toys;
        }

        //Metoden under tager et Toy objekt som input og tilføjer det til lageret.
        //Før legetøjet tilføjes, valideres det ved at kalde Validate() metoden på Toy objektet.
        public Toy Add(Toy toy)
        {
            toy.Validate();
            toys.Add(toy);
            return toy;
        }

        //Metoden under fjerner et legetøj fra lageret baseret på dets id.
        //Den bruger GetById(int id) metoden til at finde legetøjet, der skal fjernes.
        public Toy Remove(int id)
        {
            Toy toy = GetById(id);
            toys.Remove(toy);
            return toy;

        }
        
    }

}
