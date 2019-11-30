using System;
using Cesar;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaMetodoSave()
        {
            ///Organizar
            
            Person person = new Person("Cesar", 100);
            //Voy a guardar 50 bs, el valor esperado seria 150
            double valoresperado = 150;

            ///Actuar

            person.Save(50);
            double valorobtenido = person.SaveMoney;

            ///Afirmar

            //Comprobando los valores
            Assert.AreEqual(valoresperado, valorobtenido);

        }
        [TestMethod]
        public void PruebaMetodoSpend()
        {
            ///Organizar

            Person person = new Person("Cesar", 100);
            //Voy a gastar 50 bs, el valor esperado seria 50
            double valoresperado = 50;

            ///Actuar

            person.Spend(50);
            double valorobtenido = person.SaveMoney;

            ///Afirmar

            //Comprobando los valores
            Assert.AreEqual(valoresperado, valorobtenido);

        }
        [TestMethod]
        public void PruebaMetodoNombre()
        {
            ///Organizar

            Person person = new Person("Cesar", 100);
            string valoresperado = "Andres"; //Nombre esperado

            ///Actuar

            person.ChangeName("Andres");
            string valorobtenido = person.Name; //Nombre obtenido

            ///Afirmar

            //Comprobando los valores
            Assert.AreEqual(valoresperado, valorobtenido);

        }
    }
}
