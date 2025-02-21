using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitClass
{
    public string color;

    public FruitClass()
    {
        color = "orange";
        Debug.Log("1st Fruit Constructor Called");
    }

    public FruitClass(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Fruit Constructor Called");
    }

    public void Chop()
    {
        Debug.Log("The " + color + " fruit has been chopped.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit");
    }
}
