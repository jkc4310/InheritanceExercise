using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
            Extinct = false;
            Legs = 4;
            Tail = true;
            LandSeaAir = "Land";
        }

		public bool Nocturnal { get; set; }
		public bool HasATail { get; set; }
		public bool IsColdBlooded { get; set; }
		public string Habitat { get; set; }
	}
}

