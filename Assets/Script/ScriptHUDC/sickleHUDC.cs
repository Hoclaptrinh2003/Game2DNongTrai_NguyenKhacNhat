using UnityEngine;
using UnityEngine.UI;

public class sickleHUDC : MonoBehaviour
{
    public Texture2D sickleCursor;
    public Button sickleButton;
    public bool isSickleActive = false;
    public static sickleHUDC instance;
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

        sickleButton.onClick.AddListener(ToggleSickle);
    }

    private void Update()
    {
        if (isSickleActive)
        {
            Cursor.SetCursor(sickleCursor, Vector2.zero, CursorMode.Auto);

            if (Input.GetMouseButtonDown(1))
            {
                HideSickle();
            }
        }
    }

    private void ToggleSickle()
    {
        if (isSickleActive)
        {
            HideSickle();
        }
        else
        {
            ShowSickle();
        }
    }

    private void ShowSickle()
    {
        Cursor.SetCursor(sickleCursor, Vector2.zero, CursorMode.Auto);
        isSickleActive = true;
    }

    private void HideSickle()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        isSickleActive = false;
    }
}
