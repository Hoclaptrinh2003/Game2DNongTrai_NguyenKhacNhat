using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LossGame : MonoBehaviour
{
    BloodPlayer bloodPlayer;
    void Start()
    {
        bloodPlayer = GetComponent<BloodPlayer>();
    }


    void Update()
    {
        if(bloodPlayer.blood == 0)
        {
            SceneManager.LoadScene("MainGame");
        }
    }
}
