using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyClass : HumanoidClass
{
    new public void Yell()
    {
        Debug.Log("Enemy ver. of Yell()");
    }
}
