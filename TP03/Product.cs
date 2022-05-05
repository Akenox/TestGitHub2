using System;

namespace exo1 {
	/// <summary>
	/// A simple product
	/// </summary>
	public class Product {
		private string code;

		public string Code
        {
			get { return code; }
			set { code = value; }
        }
		private string name;
		public string Name {
			get {
				return name;
			}
			set {
				name = value;
			}
		}
		private float priceIT;
		public float PriceET
		{
			get
			{
				return (priceIT * (1-vAT));
			}
			set
			{
				priceIT = (value / (1+vAT));
			}
		}
		
		public float PriceIT {
			get {
				return priceIT;
			}
			set {
				priceIT = value;
			}
		}
		private static float vAT;
		public static float VAT {
			get {
				return vAT;
			}
			set {
				vAT = value;
			}
		}

		/// <summary>
		/// Init the product
		/// </summary>
		/// <param name="code">the unique code of the product</param>
		/// <param name="name">the name of the product</param>
		/// <param name="price">The price (include tax) of the product</param>
		public Product(string codeC, string nameC, float priceC, float vATC) {
			code = codeC;
			name = nameC;
			priceIT = priceC;
			vAT = vATC;
			
		}

	}

}
