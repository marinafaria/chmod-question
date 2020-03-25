using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using ProvaAnalistaDevJúnior.Program;

namespace ProgramTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void Main()
        {
            string str = "rwxr-x-w-";

            int actual = Program.SymbolicToOctal(str);

            Assert.AreEqual(752, actual, "Correto", "Incorreto");
        }
    }
}
