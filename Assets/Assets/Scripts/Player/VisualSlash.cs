using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualSlash : MonoBehaviour
{
    public Animator animator;
    public float RateofAttack = 2.0f;
    private float NextAttack = 0f;
    void Update()
    {

        {
            if (Input.GetButton("Fire1"))
            {
                if (Time.time >= NextAttack)
                {
                    Attack();
                    NextAttack = Time.time + 1f / RateofAttack;
                }
            }
        }
        void Attack()
        {
            animator.SetTrigger("Attack");
        }
    }
}
