using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class HarvestCollisionHandling : MonoBehaviour
{
    Harvest Hl;
    Plant pl;

    void Start()
    {
        Hl = GetComponent<Harvest>();
        pl = GetComponent<Plant>();

    }

    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Sickle") && pl.Flower_level2.activeSelf)
        {
            StartCoroutine(Hl.MoveToWarehouse(Hl.Warehouse_store.position, Hl.moveTime));
        }

        if (collision.CompareTag("wrhouse"))    
        {
           
            Destroy(gameObject);
        }
    }
}
