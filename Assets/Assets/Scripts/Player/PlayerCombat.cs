using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerCombat : MonoBehaviour
{
    // Update is called once per frame
    public Animator animator;
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Attack();
        }
        void Attack()
        {
            animator.SetTrigger("Attack");
        }
    }
}
