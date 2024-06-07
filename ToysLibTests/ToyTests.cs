using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToysLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToysLib.Tests
{
    [TestClass()]
    public class ToyTests
    {
        [TestMethod()]
        //Denne test kontrollerer, om ToString() metoden i Toy klassen returnerer den forventede streng.
        //Den opretter et nyt Toy objekt, sætter dets egenskaber, og sammenligner outputtet af ToString() metoden med den forventede streng
        public void ToStringTest()
        {
            //Arrange
            Toy toy = new Toy();

            toy.Id = 1;
            toy.Brand = "Lego";
            toy.Model = "Star Wars";
            toy.Price = 19;

            //Act 
            string result = toy.ToString();

            //Assert
            Assert.AreEqual("Id: 1, Brand: Lego, Model: Star Wars, Price: 19", result);
        }

        [TestMethod()]
        //Denne test kontrollerer, om ValidateBrand() metoden i Toy klassen kaster en ArgumentException, når mærket er tomt.
        public void ValidateBrandTest()
        {
            //Arrange
            var toy = new Toy();
            toy.Brand = "Lego";
            
            //Act
            toy.ValidateBrand();

            //Assert
            Assert.IsTrue(true);
            
        }

        
        [TestMethod()]
        //Denne test kontrollerer, om ValidateBrand() metoden i Toy klassen kaster en ArgumentException, når mærket er tomt.
        public void ValidateBrandTestException()
        {
            //Arrange
            var toy = new Toy();
            toy.Brand = "";
            Assert.ThrowsException<ArgumentException>(() => toy.ValidateBrand());
        }
        


        [TestMethod()]
        //Denne test kontrollerer, om ValidateModel() metoden i Toy klassen kaster en ArgumentException, når modellen er tomt.
        public void ValidateModelTest()
        {
            //Arrange
            var toy = new Toy();
            toy.Model = "Star Wars";
            
            //Act
            toy.ValidateModel();

            //Assert
            Assert.IsTrue(true);
            
        }


        [TestMethod()]
        //Denne test kontrollerer, om ValidateModel() metoden i Toy klassen kaster en ArgumentException, når modellen er tomt.
        public void ValidateModelTestException()
        {
            //Arrange
            var toy = new Toy();
            toy.Model = "";
            Assert.ThrowsException<ArgumentException>(() => toy.ValidateModel());
        }
        
    }
}