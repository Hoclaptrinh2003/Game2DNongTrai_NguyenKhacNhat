using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeFlowerHUDC : MonoBehaviour
{
    public Slider FlowerSlider;
    public GameObject healthFlower;
 

    public float TimeflowerunHUDC;
    public float TimefloweringHUDC;
    void Start()
    {
        FlowerSlider.maxValue = TimefloweringHUDC;
        healthFlower.SetActive(false);

    }

    void Update()
    {
        TimeflowerunHUDC += Time.deltaTime;
        FlowerSlider.value = TimeflowerunHUDC;
        FlowerSlider.maxValue = TimefloweringHUDC;


        if (TimeflowerunHUDC > TimefloweringHUDC)
        {
            TimeflowerunHUDC = TimefloweringHUDC;
        }

    }

    void OnMouseEnter()
    {
        healthFlower.SetActive(true); 
    }

    void OnMouseExit()
    {
        healthFlower.SetActive(false); 
    }
}
