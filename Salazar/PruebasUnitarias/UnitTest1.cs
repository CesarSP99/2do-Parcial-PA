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
    }
}
