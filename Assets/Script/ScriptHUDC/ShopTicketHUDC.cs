using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopTicketHUDC : MonoBehaviour
{
    public int indexQuantity;
    public TMP_InputField input_quantity_Buy;
    public int number_quantity_Buy;
    public List<GameObject> image_Buy;
    public List<ListCost> cost_ticket; 
    public static ShopTicketHUDC instance;
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
        Cost_text.SetText((number_quantity_Buy * cost_ticket[indexQuantity].cost).ToString());

       
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
