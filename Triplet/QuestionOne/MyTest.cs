using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionOne
{
    [TestFixture]
    class MyTest
    {
        [TestCase]
        public void sendString()
        {
            Form1 form = new Form1();
            Assert.AreEqual("I like: 2 like cats: 3 you like: 2 Are you: 2 you sure: 2", form.getTriplates("Hello, I like cats. Do you like cats? No? Are you sure? Why don't you like cats? Are you sure? I like you"));
        }
    }
}
