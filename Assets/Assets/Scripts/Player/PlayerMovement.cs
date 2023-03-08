using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed;
    private bool IsMoving;
    private Vector2 input;

    private void Update()
    {
        if (!IsMoving)
        {
            input.x = Input.GetAxisRaw("Horizontal");
            input.y = Input.GetAxisRaw("Vertical");
            if(input!= Vector2.zero)
            {
                var TargetPos = transform.position;
                TargetPos.x += input.x;
                TargetPos.y += input.y;

                StartCoroutine(Move(TargetPos));
            }
        }
    }
    IEnumerator Move(Vector3 TargetPos)
    {
        IsMoving = true;
        while ((TargetPos - transform.position).sqrMagnitude > Mathf.Epsilon)
        {
            transform.position = Vector3.MoveTowards(transform.position, TargetPos, MoveSpeed);
            yield return null;
        }
        transform.position = TargetPos;
        IsMoving = false;
    }
}
