using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chickenRelease : MonoBehaviour
{
    public GameObject Chicken;  
    public GameObject CHICKEN;  
    public Transform chickenReleasePoint;  
    public int quantityOfChicken;  
    public static chickenRelease instance; 

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

    void Update()
    {
       
    }

    public void OnMouseDown()
    {
        if (quantityOfChicken == 8)
        {
            return;  
        }
        CHICKEN = Instantiate(Chicken, chickenReleasePoint.position, chickenReleasePoint.rotation);
        quantityOfChicken++;  
    }

  
}
