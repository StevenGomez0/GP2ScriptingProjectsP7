using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MulticastScript : MonoBehaviour
{
    delegate void MultiDelegate();
    MultiDelegate multiDelegate;


    private void Start()
    {
        multiDelegate += PowerUp;
        multiDelegate += TurnRed;
        if(multiDelegate != null)
        {
            multiDelegate();
        }
    }

    void PowerUp()
    {
        print("orb is powering up");
    }

    void TurnRed()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
}
