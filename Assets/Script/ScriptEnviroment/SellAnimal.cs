using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellAnimal : MonoBehaviour
{
    public GameObject AnimalType;
    private int costPig =200;
    private int costChicken= 160;
    private int costFish = 320;
    public float TimeAnimal;



  
    pigGrowingTimeHUDC pigGrowTime;
    chickenGrowingTimeHUDC chickenGrowingTimeHUDC;
    fishGrowingTimeHUDC fishGrowingTimeHUDC;
    private void Awake()
    {
        pigGrowTime = GetComponent<pigGrowingTimeHUDC>();
        chickenGrowingTimeHUDC = GetComponent<chickenGrowingTimeHUDC>();
        fishGrowingTimeHUDC = GetComponent <fishGrowingTimeHUDC>();
        
    }
    void Start()
    {

    }

    void Update()
    {
       TimeAnimal+=Time.deltaTime;


    }
  

    private void OnMouseDown()
    { 

        if(DollarHUDC.instance.isDolarActive == true )
        {
          

            if (this.tag == "Pig")
            {
               

                if (TimeAnimal < pigGrowTime.TimepigToMature)
                {
                    costPig = costPig - Mathf.RoundToInt(costPig * ((pigGrowTime.TimepigToMature - TimeAnimal) / pigGrowTime.TimepigToMature));

                }
                GoldHUDC.instance.gold += costPig;
                GoldHUDC.instance.Gold_text.SetText(GoldHUDC.instance.gold.ToString());
                pigRelease.instance.quantityOfPig--;
                Destroy(AnimalType);

            }

            if (this.tag == "Chicken")
            {
                if (TimeAnimal < chickenGrowingTimeHUDC.TimeChickenToMature)
                {
                    costChicken = costChicken - Mathf.RoundToInt(costChicken * ((chickenGrowingTimeHUDC.TimeChickenToMature - TimeAnimal) / chickenGrowingTimeHUDC.TimeChickenToMature));

                 
                }
                GoldHUDC.instance.gold += costChicken;
                GoldHUDC.instance.Gold_text.SetText(GoldHUDC.instance.gold.ToString());
                chickenRelease.instance.quantityOfChicken--;
                Destroy(AnimalType);
            }

            if (this.tag == "Fish"  )
            {
                if (TimeAnimal < fishGrowingTimeHUDC.TimeFishToMature)
                {
                    costFish = costFish - Mathf.RoundToInt(costFish * ((fishGrowingTimeHUDC.TimeFishToMature - TimeAnimal) / fishGrowingTimeHUDC.TimeFishToMature));
                }
                GoldHUDC.instance.gold += costFish;
                GoldHUDC.instance.Gold_text.SetText(GoldHUDC.instance.gold.ToString());
                fishRelease.instance.quantityOfFish--;
                Destroy(AnimalType);
            }

        }

    }


   
}
