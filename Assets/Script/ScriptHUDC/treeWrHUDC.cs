using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class treeWrHUDC : MonoBehaviour
{
    public static treeWrHUDC instance;

    public TextMeshProUGUI Text_treeWrHUDC;
    public float number_treeWrHUDC;

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
}
