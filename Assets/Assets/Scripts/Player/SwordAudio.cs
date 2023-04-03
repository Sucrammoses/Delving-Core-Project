using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAudio : MonoBehaviour
{
    AudioSource SwordSwing;
    // Start is called before the first frame update
    void Start()
    {
        SwordSwing = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
     if (PlayerCombat.SwordSwingCheck == true)
        {
            SwordSwing.Play();
        }
    }
}
