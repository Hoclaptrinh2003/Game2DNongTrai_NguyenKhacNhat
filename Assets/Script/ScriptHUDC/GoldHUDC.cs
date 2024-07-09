using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldHUDC : MonoBehaviour
{
    public static GoldHUDC instance;
    public int gold = 1000;
    public TextMeshProUGUI Gold_text;

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
        Gold_text.SetText(gold.ToString());
    }
}
