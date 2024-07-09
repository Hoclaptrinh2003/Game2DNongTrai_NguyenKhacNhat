using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class Plant : MonoBehaviour
{
    public float timeFlowerSeed ;
    public float timeFlowering ;
    [SerializeField] private GameObject FlowerSeed;
    [SerializeField] private GameObject Flower_level1;
    public GameObject Flower_level2;
    public int indexImportToWarehouse;
    private float startTime;
    private bool isDestroytree;
    private void Start()
    {
        startTime = Time.time;

    }


    private void Update()
    {
        Flowering();

    }

    private void Flowering()
    {

        if (Time.time - startTime > timeFlowerSeed)
        {
            FlowerSeed.SetActive(false);
            Flower_level1.SetActive(true);
            Flower_level2.SetActive(false);
        }

        if (Time.time - startTime > timeFlowering)
        {
            FlowerSeed.SetActive(false);
            Flower_level1.SetActive(false);
            Flower_level2.SetActive(true);
        }
    }

 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Shovel") && (Time.time-startTime) / timeFlowering >= 0.5)
        {

            DestroyTree.instance.transform.position = transform.position;
            playerShovel.instance.transform.position = Player.instance.transform.position;
            shovelHUDC.instance.HideShovel();
            Time.timeScale = 0;
            bagHUDC.instance.showWrTree();

            if((Time.time - startTime) * 100 / timeFlowering < 100) 
            {
                treeWrHUDC.instance.number_treeWrHUDC = Mathf.Round((Time.time - startTime) * 100 / timeFlowering);

            }else if((Time.time - startTime) * 100 / timeFlowering >= 100)
            {
                treeWrHUDC.instance.number_treeWrHUDC = 100;
            }
            treeWrHUDC.instance.Text_treeWrHUDC.SetText(treeWrHUDC.instance.number_treeWrHUDC.ToString());

        }

        if (collision.CompareTag("destroytree"))
        {
            isDestroytree = true;
        }
    }
   
    private void OnDestroy()
    {
        bagHUDC.instance.DeleteTree.SetActive(false);

        if (isDestroytree ==  true)
        {
            return;
        }
        if (shovelHUDC.instance.isShovelActive == false ) 
        { 
           
            switch (indexImportToWarehouse)
            {

                case 0:
                WarehouseHUDC.instance.Rose_warehouseHUDC++;
                WarehouseHUDC.instance.Rose_Text_warehouseHUDC.SetText(WarehouseHUDC.instance.Rose_warehouseHUDC.ToString());
                break;

                case 1:
                WarehouseHUDC.instance.Sunflower_warehouseHUDC++;
                WarehouseHUDC.instance.Sunflower_Text_warehouseHUDC.SetText(WarehouseHUDC.instance.Sunflower_warehouseHUDC.ToString());
                break;

                case 2:
                WarehouseHUDC.instance.Tulip_warehouseHUDC++;
                WarehouseHUDC.instance.Tulip_Text_warehouseHUDC.SetText(WarehouseHUDC.instance.Tulip_warehouseHUDC.ToString());
                break;

                case 3:
                WarehouseHUDC.instance.Hydrangea_warehouseHUDC++;
                WarehouseHUDC.instance.Hydrangea_Text_warehouseHUDC.SetText(WarehouseHUDC.instance.Hydrangea_warehouseHUDC.ToString());
                break;

                case 4:
                WarehouseHUDC.instance.Lotus_warehouseHUDC++;
                WarehouseHUDC.instance.Lotus_Text_warehouseHUDC.SetText(WarehouseHUDC.instance.Lotus_warehouseHUDC.ToString());
                break;

                case 5:
                WarehouseHUDC.instance.Rice_warehouseHUDC++;
                WarehouseHUDC.instance.Rice_Text_warehouseHUDC.SetText(WarehouseHUDC.instance.Rice_warehouseHUDC.ToString());
                break;
                    
                case 6: 
                WarehouseHUDC.instance.Tomato_warehouseHUDC++;
                WarehouseHUDC.instance.Tomato_Text_warehouseHUDC.SetText(WarehouseHUDC.instance.Tomato_warehouseHUDC.ToString());
                break;

                case 7: 
                WarehouseHUDC.instance.Corn_warehouseHUDC++;
                WarehouseHUDC.instance.Corn_Text_warehouseHUDC.SetText(WarehouseHUDC.instance.Corn_warehouseHUDC.ToString());
                break;

                case 8: 
                WarehouseHUDC.instance.Pineapple_warehouseHUDC++;
                WarehouseHUDC.instance.Pineapple_Text_warehouseHUDC.SetText(WarehouseHUDC.instance.Pineapple_warehouseHUDC.ToString());
                break;

                case 9: 
                WarehouseHUDC.instance.Eggplant_warehouseHUDC++;
                WarehouseHUDC.instance.Eggplant_Text_warehouseHUDC.SetText(WarehouseHUDC.instance.Eggplant_warehouseHUDC.ToString());
                break;
            }
        }
    }

   
}

