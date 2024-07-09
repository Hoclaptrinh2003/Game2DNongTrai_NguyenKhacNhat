using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fertilizerHUDC : MonoBehaviour
{
    public Texture2D fertilizerCursor; 
    public Button fertilizerButton; 
    public GameObject fertilizer; 
    public bool isFertilizerActive = false; 
    public int index_fertilizer; 
    private receivingFertilizer[] rF;

    private void Awake()
    {
        fertilizerButton.onClick.AddListener(ToggleFertilizer); 
    }

    private void Start()
    {
    }

    private void Update()
    {
        rF = FindObjectsOfType<receivingFertilizer>();

        if (!bagHUDC.instance.BagFertilizerHUDC.activeSelf)
        {
            this.transform.localScale = new Vector3(0, 0, 0);
        }
        if (bagHUDC.instance.BagFertilizerHUDC.activeSelf)
        {
            this.transform.localScale = new Vector3(1f, 1f, 1f);

        }

        if (isFertilizerActive)
        {
            
            foreach (receivingFertilizer rF in rF)
            {
                rF.number_Fertiliz = index_fertilizer; 
            }
             
            Cursor.SetCursor(fertilizerCursor, Vector2.zero, CursorMode.Auto);
            bagHUDC.instance.BagFertilizerHUDC.SetActive(false);
         
            if (Input.GetMouseButtonDown(1))
            {
                HideFertilizer(); 
            }
        }
    }

    private void ToggleFertilizer()
    {
        if (isFertilizerActive)
        {
            HideFertilizer();
        }
        else
        {
            ShowFertilizer(); 
        }
    }

    private void ShowFertilizer()
    {
        Cursor.SetCursor(fertilizerCursor, Vector2.zero, CursorMode.Auto); 
        isFertilizerActive = true; 
    }

    private void HideFertilizer()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        isFertilizerActive = false; 
    }
}
