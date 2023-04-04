using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackHitbox : MonoBehaviour
{
    public GameObject AttackTrigger;
    private Collider2D AttackZone;
    public bool Strike;
    // Start is called before the first frame update
    void Awake()
    {
        AttackZone = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerCombat.SwordSwingCheck == true)
        {
            Fire1Check();
            AttackZone.enabled = true;
        }
        else
        {
            Strike = false;
            AttackZone.enabled = false;
        }
    }
    void Fire1Check()
    {
if (PlayerCombat.SwordSwingCheck == true)
        {
            Strike = true;
            return;
        }
    }
}
