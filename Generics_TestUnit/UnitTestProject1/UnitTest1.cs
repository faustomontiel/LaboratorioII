using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clase_17_Library;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void pruebaAdd()
    {

      MiLista<int> lista = new MiLista<int>();
      lista.Add(4);
      lista.Add(40);
      Assert.IsTrue(lista.Count==2);

      MiLista<string> listad = new MiLista<string>();
      listad.Add("4");
      listad.Add("40");
      Assert.IsTrue(listad.Count == 2);
    }


    [TestMethod]
    public void pruebaRemove()
    {
      MiLista<int> lista = new MiLista<int>();
      lista.Add(4);
      lista.Add(40);
      Assert.IsTrue(lista.Count == 2);

      lista.Remove(4);
      lista.Remove(40);
      Assert.IsTrue(lista.Count == 0);


    }
  }
}
