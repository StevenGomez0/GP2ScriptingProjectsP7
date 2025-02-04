using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int exp;

    public int Exp
    {
        get
        {
            return exp;
        }
        set
        {
            exp = value;
        }
    }

    public int Level
    {
        get
        {
            return exp / 1000;
        }
        set
        {
            exp = value * 1000;
        }
    }

    //auto implement
    public int MyProperty { get; set; }

    public int Health { get; set; }
} 
