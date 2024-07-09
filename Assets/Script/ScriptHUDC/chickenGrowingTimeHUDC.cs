using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class chickenGrowingTimeHUDC : MonoBehaviour
{
    public Slider ChickenSlider;  
    public GameObject healthChicken; 
    public GameObject CHICKEN;
    public float TimeChickenGrowRun;  
    public float TimeChickenToMature;  

    void Start()
    {
        ChickenSlider.maxValue = TimeChickenToMature;
        healthChicken.SetActive(false);
    }

    void Update()
    {
        TimeChickenGrowRun += Time.deltaTime;
        ChickenSlider.value = TimeChickenGrowRun;
        ChickenSlider.maxValue = TimeChickenToMature;


        if (TimeChickenGrowRun > TimeChickenToMature)
        {
            TimeChickenToMature = TimeChickenGrowRun ;
            CHICKEN.transform.localScale = new Vector3(1.05f,1.05f, 1.05f);  
        }

      
    }

  
    void OnMouseEnter()
    {
        healthChicken.SetActive(true); 
    }

    void OnMouseExit()
    {
        healthChicken.SetActive(false);  
    }
}
