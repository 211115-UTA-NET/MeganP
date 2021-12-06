using System;

namespace AbstractClassesChallenge
{
    public class Square : Rectangle
    {
        private double side;

	public Square() {
		base.Name = "Square";
		base.NumSides = 4;
		this.side = 0;
		
		SetArea();
	}

	public Square(double side) {
		base.Name = "Square";
		base.NumSides = 4;
		this.side = side;

		SetArea();
	}

	public Square(string name, int numSides, double side) {
                base.Name = name;
                base.NumSides = numSides;
                this.side = side;

                SetArea();
        }


	protected override void SetArea() {
		this.area = side*side;
	}
    }
}
