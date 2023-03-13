using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public float speed = 1f;
    public float detectionRadius = 5f;
    public float attackRadius = 1f;

    public bool shouldRotate;

    public LayerMask whatIsPlayer;

    private Transform target;
    private Rigidbody2D rb;
    private Animator anim;
    private Vector2 movement;
    public Vector3 direction;

    private bool chaseRange;
    private bool attackRange;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        target = GameObject.FindWithTag("Player").transform;
    }

    private void Update()
    {
        anim.SetBool("hasTarget", chaseRange);
        chaseRange = Physics2D.OverlapCircle(transform.position, detectionRadius, whatIsPlayer);
        attackRange = Physics2D.OverlapCircle(transform.position, attackRadius, whatIsPlayer);
        direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        direction.Normalize();
        movement = direction;
        if(shouldRotate)
        {
            anim.SetFloat("MoveX", direction.x);
            anim.SetFloat("MoveY", direction.y);
        }
    }

    private void FixedUpdate() 
    {
        if(chaseRange && !attackRange)
        {
            MoveCharacter(movement);
            anim.SetBool("inRange", attackRange);
        }
        if(attackRange)
        {
            rb.velocity = Vector2.zero;
            anim.SetBool("inRange", attackRange);
        }
    }

    private void MoveCharacter(Vector2 direction)
    {
        {
            rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
        }
    }
}
