using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ViajesMetroplusEntrega;

namespace ViajesMetroplusEntrega.Prueba
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            string[] nombresRutas = { "a", "b", "c", "d", "e" };
            int[] totalPasajerosPrueba = { 40, 32, 35, 35, 30 };
            string rutaMenorPrueba;
            int pasajerosRutaMenorPrueba;

            //Act - Actuar/Ejecutar
            Program.ObtieneRutaMenorPasajeros(totalPasajerosPrueba, nombresRutas, out rutaMenorPrueba, out pasajerosRutaMenorPrueba);

            //Assert - Validar/Comprobar/Verificar
            int numeroEsperado = 30;
            Assert.AreEqual(numeroEsperado, pasajerosRutaMenorPrueba);
        }

        [TestMethod]
        public void TestMethod2()
        {

            string[] nombresRutas = { "a", "b", "c", "d", "e" };
            int[] totalPasajerosPrueba = { 40, 32, 33, 35, 30 };
            string rutaMenorPrueba;
            int pasajerosRutaMenorPrueba;

            //Act - Actuar/Ejecutar
            Program.ObtieneRutaMenorPasajeros(totalPasajerosPrueba, nombresRutas, out rutaMenorPrueba, out pasajerosRutaMenorPrueba);

            //Assert - Validar/Comprobar/Verificar
            int numeroEsperado = 40;
            Assert.AreEqual(numeroEsperado, pasajerosRutaMenorPrueba);
        }

        [TestMethod]
        public void TestMethod3()
        {

            string[] nombresRutas = { "a", "b", "c", "d", "e" };
            int[] totalPasajerosPrueba = { 38, 10, 33, 25, 20 };
            string rutaMenorPrueba;
            int pasajerosRutaMenorPrueba;

            //Act - Actuar/Ejecutar
            Program.ObtieneRutaMenorPasajeros(totalPasajerosPrueba, nombresRutas, out rutaMenorPrueba, out pasajerosRutaMenorPrueba);

            //Assert - Validar/Comprobar/Verificar
            int numeroEsperado = 10;
            Assert.AreEqual(numeroEsperado, pasajerosRutaMenorPrueba);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Random aleatorio = new Random();
            Viaje[] viajesPrueba = new Viaje[10];
            string[] nombresRutas = { "a", "b", "c", "d", "e" };
            int[] pasajerosPrueba = { 5, 10, 15, 30, 20, 35, 20, 15, 5, 10 };
            int[] esperado = { 40, 30, 30, 35, 30 };



            for (int i = 0; i < viajesPrueba.Length; i++)
            {
                viajesPrueba[i] = new Viaje();
                viajesPrueba[i].Ruta = nombresRutas[aleatorio.Next(nombresRutas.Length)];
                viajesPrueba[i].CantidadPasajeros = pasajerosPrueba[i];
            }

            //Act - Actuar/Ejecutar
            int[] resultado = Program.TotalizaPasajerosRuta(viajesPrueba, nombresRutas);

            //Assert - Validar/Comprobar/Verificar

            Assert.AreEqual(esperado, resultado);
        }
    }
}
