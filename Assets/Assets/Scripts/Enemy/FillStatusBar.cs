using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillStatusBar : MonoBehaviour
{

    public PlayerGlobalHealth playerGlobalHealth;
    public Image fillImage;
    private Slider slider;


    // Start is called before the first frame update
    void Awake()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        float fillValue = (playerGlobalHealth.currentHealth / playerGlobalHealth.maxHealth);

        

        Debug.Log(fillValue);
        slider.value = fillValue;
        Debug.Log(slider.value);
    }
}
