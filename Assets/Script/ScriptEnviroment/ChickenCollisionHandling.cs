using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenCollisionHandling : MonoBehaviour
{
    private AnimationChicken aniChicken;  
    private Rigidbody2D rbChicken; 
    [SerializeField] private GameObject ChickenWall;  
    chickenGrowingTimeHUDC chickenGrowring;
    private void Awake()
    {
        aniChicken = GetComponent<AnimationChicken>(); 
        rbChicken = GetComponent<Rigidbody2D>();
        chickenGrowring = GetComponent<chickenGrowingTimeHUDC>();
    }

    private void Start()
    {
        ChickenWall.SetActive(false);  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pigsty") || collision.CompareTag("trough"))
        {
            aniChicken.IdleChicken();  
            ChickenWall.SetActive(true);  
            rbChicken.velocity = Vector2.zero; 
        }

        if (collision.CompareTag("trough") && chickenGrowring.TimeChickenGrowRun < chickenGrowring.TimeChickenToMature)
        {
            chickenGrowring.TimeChickenToMature -= 30;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
     
        if (collision.CompareTag("Pigsty") || collision.CompareTag("trough"))
        {
            ChickenWall.SetActive(true);  
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Pigsty") || collision.CompareTag("trough"))
        {
            ChickenWall.SetActive(false);  
        }
    }
}
