using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static Unity.Collections.AllocatorManager;
public class TextSeedHUDC : MonoBehaviour
{
    [SerializeField] private GameObject bag;
   // private Land[] ld;
    [SerializeField] private TextMeshProUGUI Rose_Text;
    [SerializeField] private TextMeshProUGUI Sunflower_Text;
    [SerializeField] private TextMeshProUGUI Tulip_Text;
    [SerializeField] private TextMeshProUGUI Hydrangea_Text;
    [SerializeField] private TextMeshProUGUI Lotus_Text;
    [SerializeField] private TextMeshProUGUI Rice_Text;
    [SerializeField] private TextMeshProUGUI Tomato_Text;
    [SerializeField] private TextMeshProUGUI Corn_Text;
    [SerializeField] private TextMeshProUGUI Pineapple_Text;
    [SerializeField] private TextMeshProUGUI Eggplant_Text;

    private FlowerHUDC[] flHUDC;
    int text_number_Seed;
    void Start()
    {
        //ld = FindObjectsOfType<Land>();
        flHUDC = FindObjectsOfType<FlowerHUDC>();

    }

    void Update()
    {


        foreach (ListSeed listSeed in playerBag.instance.flowerName)
        {
            //Flower
            if (listSeed.name_seed == "Rose")
            {
                text_number_Seed = 0;
                Rose_Text.SetText(playerBag.instance.flowerName[text_number_Seed].number_seed.ToString());
            }

            if (listSeed.name_seed == "Sunflower")
            {
                text_number_Seed = 1;
                Sunflower_Text.SetText(playerBag.instance.flowerName[text_number_Seed].number_seed.ToString());
            }

            if (listSeed.name_seed == "Tulip")
            {
                text_number_Seed = 2;
                Tulip_Text.SetText(playerBag.instance.flowerName[text_number_Seed].number_seed.ToString());
            }

            if (listSeed.name_seed == "Hydrangea")
            {
                text_number_Seed = 3;
                Hydrangea_Text.SetText(playerBag.instance.flowerName[text_number_Seed].number_seed.ToString());
            }

            if (listSeed.name_seed == "Lotus")
            {
                text_number_Seed = 4;
                Lotus_Text.SetText(playerBag.instance.flowerName[text_number_Seed].number_seed.ToString());
            }

            if (listSeed.name_seed == "Rice")
            {
                text_number_Seed = 5;
                Rice_Text.SetText(playerBag.instance.flowerName[text_number_Seed].number_seed.ToString());
            }

            if (listSeed.name_seed == "Tomato")
            {
                text_number_Seed = 6;
                Tomato_Text.SetText(playerBag.instance.flowerName[text_number_Seed].number_seed.ToString());
            }

            if (listSeed.name_seed == "Corn")
            {
                text_number_Seed = 7;
                Corn_Text.SetText(playerBag.instance.flowerName[text_number_Seed].number_seed.ToString());
            }

            if (listSeed.name_seed == "Pineapple")
            {
                text_number_Seed = 8;
                Pineapple_Text.SetText(playerBag.instance.flowerName[text_number_Seed].number_seed.ToString());
            }

            if (listSeed.name_seed == "Eggplant")
            {
                text_number_Seed = 9;
                Eggplant_Text.SetText(playerBag.instance.flowerName[text_number_Seed].number_seed.ToString());
            }
        }

    }

}

        