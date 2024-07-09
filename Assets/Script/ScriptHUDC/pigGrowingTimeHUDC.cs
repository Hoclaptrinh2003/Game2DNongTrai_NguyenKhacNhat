using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pigGrowingTimeHUDC : MonoBehaviour
{
    public Slider PigSlider;
    public GameObject healthPig;
    public GameObject PIG;


    public float TimepigGrowrun;
    public float TimepigToMature;
    void Start()
    {
        PigSlider.maxValue = TimepigToMature;
        healthPig.SetActive(false);
       
    }

    void Update()
    {
        TimepigGrowrun += Time.deltaTime;
        PigSlider.value = TimepigGrowrun;
        PigSlider.maxValue = TimepigToMature;


        if (TimepigGrowrun > TimepigToMature)
        {
            TimepigToMature = TimepigGrowrun;
            PIG.transform.localScale = new Vector3(1.12f, 1.12f, 1.12f);
            StartCoroutine(closePigSty());
           

        }

      
    }

   

    private IEnumerator closePigSty()
    {
        
        yield return new WaitForSeconds(5f);
        foreach (GameObject pigsty in Pigsty.instance.pigsty)
        {
            pigsty.SetActive(false);
        }
    }

  

    void OnMouseEnter()
    {
        healthPig.SetActive(true);
    }

    void OnMouseExit()
    {
        healthPig.SetActive(false);
    }
}
