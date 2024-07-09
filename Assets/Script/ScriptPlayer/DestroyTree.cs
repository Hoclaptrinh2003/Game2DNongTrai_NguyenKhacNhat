using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;


public class DestroyTree : MonoBehaviour
{

    public static DestroyTree instance;
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

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Rose"))
        {
                
         Destroy(collision.gameObject);

        }


        if (collision.CompareTag("Sunflower"))
        {

            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Rice"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Tulip"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Hydrangea"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Lotus"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Tomato"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Corn"))
        {
            Destroy(collision.gameObject);
        }


        if (collision.CompareTag("Pineapple"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Eggplant"))
        {
            Destroy(collision.gameObject);
        }

    }


}
