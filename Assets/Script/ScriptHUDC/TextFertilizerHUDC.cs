using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextFertilizerHUDC : MonoBehaviour
{
    public static TextFertilizerHUDC instance;


    [SerializeField] private GameObject bag;
    [SerializeField] private TextMeshProUGUI FertilizerLevel1_Text;
    [SerializeField] private TextMeshProUGUI FertilizerLevel2_Text;
    [SerializeField] private TextMeshProUGUI FertilizerLevel3_Text;
    [SerializeField] private TextMeshProUGUI FertilizerLevel4_Text;
    [SerializeField] private TextMeshProUGUI FertilizerLevel5_Text;
    [SerializeField] private TextMeshProUGUI FertilizerLevel6_Text;
    [SerializeField] private TextMeshProUGUI FertilizerLevel7_Text;
    [SerializeField] private TextMeshProUGUI FertilizerLevel8_Text;

    private FlowerHUDC[] flHUDC;
    int text_number_Fertilizer;
    [SerializeField] private GameObject out_Fertilizer_img;
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        flHUDC = FindObjectsOfType<FlowerHUDC>();
    }


    public IEnumerator ShowOveroutFertilizer()
    {
        out_Fertilizer_img.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        out_Fertilizer_img.SetActive(false);
    }
    void Update()
    {
        foreach (ListFertilizer listFertilizer in playerBag.instance.fertilizerName)
        {
            if (listFertilizer.name_fertilizer == "FertilizerLevel1")
            {
                text_number_Fertilizer = 0;
                FertilizerLevel1_Text.SetText(playerBag.instance.fertilizerName[text_number_Fertilizer].number_fertilizer.ToString());
               
            }

            if (listFertilizer.name_fertilizer == "FertilizerLevel2")
            {
                text_number_Fertilizer = 1;
                FertilizerLevel2_Text.SetText(playerBag.instance.fertilizerName[text_number_Fertilizer].number_fertilizer.ToString());
            }

            if (listFertilizer.name_fertilizer == "FertilizerLevel3")
            {
                text_number_Fertilizer = 2;
                FertilizerLevel3_Text.SetText(playerBag.instance.fertilizerName[text_number_Fertilizer].number_fertilizer.ToString());
            }

            if (listFertilizer.name_fertilizer == "FertilizerLevel4")
            {
                text_number_Fertilizer = 3;
                FertilizerLevel4_Text.SetText(playerBag.instance.fertilizerName[text_number_Fertilizer].number_fertilizer.ToString());
            }

            if (listFertilizer.name_fertilizer == "FertilizerLevel5")
            {
                text_number_Fertilizer = 4;
                FertilizerLevel5_Text.SetText(playerBag.instance.fertilizerName[text_number_Fertilizer].number_fertilizer.ToString());
            }

            if (listFertilizer.name_fertilizer == "FertilizerLevel6")
            {
                text_number_Fertilizer = 5;
                FertilizerLevel6_Text.SetText(playerBag.instance.fertilizerName[text_number_Fertilizer].number_fertilizer.ToString());
            }

            if (listFertilizer.name_fertilizer == "FertilizerLevel7")
            {
                text_number_Fertilizer = 6;
                FertilizerLevel7_Text.SetText(playerBag.instance.fertilizerName[text_number_Fertilizer].number_fertilizer.ToString());
            }

            if (listFertilizer.name_fertilizer == "FertilizerLevel8")
            {
                text_number_Fertilizer = 7;
                FertilizerLevel8_Text.SetText(playerBag.instance.fertilizerName[text_number_Fertilizer].number_fertilizer.ToString());
            }
        }
    }
}
