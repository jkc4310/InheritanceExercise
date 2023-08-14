using System;
namespace Inheritance
{
	public class Bird : Animal 
	{
		public Bird()
		{
			Extinct = false;
			Legs = 2;
			Tail = true;
			LandSeaAir = "Air";
		}

		public string WingColor { get; set; }
		public bool CanFly { get; set; }
		public bool Migrate { get; set; }
		public double BeakLength { get; set; }
		
	}
}

