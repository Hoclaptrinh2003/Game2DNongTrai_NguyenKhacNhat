using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Pigsty : MonoBehaviour
{
    public List<GameObject> pigsty;
    public static Pigsty instance;
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
    void Start()
    {
        foreach (GameObject pigsty in pigsty) 
        { 
            pigsty.SetActive(true);
        }
    }

    void Update()
    {
        
    }
}
