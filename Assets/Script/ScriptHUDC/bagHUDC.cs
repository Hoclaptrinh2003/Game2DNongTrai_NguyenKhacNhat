using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bagHUDC : MonoBehaviour
{
    public GameObject BagSeedHUDC;
    public GameObject BagFertilizerHUDC;
    public GameObject bag_warehouse;
    public GameObject bag_ticket;
    public GameObject Game1HUDC;
    public GameObject wrTree;
    public GameObject DeleteTree;
    public GameObject AnimalFeed_Shop;
    public GameObject Fertilizer_Shop;
    public GameObject Tree_Shop;
    public GameObject onCamera;
    public GameObject offCamera;
    public GameObject miniCamera;
    public GameObject notEnoughmoney_img;
    public GameObject max_buy_img;
    public List<GameObject> Release;

    public bool isDestroy = false;

    int quantity;

    public static bagHUDC instance;
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

       BagSeedHUDC.SetActive(false);
       BagFertilizerHUDC.SetActive(false);
       bag_warehouse.transform.localScale = new Vector3(0, 0, 0);
       wrTree.SetActive(false);
       AnimalFeed_Shop.SetActive(false);
       Tree_Shop.SetActive(false);
       Fertilizer_Shop.SetActive(false);
       bag_ticket.SetActive(false);
        Game1HUDC.SetActive(false);

    }


    void Update()
    {
        if (DeleteTree.activeSelf)
        {
            isDestroy = true;
        }else if (!DeleteTree.activeSelf)
        {
            isDestroy = false;

        }
        
    
    }

    
    private void LateUpdate()
    {
        foreach (GameObject release in Release)
        {
            release.gameObject.SetActive(false);
        }
    }

    public void showbagSeed()
    {
        BagSeedHUDC.SetActive(true);
    }

    public void closebagSeed()
    {
        BagSeedHUDC.SetActive(false);

    }

    public void showbagFertilizer()
    {
        BagFertilizerHUDC.SetActive(true);
    }

    public void closebagFertilizer()
    {
        BagFertilizerHUDC.SetActive(false);

    }

    public void showGame1()
    {
       Game1HUDC.SetActive(true);
    }

    public void closeGame1()
    {
        Game1HUDC.SetActive(false);

    }

    public void showbagTicket()
    {
        bag_ticket.SetActive(true);
    }

    public void closebagTicket()
    {
        bag_ticket.SetActive(false);

    }
    public void showBag()
    {
        bag_warehouse.transform.localScale = new Vector3(16, 8, 0);

    }

    public void closeBag()
    {
        bag_warehouse.transform.localScale = new Vector3(0, 0, 0);
    }

    public void showShopFertilizer()
    {
        Fertilizer_Shop.SetActive(true);
    }

    public void closeShopFertilizer()
    {
        Fertilizer_Shop.SetActive(false);

    }

    public void showShopAnimal()
    {
        AnimalFeed_Shop.SetActive(true);

    }

    public void closeShopAnimal()
    {
        AnimalFeed_Shop.SetActive(false);
    }

    public void showShopTree()
    {
        Tree_Shop.SetActive(true);

    }

    public void closeShopTree()
    {
        Tree_Shop.SetActive(false);
    }


    



    public void showWrTree()
    {
        wrTree.SetActive(true);

    }

    public void closeWrTree()
    {
        wrTree.SetActive(false);
    }
    public void deleteTree()
    {

        Time.timeScale = 1;

        DeleteTree.SetActive(true);
        wrTree.SetActive(false);

    }

    public void noDeleteTre()
    {
        Time.timeScale = 1;

        DeleteTree.SetActive(false);
        wrTree.SetActive(false);
    }


    public void showMiniCamera()
    {
        onCamera.SetActive(false);
        offCamera.SetActive(true);
        miniCamera.SetActive(false);    
    }

    public void closeMiniCamera()
    {
        offCamera.SetActive(false);
        onCamera.SetActive(true);
        miniCamera.SetActive(true);
    }

    public void add_Quantity_flower()
    {
    if (Flower_ShopHUDC.instance.indexQuantity == 9)
        {
            Flower_ShopHUDC.instance.indexQuantity = -1;
        }
        Flower_ShopHUDC.instance.indexQuantity++;
    }

    public void add_Number_flower()
    {
        Flower_ShopHUDC.instance.number_quantity_Buy++;
        Flower_ShopHUDC.instance.input_quantity_Buy.text = Flower_ShopHUDC.instance.number_quantity_Buy.ToString();
    }

    public void reduce_Number_flower()
    {
        if (Flower_ShopHUDC.instance.number_quantity_Buy == 0)
        {
            return;
        }
        Flower_ShopHUDC.instance.number_quantity_Buy--;
        Flower_ShopHUDC.instance.input_quantity_Buy.text = Flower_ShopHUDC.instance.number_quantity_Buy.ToString();

    }

    private IEnumerator notEnoughmoney()
    {
        notEnoughmoney_img.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        notEnoughmoney_img.SetActive(false);
    }

    private IEnumerator maxBuyQuantity()
    {
        max_buy_img.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        max_buy_img.SetActive(false);
    }

    public void BuyFlowerSeed_byIndexQuantity()
    {
        if(GoldHUDC.instance.gold < Flower_ShopHUDC.instance.number_quantity_Buy * Flower_ShopHUDC.instance.cost_flower[Flower_ShopHUDC.instance.indexQuantity].cost)
        {
            StartCoroutine(notEnoughmoney());
            return;
        }
        playerBag.instance.flowerName[Flower_ShopHUDC.instance.indexQuantity].number_seed += Flower_ShopHUDC.instance.number_quantity_Buy;
        GoldHUDC.instance.Gold_text.SetText((GoldHUDC.instance.gold -= Flower_ShopHUDC.instance.number_quantity_Buy * Flower_ShopHUDC.instance.cost_flower[Flower_ShopHUDC.instance.indexQuantity].cost).ToString());
       
    }


    public void add_Quantity_Fertilizer()
    {
        if (FertilizeShopHUDC.instance.indexQuantity == 7)
        {
            FertilizeShopHUDC.instance.indexQuantity = -1;
        }
        FertilizeShopHUDC.instance.indexQuantity++;
    }


    public void BuyFertilizer_byIndexQuantity()
    {
        if (GoldHUDC.instance.gold < FertilizeShopHUDC.instance.number_quantity_Buy * FertilizeShopHUDC.instance.cost_fertilizer[FertilizeShopHUDC.instance.indexQuantity].cost)
        {
            StartCoroutine(notEnoughmoney());
            return;
        }
        playerBag.instance.fertilizerName[FertilizeShopHUDC.instance.indexQuantity].number_fertilizer += FertilizeShopHUDC.instance.number_quantity_Buy;
        GoldHUDC.instance.Gold_text.SetText((GoldHUDC.instance.gold -= FertilizeShopHUDC.instance.number_quantity_Buy * FertilizeShopHUDC.instance.cost_fertilizer[FertilizeShopHUDC.instance.indexQuantity].cost).ToString());

    }



    public void add_Number_Fertilizer()
    {
        FertilizeShopHUDC.instance.number_quantity_Buy++;
        FertilizeShopHUDC.instance.input_quantity_Buy.text = FertilizeShopHUDC.instance.number_quantity_Buy.ToString();
    }

    public void reduce_Number_Fertilizerr()
    {
        if (FertilizeShopHUDC.instance.number_quantity_Buy == 0)
        {
            return;
        }
        FertilizeShopHUDC.instance.number_quantity_Buy--;
        FertilizeShopHUDC.instance.input_quantity_Buy.text = FertilizeShopHUDC.instance.number_quantity_Buy.ToString();

    }











    public void BuyAnimal_byIndexQuantity()
    {
        foreach (GameObject release in Release)
        {
            release.gameObject.SetActive(true);
        }

        if (GoldHUDC.instance.gold < AnimalShopHUDC.instance.number_quantity_Buy * AnimalShopHUDC.instance.cost_animal[AnimalShopHUDC.instance.indexQuantity].cost)
        {
            StartCoroutine(notEnoughmoney());
            return;
        }

        if (pigRelease.instance.quantityOfPig == 8 && AnimalShopHUDC.instance.indexQuantity == 0)
        {
            StartCoroutine(maxBuyQuantity());


        }

        if (chickenRelease.instance.quantityOfChicken == 8 && AnimalShopHUDC.instance.indexQuantity == 1)
        {
            StartCoroutine(maxBuyQuantity());


        }

        if (fishRelease.instance.quantityOfFish  == 8 && AnimalShopHUDC.instance.indexQuantity == 2)
        {
            StartCoroutine(maxBuyQuantity());


        }

        if (AnimalShopHUDC.instance.indexQuantity == 0 && pigRelease.instance.quantityOfPig <8 && AnimalShopHUDC.instance.number_quantity_Buy >0)

        {
            GoldHUDC.instance.gold -= AnimalShopHUDC.instance.number_quantity_Buy * AnimalShopHUDC.instance.cost_animal[AnimalShopHUDC.instance.indexQuantity].cost;
          

            pigRelease.instance.OnMouseDown();

        }
        if (AnimalShopHUDC.instance.indexQuantity == 1 && chickenRelease.instance.quantityOfChicken < 8 && AnimalShopHUDC.instance.number_quantity_Buy > 0)
        {
            GoldHUDC.instance.gold -= AnimalShopHUDC.instance.number_quantity_Buy * AnimalShopHUDC.instance.cost_animal[AnimalShopHUDC.instance.indexQuantity].cost;
            chickenRelease.instance.OnMouseDown();

        }


        if (AnimalShopHUDC.instance.indexQuantity == 2 && fishRelease.instance.quantityOfFish < 8 && AnimalShopHUDC.instance.number_quantity_Buy > 0)
        {
            GoldHUDC.instance.gold -= AnimalShopHUDC.instance.number_quantity_Buy * AnimalShopHUDC.instance.cost_animal[AnimalShopHUDC.instance.indexQuantity].cost;
            fishRelease.instance.OnMouseDown();

        }

        if (AnimalShopHUDC.instance.indexQuantity == 3  && AnimalShopHUDC.instance.number_quantity_Buy > 0)
        {
            GoldHUDC.instance.gold -= AnimalShopHUDC.instance.number_quantity_Buy * AnimalShopHUDC.instance.cost_animal[AnimalShopHUDC.instance.indexQuantity].cost;
            WarehouseHUDC.instance.PigFeed_warehouseHUDC++;

        }


        if (AnimalShopHUDC.instance.indexQuantity == 4 && AnimalShopHUDC.instance.number_quantity_Buy > 0)
        {
            GoldHUDC.instance.gold -= AnimalShopHUDC.instance.number_quantity_Buy * AnimalShopHUDC.instance.cost_animal[AnimalShopHUDC.instance.indexQuantity].cost;
            WarehouseHUDC.instance.ChickenFeed_warehouseHUDC++;

        }

        if (AnimalShopHUDC.instance.indexQuantity == 5 && AnimalShopHUDC.instance.number_quantity_Buy > 0)
        {
            GoldHUDC.instance.gold -= AnimalShopHUDC.instance.number_quantity_Buy * AnimalShopHUDC.instance.cost_animal[AnimalShopHUDC.instance.indexQuantity].cost;
            WarehouseHUDC.instance.FishFeed_warehouseHUDC++;

        }

        GoldHUDC.instance.Gold_text.SetText(GoldHUDC.instance.gold.ToString());
    }

    public void add_QuantityAnimal()
    {
        if (AnimalShopHUDC.instance.indexQuantity == 5)
        {
            AnimalShopHUDC.instance.indexQuantity = -1;
        }
        AnimalShopHUDC.instance.indexQuantity++;
    }

    public void add_Number_animal()
    {
        AnimalShopHUDC.instance.number_quantity_Buy++;
        AnimalShopHUDC.instance.input_quantity_Buy.text = AnimalShopHUDC.instance.number_quantity_Buy.ToString();
    }

    public void reduce_Number_animal()
    {
        if (AnimalShopHUDC.instance.number_quantity_Buy == 0)
        {
            return;
        }
        AnimalShopHUDC.instance.number_quantity_Buy--;
        AnimalShopHUDC.instance.input_quantity_Buy.text = AnimalShopHUDC.instance.number_quantity_Buy.ToString();
    }


}
