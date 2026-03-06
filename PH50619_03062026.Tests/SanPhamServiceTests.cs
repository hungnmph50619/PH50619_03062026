using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH50619_03062026.Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class SanPhamServiceTests
    {
        private SanPhamService service;

        [SetUp]
        public void Setup()
        {
            service = new SanPhamService();
        }

        [Test]
        public void Xoa_MaTonTai()
        {
            bool kqtt = service.Xoa("001");

            bool kqmm = true;

            Assert.AreEqual(kqmm, kqtt);
        }

        [Test]
        public void Xoa_MaKhongTonTai()
        {
            bool kqtt = service.Xoa("099");

            bool kqmm = false;

            Assert.AreEqual(kqmm, kqtt);
        }

        [Test]
        public void Xoa_MaNull()
        {
            bool kqtt = service.Xoa(null);

            bool kqmm = false;

            Assert.AreEqual(kqmm, kqtt);
        }

        [Test]
        public void Xoa_MaRong()
        {
            bool kqtt = service.Xoa("");

            bool kqmm = false;

            Assert.AreEqual(kqmm, kqtt);
        }

        [Test]
        public void Xoa_MaTonTai_GiamSoLuong()
        {
            int before = service.Count();

            service.Xoa("001");

            int after = service.Count();

            Assert.AreEqual(before - 1, after);
        }
    }
}
