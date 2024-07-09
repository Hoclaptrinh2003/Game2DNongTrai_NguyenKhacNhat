using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class axeHUDC : MonoBehaviour
{
    public Texture2D axeCursor;
    public Button axeButton;
    public bool isAxeActive = false;

    private void Awake()
    {
        axeButton.onClick.AddListener(ToggleFertilizer);
    }

    private void Start()
    {
    }

    private void Update()
    {


        if (isAxeActive)
        {

           

            Cursor.SetCursor(axeCursor, Vector2.zero, CursorMode.Auto);
            bagHUDC.instance.BagFertilizerHUDC.SetActive(false);

            if (Input.GetMouseButtonDown(1))
            {
                HideFertilizer();
            }
        }
    }

    private void ToggleFertilizer()
    {
        if (isAxeActive)
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
        Cursor.SetCursor(axeCursor, Vector2.zero, CursorMode.Auto);
        isAxeActive = true;
    }

    private void HideFertilizer()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        isAxeActive = false;
    }
}
