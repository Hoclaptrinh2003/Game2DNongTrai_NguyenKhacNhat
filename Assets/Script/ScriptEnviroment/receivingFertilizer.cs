using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class receivingFertilizer : MonoBehaviour
{
    Plant pl;
    TimeFlowerHUDC TfHUDC;
    fertilizerHUDC[] FlHUDC;
    public int number_Fertiliz;
    [SerializeField] private GameObject out_Fertilizer_img;

    void Awake()
    {
        pl =  GetComponent<Plant>();
        TfHUDC = GetComponent<TimeFlowerHUDC>();
        FlHUDC = FindObjectsOfType<fertilizerHUDC>();
    }

    void Update()
    {
        
    }

   

    private void OnMouseDown()
    {
        foreach(fertilizerHUDC FlHUDC in FlHUDC) 
        { 
          if(FlHUDC.isFertilizerActive == true)
            {
                if (playerBag.instance.fertilizerName[number_Fertiliz].number_fertilizer == 0)
                {
                    StartCoroutine(TextFertilizerHUDC.instance.ShowOveroutFertilizer());
                    return;
                }

                if (TfHUDC.TimefloweringHUDC > TfHUDC.TimeflowerunHUDC)
                {
                    playerBag.instance.fertilizerName[number_Fertiliz].number_fertilizer--;
                }

                switch (number_Fertiliz)
                {
                    case 0:
                        pl.timeFlowering -= 5;
                        pl.timeFlowerSeed -= 5;
                        TfHUDC.TimefloweringHUDC -= 5;
                        break;
                    case 1:
                        pl.timeFlowering -= 10;
                        pl.timeFlowerSeed -= 10;
                        TfHUDC.TimefloweringHUDC -= 10;
                        break;
                    case 2:
                        pl.timeFlowering -= 20;
                        pl.timeFlowerSeed -= 20;
                        TfHUDC.TimefloweringHUDC -= 20;
                        break;
                    case 3:
                        pl.timeFlowering -= 30;
                        pl.timeFlowerSeed -= 30;
                        TfHUDC.TimefloweringHUDC -= 30;
                        break;
                    case 4:
                        pl.timeFlowering -= 50;
                        pl.timeFlowerSeed -= 50;
                        TfHUDC.TimefloweringHUDC -= 50;
                        break;
                    case 5:
                        pl.timeFlowering -= 80;
                        pl.timeFlowerSeed -= 80;
                        TfHUDC.TimefloweringHUDC -= 80;
                        break;
                    case 6:
                        pl.timeFlowering -= 120;
                        pl.timeFlowerSeed -= 120;
                        TfHUDC.TimefloweringHUDC -= 120;
                        break;
                    case 7:
                        pl.timeFlowering -= 200;
                        pl.timeFlowerSeed -= 200;
                        TfHUDC.TimefloweringHUDC -= 200;
                        break;
                }
              

                if (TfHUDC.TimefloweringHUDC < TfHUDC.TimeflowerunHUDC)
                {
                    TfHUDC.TimefloweringHUDC = TfHUDC.TimeflowerunHUDC;
                }

                if (TfHUDC.TimefloweringHUDC == TfHUDC.TimeflowerunHUDC)
                {
                    pl.timeFlowering = TfHUDC.TimefloweringHUDC;
                    return;
                }


            }



        }
       
       
    }
}
