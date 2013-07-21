using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StubDataAccess;
using StubDataAccess.Entities;
using StubDataAccess.Types;

namespace StubDataAccess.Tests
{
    [TestClass]
    public class ModelTest
    {
        [TestMethod]
        public void Test01()
        {
            using (var container = new StubDataAccess.StubContext())
            {
                Subject subject = new Subject() {Name = "poo2",SubjectType = SubjectType.Park};
                container.Subjects.Add(subject);
                container.SaveChanges();
            }
        }
    }
}
