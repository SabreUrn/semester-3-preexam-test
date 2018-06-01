using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcOil {
	/// <summary>
	/// Handles conversion of litres into a couple of American units.
	/// </summary>
	public class CalcOil {
		/// <summary>
		/// Converts a number of litres to their equivalent in gallons.
		/// </summary>
		/// <param name="antalLiter">The amount of litres to convert.</param>
		/// <returns>Returns the amount of litres in gallons.</returns>
		public double LiterToGallons(double antalLiter) {
			return antalLiter * 0.264200793; //1 gallon = 3.785 litre, so 1 litre / 3.785 = 0.264200793 gallons
		}

		/// <summary>
		/// Converts a number of litres to their equivalent in oil barrels.
		/// </summary>
		/// <param name="antalLiter">The amount of litres to convert.</param>
		/// <returns>Returns the amount of litres in oil barrels.</returns>
		public double LiterToOilBarrels(double antalLiter) {
			return LiterToGallons(antalLiter) / 42; //text gives oil barrels to gallons, not litres to gallons, so convert and revert.
		}
	}
}
