using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerCombat : MonoBehaviour
{
    // Update is called once per frame
    public Animator animator;
    public Animator animator2;
    public float RateofAttack = 2.0f;
    private float NextAttack = 0f;
    private Vector2 input;
    static public bool SwordSwingCheck;
    void Update()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        var TargetPos = transform.position;
        SwordSwingCheck = false;

        {
            if (Input.GetButton("Fire1"))
            {
            
                TargetPos.x += input.x;
                TargetPos.y += input.y;

                animator.SetFloat("MoveX", input.x);
                animator.SetFloat("MoveY", input.y);
                if (Time.time >= NextAttack)
                {
                    Attack();
                    NextAttack = Time.time + 1f / RateofAttack;
                }
                if (SwordSwingCheck == false)
                {
                    SwordSwingCheck = true;
                    return;
                }
            }
        }
        void Attack()
        {
            animator.SetTrigger("Attack");
        }
    }
}
