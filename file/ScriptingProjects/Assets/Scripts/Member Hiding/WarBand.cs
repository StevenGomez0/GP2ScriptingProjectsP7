using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBand : MonoBehaviour
{
    void Start()
    {
        //so the project for this said to have line 10 thru 12 all start with "humanoidClass"
        //but that just returned humanoid yell three times
        //i dont know if this was intended 
        HumanoidClass human = new HumanoidClass();
        EnemyClass enemy = new EnemyClass();
        OrcClass orc = new OrcClass();

        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}
