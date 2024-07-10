using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSence : MonoBehaviour
{

    public GameObject Player;
    public GameObject PlayerHUDC;
    public GameObject nothasTicket_img;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private IEnumerator nothasTicket()
    {
        nothasTicket_img.SetActive(true);
        yield return new WaitForSeconds(2f);
        nothasTicket_img.SetActive(false);
    }

    public void loadSence()
    {
        if(GameLoad.instance.numberTicket < 1)
        {
            StartCoroutine(nothasTicket());
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
