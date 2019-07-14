using System;
using System.Data.Entity;
using System.Linq;
using Chinook.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;

namespace Chinook.UnitTest
{
    [TestClass]
    public class AlbumDataTest
    {
        [TestMethod]
        public void 앨범의_갯수는_0보다_커야함()
        {
            using (DbContext context = DbContextFactory.Create())
            {
                Assert.AreEqual(true, context.Set<Album>().Count() > 0);

                // 여기서 오류 발생
            }
        }
    }
}
