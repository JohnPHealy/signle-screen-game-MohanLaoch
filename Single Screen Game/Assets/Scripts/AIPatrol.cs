using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AIPatrol : MonoBehaviour
{
    [SerializeField] private UnityEvent<float> move;
    public Transform partrolLeft, patrolRight;

    [SerializeField] private float moveDir = 1f;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < partrolLeft.position.x)
        {
            moveDir = 1; 
        }

        if (transform.position.x > patrolRight.position.x)
        {
            moveDir = -1;
        }

        move.Invoke(moveDir);
    }

   
}
