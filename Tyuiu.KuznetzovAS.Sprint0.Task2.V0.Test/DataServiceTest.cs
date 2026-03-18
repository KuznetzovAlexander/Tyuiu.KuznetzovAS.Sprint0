using Tyuiu.KuznetzovAS.Sprint0.Task2.V0.Lib;
namespace Tyuiu.KuznetzovAS.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Александр";
            var res = DataService.GetMessage(name);

            //Вызовем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Александр", res);
        }
    }
}