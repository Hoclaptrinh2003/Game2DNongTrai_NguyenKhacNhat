using UnityEngine;
using UnityEngine.UI;

public class FlowerHUDC : MonoBehaviour
{
    public Texture2D flowerCursor;
    public Button flowerButton;
    public GameObject flower;
    public bool isFlowerActive = false;
    public int index_flower;
    private Land[] ld;

    private void Awake()
    {
        

        flowerButton.onClick.AddListener(ToggleFlower);
    }

    private void Start()
    {
        ld = FindObjectsOfType<Land>();

      
    }
    private void Update()
    {
        

        if (!bagHUDC.instance.BagSeedHUDC.activeSelf)
        {
           this.transform.localScale = new Vector3(0,0,0);
        }
        if (bagHUDC.instance.BagSeedHUDC.activeSelf)
        {
            this.transform.localScale = new Vector3(1f, 1f, 1f);

        }

       
        if (isFlowerActive )
        {

            foreach (Land LD in ld)
            {
                LD.indexSeed = index_flower;
            }
            Cursor.SetCursor(flowerCursor, Vector2.zero, CursorMode.Auto);
            bagHUDC.instance.BagSeedHUDC.SetActive(false);
            if (Input.GetMouseButtonDown(1))
            {
                HideFlower();
            }
        }
    }

    private void ToggleFlower()
    {
        if (isFlowerActive)
        {
            HideFlower();
        }
        else
        {
            ShowFlower();
        }
    }

    private void ShowFlower()
    {
        Cursor.SetCursor(flowerCursor, Vector2.zero, CursorMode.Auto);
        isFlowerActive = true;
    }

    private void HideFlower()
    {
        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
        isFlowerActive = false;
    }
}
