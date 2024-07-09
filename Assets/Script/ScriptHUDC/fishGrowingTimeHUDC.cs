using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class fishGrowingTimeHUDC : MonoBehaviour
{
    public Slider FishSlider;
    public GameObject healthFish;
    public GameObject FISH;

    public float TimeFishGrowrun;
    public float TimeFishToMature;

    void Start()
    {
        FishSlider.maxValue = TimeFishToMature;
        healthFish.SetActive(false);
    }

    void Update()
    {
        TimeFishGrowrun += Time.deltaTime;
        FishSlider.value = TimeFishGrowrun;
        FishSlider.maxValue = TimeFishToMature;

        if (TimeFishGrowrun > TimeFishToMature)
        {
            TimeFishGrowrun = TimeFishToMature;
            FISH.transform.localScale = new Vector3(1.05f, 1.05f, 1.05f);
        }
    }


    void OnMouseEnter()
    {
        healthFish.SetActive(true);
    }

    void OnMouseExit()
    {
        healthFish.SetActive(false);
    }
}
