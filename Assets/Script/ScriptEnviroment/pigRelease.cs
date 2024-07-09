using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pigRelease : MonoBehaviour
{
    public GameObject Pig;
    public GameObject PIG;
    public Transform pigReleasePoint;
    public int quantityOfPig;
    public static pigRelease instance;
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
        if (PIG == null)
        {
            openPigSty();
        }

       
    }

    public void OnMouseDown()
    {
        if (quantityOfPig == 8)
        {
            return;
        }
        PIG = Instantiate(Pig, pigReleasePoint.position, pigReleasePoint.rotation);
        quantityOfPig++;
       
    }

    private void openPigSty()
    {

        foreach (GameObject pigsty in Pigsty.instance.pigsty)
        {
            pigsty.SetActive(true);
        }
    }
}
