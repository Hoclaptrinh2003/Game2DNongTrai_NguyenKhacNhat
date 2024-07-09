using UnityEngine;
using UnityEngine.UI;

public class shovelHUDC : MonoBehaviour
{
    public Texture2D shovelCursor;
    public Button shovelButton;
    public bool isShovelActive = false;
    public static shovelHUDC instance;

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

        shovelButton.onClick.AddListener(ToggleShovel);
    }

    private void Update()
    {
        if (isShovelActive)
        {
   
            Cursor.SetCursor(shovelCursor, Vector2.zero, CursorMode.Auto);


            if (Input.GetMouseButtonDown(1))
            {
                HideShovel();
            }

           
        }
    }

    private void ToggleShovel()
    {
        if (isShovelActive)
        {
            HideShovel();
        }
        else
        {
            ShowShovel();
        }
    }

    private void ShowShovel()
    {
        
        Cursor.SetCursor(shovelCursor, Vector2.zero, CursorMode.Auto);
        isShovelActive = true;
    }

    public void HideShovel()
    {
      
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        isShovelActive = false;
    }
}
