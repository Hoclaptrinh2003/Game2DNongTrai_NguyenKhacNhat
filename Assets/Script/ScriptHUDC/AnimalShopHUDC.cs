using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AnimalShopHUDC : MonoBehaviour
{
    public int indexQuantity;
    public TMP_InputField input_quantity_Buy;
    public int number_quantity_Buy;
    public List<GameObject> image_Buy;
    public List<ListCost> cost_animal; 
    public static AnimalShopHUDC instance;
    public TextMeshProUGUI Cost_text;

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
    }

    void Update()
    {
        ImageBuy();
        number_quantity_Buy = int.Parse(input_quantity_Buy.text);
        Cost_text.SetText((number_quantity_Buy * cost_animal[indexQuantity].cost).ToString());
        // Gold_text.SetText(GoldHUDC.instance.gold.ToString());
        if(number_quantity_Buy > 1 || number_quantity_Buy <0) 
        {
            number_quantity_Buy = 1;
            input_quantity_Buy.text = number_quantity_Buy.ToString();   
        }
    }

    void ImageBuy()
    {
        if (indexQuantity >= 0 && indexQuantity < image_Buy.Count)
        {
            for (int i = 0; i < image_Buy.Count; i++)
            {
                image_Buy[indexQuantity].SetActive(true);

                if (i != indexQuantity)
                {
                    image_Buy[i].SetActive(false);
                }
            }
        }
    }
}
