using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class GeneralEnemyHealthSystem : MonoBehaviour
{
    public int Health = 100;
    public bool Damage = false;
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Damage == true)
        {
            Timer();
        }
        if (Health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "PlayerAttack")
        {
            Damage = true;
            return;
        }
        Damage = false;
        return;
    }
    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "PlayerAttack")
        {
            Damage = true;
            return;
        }
        Damage = false;
        return;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        Damage = false;
        return;
    }
    async void Timer()
    {
        while (Damage == true)
        {
            Health -= 10;
            await Task.Delay(3000);
            return;
        }
    }
}
