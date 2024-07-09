using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TroughHUDC : MonoBehaviour
{
    public Slider TroughSlider;
    public GameObject trough;
    public GameObject troughnull;

    public int energyBar;
    public int energyBarReset;

    void Start()
    {
        energyBar = energyBarReset;
        TroughSlider.maxValue = energyBar;
    }

    void Update()
    {
        TroughSlider.value = energyBar;

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pig") || collision.CompareTag("Chicken") || collision.CompareTag("Fish"))    
        {

            energyBar -= 5;
        }

        if(energyBar ==0)
        {
            trough.SetActive(false);
            troughnull.SetActive(true);
            energyBar = energyBarReset;
        }
    }
}
