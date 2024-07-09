using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DollarHUDC : MonoBehaviour
{
    public static DollarHUDC instance;
    public Texture2D dolarCursor;
    public Button dolarButton;
    public bool isDolarActive = false;
    public GameObject WrSellAnimalnotToMature_img;
    private bool isWrSellAnimalnotToMature_imgActive = true;

    private void Awake()
    {
        dolarButton.onClick.AddListener(ToggleDolar);
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

    private void Start()
    {
        WrSellAnimalnotToMature_img.SetActive(false);

    }

    private void Update()
    {

        if (isDolarActive)
        {
            Cursor.SetCursor(dolarCursor, Vector2.zero, CursorMode.Auto);
            if (isWrSellAnimalnotToMature_imgActive == true)
            {
                StartCoroutine(WrSellAnimalnotToMature());

            }
            isWrSellAnimalnotToMature_imgActive = false;

            if (Input.GetMouseButtonDown(1))
            {
                HideDolar();
            }
        }
    }
    private void LateUpdate()
    {
        if(isDolarActive == false)
        {
            isWrSellAnimalnotToMature_imgActive = true;

        }
    }

    public IEnumerator WrSellAnimalnotToMature()
    {
        WrSellAnimalnotToMature_img.SetActive(true);
        yield return new WaitForSeconds(6f);
        WrSellAnimalnotToMature_img.SetActive(false);
    }
    private void ToggleDolar()
    {
        if (isDolarActive)
        {
            HideDolar();
        }
        else
        {
            ShowDolar();
        }
    }

    private void ShowDolar()
    {
        Cursor.SetCursor(dolarCursor, Vector2.zero, CursorMode.Auto);
        isDolarActive = true;
    }

    private void HideDolar()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        isDolarActive = false;
    }



}
