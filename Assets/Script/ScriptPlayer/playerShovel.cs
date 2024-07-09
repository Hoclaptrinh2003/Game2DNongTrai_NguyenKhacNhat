﻿using UnityEngine;

public class playerShovel : MonoBehaviour
{
    private Vector3 mousePosition;
    public static playerShovel instance;
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
    void Update()
    {
        Vector3 mouseScreenPosition = Input.mousePosition;

        mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(mouseScreenPosition.x, mouseScreenPosition.y, Mathf.Abs(Camera.main.transform.position.z)));

        transform.position = mousePosition;

      
    }
}
