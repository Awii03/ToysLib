namespace ToysLib
{
    public class Toy //En klasse er en skalgs skabelon for at oprette objekter
                     //En klasse definere attributer og metoder som man kan bruge til at manipulere og ændre disse egenskaber
                     //Atributter er dataelementer, som kan være hvilken som helst slags datatype (Bogstaver og tal)
                     //Metoder er funktioner der definerer adfærden for objekter af klassen  
    {
        //Properties 
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }


        //Methods
        //Metoden under overskriver den indbyggede ToString() metode for at returnere en streng, der repræsenterer legetøjet.
        //Koden man kan se nedenunder er en speciel funktion der ændre hvordan vi får information om et legetøj som en tekst.
        //Når vi beder om at se legetøj som tekst, vil nedenstående funktion give os en tekst der siger legetøjets "Id,Brand, Model, og Price"
        //For eksempel hvis vi har et legetøj med Id 1, Brand "Lego", Model "Star Wars", og Price 19, vil denne funktion give os teksten "Id: 1, Brand: Lego, Model: Star Wars, Price: 19".
        public override string ToString()
        {
            return $"Id: {Id}, Brand: {Brand}, Model: {Model}, Price: {Price}"; 

        }

        //Validation methods
        //De 3 metoder nedenudner validere henholdsvis mærket, modellen og prisen af legetøjet.
        //Hvis en egenskab ikke opfylder de angivne krav, kastes en ArgumentException.
        // 

        public void ValidateBrand() //Validerngs metoden "ValidateBrand()" Tjekker om mærket "Brand" af legetøjet er gyldigt.
        {
            if (string.IsNullOrEmpty(Brand))//If Statementet tjekker om mærket "Brand" er tomt
                throw new System.ArgumentException("Brand is required");//Formlen for kravene 
            if (Brand.Length < 2)//If Statementet tjekker om mærket "Brand" er mindre end 2
                throw new System.ArgumentException("Brand must be at least 2 characters");//Formlen for kravene
        }

        public void ValidateModel()//Validerngs metoden "ValidateModel()" Tjekker om mærket "Model" af legetøjet er gyldigt
        {
            if (string.IsNullOrEmpty(Model))//If Statementet tjekker om mærket "Model" er tomt
                throw new System.ArgumentException("Model is required");//Formlen for kravene 
            if (Model.Length < 2)//If Statementet tjekker om mærket "Model" er mindre end 2
                throw new System.ArgumentException("Model must be at least 2 characters");//Formlen for kravene 
        }

        public void ValidatePrice()//Validerngs metoden "ValidatePrice()" Tjekker om mærket "Price" af legetøjet er gyldigt
        {
            if (Price < 0)//If Statementet tjekker om mærket "Price" er mindre end 0
                throw new System.ArgumentException("Price must be greater than 0");//Formlen for kravene
        }


        //Metoden under kalder de tre ovenstående valideringsmetoder for at validere alle egenskaberne på én gang.
        public void Validate()//Validerngs metoden "Validate()" Tjekker om alle egenskaberne af legetøjet er gyldige
            //Den står som public fordi den skal kunne tilgås fra andre klasser og tejkker om alle egenskaberne af legetøjet er gyldige
        {
            ValidateBrand();
            ValidateModel();
            ValidatePrice();
        }
        //Samlet set repræsenterer Toy klassen et legetøj med forskellige egenskaber, og den indeholder metoder til at manipulere og validere disse egenskaber.

    }

}