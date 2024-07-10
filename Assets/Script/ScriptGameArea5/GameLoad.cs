using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLoad : MonoBehaviour
{
    public int numberTicket;
    public TextMeshProUGUI numberTicket_text;
    public static GameLoad instance;
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
        numberTicket_text.SetText(numberTicket.ToString());
    }
}
