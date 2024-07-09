using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Trough : MonoBehaviour
{
    [SerializeField] private GameObject  AniamlTrough;
    animalFoodHUDC[] aniFoodHUDC;
    public int indexTrough;
    [SerializeField] private int QuantityFoodAniaml;
    [SerializeField] private GameObject notFoodAnimal_img;



    void Start()
    {
        aniFoodHUDC = FindObjectsOfType<animalFoodHUDC>();
    }

    void Update()
    {
        switch (indexTrough)
        {
            case 0:
                QuantityFoodAniaml = WarehouseHUDC.instance.PigFeed_warehouseHUDC;
                break;
            case 1:
                QuantityFoodAniaml = WarehouseHUDC.instance.ChickenFeed_warehouseHUDC;
                break;
            case 2:
                QuantityFoodAniaml = WarehouseHUDC.instance.FishFeed_warehouseHUDC;
                break;
            default:
                break;
        }
    }

    private IEnumerator notFood()
    {
        notFoodAnimal_img.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        notFoodAnimal_img.SetActive(false);
    }
    private void OnMouseDown()
    {
        foreach(animalFoodHUDC aniFoodHUDC in aniFoodHUDC)
        {
            if (QuantityFoodAniaml <= 0 && aniFoodHUDC.isAnimalActive == true && aniFoodHUDC.indexanimalFoodHUDC == indexTrough) 
            {
                StartCoroutine(notFood());
                return; 
            }
            if(aniFoodHUDC.indexanimalFoodHUDC == indexTrough && aniFoodHUDC.isAnimalActive == true && QuantityFoodAniaml>0  ) 
            {

                AniamlTrough.SetActive(true);

                switch (indexTrough)
                {
                    case 0:
                        WarehouseHUDC.instance.PigFeed_warehouseHUDC--;
                        break;
                    case 1:
                        WarehouseHUDC.instance.ChickenFeed_warehouseHUDC--;
                        break;
                    case 2:
                        WarehouseHUDC.instance.FishFeed_warehouseHUDC--;
                        break;
                    default:
                        break;
                }
                gameObject.SetActive(false);

            }
        }
      



    }
}
