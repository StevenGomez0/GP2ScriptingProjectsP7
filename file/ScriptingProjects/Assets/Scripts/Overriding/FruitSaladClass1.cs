using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSaladClass1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AppleClass1 myApple = new AppleClass1();

        myApple.SayHello();
        myApple.Chop();

        FruitClass1 myFruit = new AppleClass1();
        myFruit.SayHello();
        myFruit.Chop();
    }
}
