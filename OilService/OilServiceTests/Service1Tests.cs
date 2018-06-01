using Microsoft.VisualStudio.TestTools.UnitTesting;
using OilService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OilService.Tests {
	[TestClass()]
	public class Service1Tests {
		[TestMethod()]
		public void Test_LiterToGallons_OneLitre() {
			Service1 service = new Service1();
			double expected = Math.Round(0.264200793, 3);
			double actual = Math.Round(service.LiterToGallons(1), 3);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void Test_LiterToGallons_DecimalLitres() {
			Service1 service = new Service1();
			double expected = Math.Round(0.264200793 * 2.75, 3);
			double actual = Math.Round(service.LiterToGallons(2.75), 3);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void Test_LiterToOilBarrels_OneLitre() {
			Service1 service = new Service1();
			double expected = Math.Round(1.0 * 0.264200793 / 42, 3);
			double actual = Math.Round(service.LiterToOilBarrels(1), 3);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void Test_LiterToOilBarrels_DecimalLitres() {
			Service1 service = new Service1();
			double expected = Math.Round(2.75 * 0.264200793 / 42, 3);
			double actual = Math.Round(service.LiterToOilBarrels(2.75), 3);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void Test_GallonsToLiter_OneGallon() {
			Service1 service = new Service1();
			double expected = Math.Round(3.785, 3);
			double actual = Math.Round(service.GallonsToLiter(1), 3);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void Test_GallonsToLiter_DecimalGallons() {
			Service1 service = new Service1();
			double expected = Math.Round(2.75 * 3.785, 3);
			double actual = Math.Round(service.GallonsToLiter(2.75), 3);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void Test_OilBarrelsToLiter_OneOilBarrel() {
			Service1 service = new Service1();
			double expected = Math.Round(42 * 3.785, 3);
			double actual = Math.Round(service.OilBarrelsToLiter(1), 3);
			Assert.AreEqual(expected, actual);
		}

		[TestMethod()]
		public void Test_OilBarrelsToLiter_DecimalOilBarrels() {
			Service1 service = new Service1();
			double expected = Math.Round(2.75 * 42 * 3.785, 3);
			double actual = Math.Round(service.OilBarrelsToLiter(2.75), 3);
			Assert.AreEqual(expected, actual);
		}
	}
}