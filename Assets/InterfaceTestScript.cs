using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceTestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Trapezium trapezium = new Trapezium();
        trapezium.CalculateArea();
        trapezium.CalculatePerimeter();
        trapezium.CalculateUnknownSides();

        Circle circle = new Circle();
        circle.CalculateArea();
        circle.CalculatePerimeter();
        circle.CalculateRadius();

        Nonagon nonagon = new Nonagon();
        nonagon.CalculateArea();
        nonagon.CalculatePerimeter();
        int sides = nonagon.CalculateNumberOfSides();
        Debug.Log("Nonagon Number of Sides: " + sides);
    }

    // Update is called once per frame
    void Update()
    {
    }
}

public interface IShape
{
    void CalculateArea();
    void CalculatePerimeter();
}

public class Trapezium : IShape
{
    public float base1 = 5f;
    public float base2 = 7f;
    public float height = 4f;
    public float side1 = 3f;
    public float side2 = 3f;

    public void CalculateArea()
    {
        float area = 0.5f * (base1 + base2) * height;
        Debug.Log("Trapezium Area: " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = base1 + base2 + side1 + side2;
        Debug.Log("Trapezium Perimeter: " + perimeter);
    }

    public void CalculateUnknownSides()
    {
        // Assuming the unknown sides are equal and the given side1 and side2 are known
        float unknownSide = Mathf.Sqrt((base2 - base1) * (base2 - base1) + height * height);
        Debug.Log("Trapezium Unknown Side: " + unknownSide);
    }
}

public class Circle : IShape
{
    public float radius = 5f;

    public void CalculateArea()
    {
        float area = Mathf.PI * Mathf.Pow(radius, 2);
        Debug.Log("Circle Area: " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = 2 * Mathf.PI * radius;
        Debug.Log("Circle Perimeter: " + perimeter);
    }

    public void CalculateRadius()
    {
        // For demonstration, assume we calculate the radius if given a circumference
        float circumference = 2 * Mathf.PI * radius;
        float calculatedRadius = circumference / (2 * Mathf.PI);
        Debug.Log("Calculated Circle Radius: " + calculatedRadius);
    }
}

public class Nonagon : IShape
{
    public int numberOfSides = 9;
    public float sideLength = 5f;

    public void CalculateArea()
    {
        float area = (9 * Mathf.Pow(sideLength, 2)) / (4 * Mathf.Tan(Mathf.PI / 9));
        Debug.Log("Nonagon Area: " + area);
    }

    public void CalculatePerimeter()
    {
        float perimeter = numberOfSides * sideLength;
        Debug.Log("Nonagon Perimeter: " + perimeter);
    }

    public int CalculateNumberOfSides()
    {
        return numberOfSides;
    }
}
