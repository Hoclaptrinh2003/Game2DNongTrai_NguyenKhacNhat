using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSence : MonoBehaviour
{

    public GameObject Player;
    public GameObject PlayerHUDC;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    


    
    public void loadSence()
    {
        if(GameLoad.instance.numberTicket < 1)
        {
            StartCoroutine(bagHUDC.instance.nothasTicket());
        }
        if(GameLoad.instance.numberTicket>=1) 
        {
            GameLoad.instance.numberTicket--;
            Player.SetActive(false);
            PlayerHUDC.SetActive(false);    
            SceneManager.LoadScene("Game1");
        }
    }
}
