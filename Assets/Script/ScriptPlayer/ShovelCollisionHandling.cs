using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShovelCollisionHandling : MonoBehaviour
{
    private void Start()
    {
        
    }
   
 
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Rose") && shovelHUDC.instance.isShovelActive == true)
        {  
         Destroy(collision.gameObject);   
        }


        if (collision.CompareTag("Sunflower") && shovelHUDC.instance.isShovelActive == true)
        {

            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Rice") && shovelHUDC.instance.isShovelActive == true)
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Tulip") && shovelHUDC.instance.isShovelActive == true)
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Hydrangea") && shovelHUDC.instance.isShovelActive == true)
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Lotus") && shovelHUDC.instance.isShovelActive == true)
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Tomato") && shovelHUDC.instance.isShovelActive == true)
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Corn") && shovelHUDC.instance.isShovelActive == true)
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Pineapple") && shovelHUDC.instance.isShovelActive == true)
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Eggplant") && shovelHUDC.instance.isShovelActive == true)
        {
            Destroy(collision.gameObject);
        }
    }
}
