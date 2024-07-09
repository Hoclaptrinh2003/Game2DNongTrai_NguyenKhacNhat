using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WarehouseHUDC : MonoBehaviour
{
    public static WarehouseHUDC instance;



    public int Rose_warehouseHUDC;
    public int Sunflower_warehouseHUDC;
    public int Tulip_warehouseHUDC;
    public int Hydrangea_warehouseHUDC;
    public int Lotus_warehouseHUDC;
    public int Rice_warehouseHUDC;
    public int Tomato_warehouseHUDC;
    public int Corn_warehouseHUDC;
    public int Pineapple_warehouseHUDC;
    public int Eggplant_warehouseHUDC;
    public int PigFeed_warehouseHUDC;
    public int ChickenFeed_warehouseHUDC;
    public int FishFeed_warehouseHUDC;
    public int WoodFeed_warehouseHUDC;
    public int GoldFeed_warehouseHUDC;
    public int Diamond_warehouseHUDC;

    public TextMeshProUGUI Rose_Text_warehouseHUDC;
    public TextMeshProUGUI Sunflower_Text_warehouseHUDC;
    public TextMeshProUGUI Tulip_Text_warehouseHUDC;
    public TextMeshProUGUI Hydrangea_Text_warehouseHUDC;
    public TextMeshProUGUI Lotus_Text_warehouseHUDC;
    public TextMeshProUGUI Rice_Text_warehouseHUDC;
    public TextMeshProUGUI Tomato_Text_warehouseHUDC;   
    public TextMeshProUGUI Corn_Text_warehouseHUDC;    
    public TextMeshProUGUI Pineapple_Text_warehouseHUDC; 
    public TextMeshProUGUI Eggplant_Text_warehouseHUDC;
    public TextMeshProUGUI PigFeed_Text_warehouseHUDC;
    public TextMeshProUGUI ChickenFeed_Text_warehouseHUDC;
    public TextMeshProUGUI FishFeed_Text_warehouseHUDC;
    public TextMeshProUGUI WoodFeed_Text_warehouseHUDC;
    public TextMeshProUGUI GoldFeed_Text_warehouseHUDC;
    public TextMeshProUGUI Diamond_Text_warehouseHUDC;

    public GameObject Rose_warehouse;
    public GameObject Sunflower_warehouse;
    public GameObject Tulip_warehouse;
    public GameObject Hydrangea_warehouse;
    public GameObject Lotus_warehouse;
    public GameObject Rice_warehouse;
    public GameObject Tomato_warehouse;    
    public GameObject Corn_warehouse;      
    public GameObject Pineapple_warehouse; 
    public GameObject Eggplant_warehouse;
    public GameObject PigFeed_warehouse;
    public GameObject ChickenFeed_warehouse;
    public GameObject FishFeed_warehouse;
    public GameObject WoodFeed_warehouse;
    public GameObject GoldFeed_warehouse;
    public GameObject Diamond_warehouse;

    void Awake()
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

    private void Start()
    {
        Rose_Text_warehouseHUDC.SetText(Rose_warehouseHUDC.ToString());
        Sunflower_Text_warehouseHUDC.SetText(Sunflower_warehouseHUDC.ToString());
        Tulip_Text_warehouseHUDC.SetText(Tulip_warehouseHUDC.ToString());
        Hydrangea_Text_warehouseHUDC.SetText(Hydrangea_warehouseHUDC.ToString());
        Lotus_Text_warehouseHUDC.SetText(Lotus_warehouseHUDC.ToString());
        Rice_Text_warehouseHUDC.SetText(Rice_warehouseHUDC.ToString());
        Tomato_Text_warehouseHUDC.SetText(Tomato_warehouseHUDC.ToString());
        Corn_Text_warehouseHUDC.SetText(Corn_warehouseHUDC.ToString());
        Pineapple_Text_warehouseHUDC.SetText(Pineapple_warehouseHUDC.ToString());
        Eggplant_Text_warehouseHUDC.SetText(Eggplant_warehouseHUDC.ToString());
        PigFeed_Text_warehouseHUDC.SetText(PigFeed_warehouseHUDC.ToString());
        ChickenFeed_Text_warehouseHUDC.SetText(ChickenFeed_warehouseHUDC.ToString());
        FishFeed_Text_warehouseHUDC.SetText(FishFeed_warehouseHUDC.ToString());
        WoodFeed_Text_warehouseHUDC.SetText(WoodFeed_warehouseHUDC.ToString());
        GoldFeed_Text_warehouseHUDC.SetText(GoldFeed_warehouseHUDC.ToString());
        Diamond_Text_warehouseHUDC.SetText(Diamond_warehouseHUDC.ToString());

}

    void Update()
    {
        checklocalScaleWarehouse();
        Rose_Text_warehouseHUDC.SetText(Rose_warehouseHUDC.ToString());
        Sunflower_Text_warehouseHUDC.SetText(Sunflower_warehouseHUDC.ToString());
        Tulip_Text_warehouseHUDC.SetText(Tulip_warehouseHUDC.ToString());
        Hydrangea_Text_warehouseHUDC.SetText(Hydrangea_warehouseHUDC.ToString());
        Lotus_Text_warehouseHUDC.SetText(Lotus_warehouseHUDC.ToString());
        Rice_Text_warehouseHUDC.SetText(Rice_warehouseHUDC.ToString());
        Tomato_Text_warehouseHUDC.SetText(Tomato_warehouseHUDC.ToString());
        Corn_Text_warehouseHUDC.SetText(Corn_warehouseHUDC.ToString());
        Pineapple_Text_warehouseHUDC.SetText(Pineapple_warehouseHUDC.ToString());
        Eggplant_Text_warehouseHUDC.SetText(Eggplant_warehouseHUDC.ToString());
        PigFeed_Text_warehouseHUDC.SetText(PigFeed_warehouseHUDC.ToString());
        ChickenFeed_Text_warehouseHUDC.SetText(ChickenFeed_warehouseHUDC.ToString());
        FishFeed_Text_warehouseHUDC.SetText(FishFeed_warehouseHUDC.ToString());


    }

    private void checklocalScaleWarehouse()
    {
        Vector3 theScaleSmall = new Vector3(0, 0, 0);
        Vector3 theScaleBig = new Vector3(16, 8, 0);
        if (this.transform.localScale == theScaleBig)
        {

            Rose_warehouse.transform.localScale = theScaleBig;
            Sunflower_warehouse.transform.localScale = theScaleBig;
            Tulip_warehouse.transform.localScale = theScaleBig;
            Hydrangea_warehouse.transform.localScale = theScaleBig;
            Lotus_warehouse.transform.localScale = theScaleBig;
            Rice_warehouse.transform.localScale = theScaleBig;
            Tomato_warehouse.transform.localScale = theScaleBig;
            Corn_warehouse.transform.localScale = theScaleBig;
            Pineapple_warehouse.transform.localScale = theScaleBig;
            Eggplant_warehouse.transform.localScale = theScaleBig;
            PigFeed_warehouse.transform.localScale = theScaleBig;
            ChickenFeed_warehouse.transform.localScale = theScaleBig;
            FishFeed_warehouse.transform.localScale = theScaleBig;
            WoodFeed_warehouse.transform.localScale = theScaleBig;
            GoldFeed_warehouse.transform.localScale = theScaleBig;
            Diamond_warehouse.transform.localScale = theScaleBig;
}
      
        if (this.transform.localScale ==  theScaleSmall)
        {
            Rose_warehouse.transform.localScale = theScaleSmall;
            Sunflower_warehouse.transform.localScale = theScaleSmall;
            Tulip_warehouse.transform.localScale = theScaleSmall;
            Hydrangea_warehouse.transform.localScale = theScaleSmall;
            Lotus_warehouse.transform.localScale = theScaleSmall;
            Rice_warehouse.transform.localScale = theScaleSmall;
            Tomato_warehouse.transform.localScale = theScaleSmall;
            Corn_warehouse.transform.localScale = theScaleSmall;
            Pineapple_warehouse.transform.localScale = theScaleSmall;
            Eggplant_warehouse.transform.localScale = theScaleSmall;
            PigFeed_warehouse.transform.localScale = theScaleSmall;
            ChickenFeed_warehouse.transform.localScale = theScaleSmall;
            FishFeed_warehouse.transform.localScale = theScaleSmall;
            WoodFeed_warehouse.transform.localScale = theScaleSmall;
            GoldFeed_warehouse.transform.localScale = theScaleSmall;
            Diamond_warehouse.transform.localScale = theScaleSmall;
        }
        
      
    }
}
