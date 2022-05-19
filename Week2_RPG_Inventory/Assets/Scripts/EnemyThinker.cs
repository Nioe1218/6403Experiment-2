using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThinker : MonoBehaviour
{
    public Ai ai;
    void Update()
    {
        ai.Think(this);
    }
}
