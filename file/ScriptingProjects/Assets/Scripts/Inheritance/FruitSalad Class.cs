using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSaladClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Creating the fruit");
        FruitClass myFruit = new FruitClass();
        Debug.Log("Creating the apple");
        AppleClass myApple = new AppleClass();

        myFruit.SayHello();
        myFruit.Chop();

        myApple.SayHello();
        myApple.Chop();

        Debug.Log("Creating the fruit");
        myFruit = new FruitClass("yellow");
        Debug.Log("Creating the apple");
        myApple = new AppleClass("green");

        myFruit.SayHello();
        myFruit.Chop();

        myApple.SayHello();
        myApple.Chop();
    }
}
