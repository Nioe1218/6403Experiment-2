using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="Ai/Chase")]
public class ChaseAi : Ai
{
    public string targetTag;
    public override void Think(EnemyThinker thinker)
    {
        GameObject target = GameObject.FindGameObjectWithTag(targetTag);
        if (target)
        {
            var movement = thinker.gameObject.GetComponent<Movement>();
            if (movement)
            {
                movement.MoveToPlayer(target.transform.position        );
            }
        }
    }

        
    
}
