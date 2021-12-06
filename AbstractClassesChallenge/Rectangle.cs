using System;

namespace AbstractClassesChallenge
{
    public class Rectangle : Shape
    {
        private double side1;
	private double side2;

	public Rectangle() : base ("Rectangle", 4) {
		base.NumSides = 4;
		base.Name = "Rectangle";
		this.side1 = 0;
		this.side2 = 0;

		SetArea();
	}

	 public Rectangle(double side1, double side2) : base ("Rectangle", 4) {
                base.Name = "Rectangle";
		base.NumSides = 4;
                this.side1 = side1;
                this.side2 = side2;

                SetArea();

        }

	public Rectangle(string name, int numSides, double side1, double side2) : base (name, numSides) {
		base.Name = name;
		base.NumSides = numSides;
		this.side1 = side1;
		this.side2 = side2;

		SetArea();

	}

	protected override void SetArea() {
		this.area = side1*side2;
	}
    }
}
