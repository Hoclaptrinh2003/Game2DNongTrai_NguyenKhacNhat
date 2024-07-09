
using UnityEngine;

public class pocketHUDC : MonoBehaviour
{
    [SerializeField] private GameObject pocket;
    private bool isPocketOpen = false;
    [SerializeField] private GameObject Player_shovel;
    [SerializeField] private GameObject Player_sickle;

    void Awake()
    {
   

    }

    void Update()
    {
     
        if (Input.GetKeyDown(KeyCode.G))
        {
           
            if (isPocketOpen==true)
            {
                pocket.SetActive(false);
                isPocketOpen = false;
            }
       
            else if(isPocketOpen == false)
            {
              
                pocket.SetActive(true);
                isPocketOpen = true;
            }
           
        }

        
        if (shovelHUDC.instance.isShovelActive == true)
        {
            Player_shovel.SetActive(true);

        }

        if (shovelHUDC.instance.isShovelActive == false)
        {
            Player_shovel.SetActive(false);

        }

        if (sickleHUDC.instance.isSickleActive == true)
        {
            Player_sickle.SetActive(true);

        }

        if (sickleHUDC.instance.isSickleActive == false)
        {
            Player_sickle.SetActive(false);

        }
    

    }
}
