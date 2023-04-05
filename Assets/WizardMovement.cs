using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardMovement : MonoBehaviour
{
    public Transform[] WizardMovements;
    public float moveSpeed;
    public int movementPoint;
 
    // Update is called once per frame
    void Update()
    {
        if(movementPoint == 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, movementPoint[0].position, moveSpeed * Time.deltaTime);
            if(Vector2.Distance(transform.position, movementPoint[0].position) < .2f)
            {
                patrolDestination = 1;
            }
        }
        if(movementPoint == 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, movementPoint[1].position, moveSpeed * Time.deltaTime);
            if(Vector2.Distance(transform.position, movementPoint[1].position) < .2f)
            {
                patrolDestination = 0;
            }
        }
    }
    }

