using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Land : MonoBehaviour
{
    public List<GameObject> seeds_type; 
    private bool hasSeed = false;
    private GameObject flower;
    public int indexSeed;
    private FlowerHUDC[] flHUDC;

    [SerializeField] private GameObject out_Seed_img;
    public Transform warehouseTransform;

    private void Awake()
    {
        flHUDC = FindObjectsOfType<FlowerHUDC>();

    }
    private void Start()
    {
       
    }
    private void Update()
    {

        if (flower == null)
        {
            hasSeed = false;
        }


    }

    private IEnumerator ShowOverSeed()
    {
        out_Seed_img.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        out_Seed_img.SetActive(false);
    }

    private void OnMouseDown()
    {
       
        foreach (FlowerHUDC flHUDC in flHUDC) 
        {
            if (hasSeed == false && flHUDC.isFlowerActive ==true)
            {
                if (playerBag.instance.flowerName[indexSeed].number_seed <= 0)
                {
                    StartCoroutine(ShowOverSeed());
                    return;
                }

                flower = Instantiate(seeds_type[indexSeed], transform.position + new Vector3(0.2f, 0, -2f), transform.rotation);
                playerBag.instance.flowerName[indexSeed].number_seed--;
                flower.GetComponent<Harvest>().Warehouse_destination(warehouseTransform);

                hasSeed = true;

            }
        }
        

    }


  
}
