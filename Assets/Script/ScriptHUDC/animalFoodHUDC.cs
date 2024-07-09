using System;
using UnityEngine;
using UnityEngine.UI;

public class animalFoodHUDC : MonoBehaviour
{
    public Texture2D animalCursor;
    public Button animalButton;
    public bool isAnimalActive = false;
    public int indexanimalFoodHUDC;
    private void Awake()
    {
        animalButton.onClick.AddListener(ToggleAnimal);
    }

    private void Start()
    {
    }

    private void Update()
    {
        
        if (isAnimalActive)
        {
            Cursor.SetCursor(animalCursor, Vector2.zero, CursorMode.Auto);
      

            if (Input.GetMouseButtonDown(1))
            {
                HideAnimal();
            }
        }
    }

    private void ToggleAnimal()
    {
        if (isAnimalActive)
        {
            HideAnimal();
        }
        else
        {
            ShowAnimal();
        }
    }

    private void ShowAnimal()
    {
        Cursor.SetCursor(animalCursor, Vector2.zero, CursorMode.Auto);
        isAnimalActive = true;
    }

    private void HideAnimal()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        isAnimalActive = false;
    }
}
