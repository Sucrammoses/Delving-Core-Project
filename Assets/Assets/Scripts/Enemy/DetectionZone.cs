using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionZone : MonoBehaviour
{
    public bool EnemyIsMoving=false;

    public float speed = 1f;
    private Transform EnemyTarget;
    private Vector2 direct;
    private Animator Animation;

    private void Update()
    {
        if (EnemyTarget != null)
        {
            EnemyIsMoving = true;
            float EnemyMovement = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, EnemyTarget.position, EnemyMovement);
        }
        else
        {
            EnemyIsMoving = false;
        }

        if (EnemyIsMoving == false)
        {
            Animation.SetFloat("MoveX", 1);
        }
        else
        {

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            EnemyTarget = other.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            EnemyTarget = null;
        }
    }


    }
