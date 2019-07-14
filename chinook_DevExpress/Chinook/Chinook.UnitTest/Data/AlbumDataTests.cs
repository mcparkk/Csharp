using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chinook.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Data.Tests
{
    [TestClass()]
    public class AlbumDataTests
    {
        [TestMethod()]
        public void GetModelsTest()
        {
            var models = DataRepository.Album.GetModels();

            Assert.IsTrue(models.Count > 0);
        }
    }
}