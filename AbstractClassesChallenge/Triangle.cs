using System;

namespace AbstractClassesChallenge
{
    public class Triangle : Shape
    {
        // HINT: Use Herons Formula to calculate and set the area.
	private double side1;
	private double side2;
	private double side3;

	public Triangle () : base ("Triangle", 3){
		base.Name = "Triangle";
		base.NumSides = 3;
		this.side1 = 0;
		this.side2 = 0;
		this.side3 = 0;

		SetArea();
	}

	public Triangle (double side1, double side2, double side3) : base ("Triangle", 3) {
		base.Name = "Triangle";
		base.NumSides = 3;
		this.side1 = side1;
		this.side2 = side2;
		this.side3 = side3;

		SetArea();
	}

	public Triangle (string name, int numSides, double side1, double side2, double side3) : base (name, numSides)  {
                base.Name = name;
                base.NumSides = numSides;
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;

                SetArea();
        }


	protected override void SetArea() {
		double sp = (this.side1 + this.side2 + this.side3) / 2;
		this.area = Math.Sqrt(sp*(sp - this.side1)*(sp - this.side2)*(sp - this.side3));
	}
    }
}
