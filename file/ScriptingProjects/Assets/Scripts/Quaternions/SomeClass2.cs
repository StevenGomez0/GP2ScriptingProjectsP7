using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass2 : MonoBehaviour
{
    private void Start()
    {
        transform.rotation = Quaternion.identity;
        Debug.Log("rotation set to quaternion identity");
    }
}
