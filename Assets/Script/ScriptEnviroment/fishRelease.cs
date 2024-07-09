using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishRelease : MonoBehaviour
{
    public GameObject Fish;
    public GameObject FISH;
    public Transform fishReleasePoint;
    public int quantityOfFish;
    public static fishRelease instance;

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

    }

    public void OnMouseDown()
    {
        if (quantityOfFish == 8)
        {
            return;
        }
        FISH = Instantiate(Fish, fishReleasePoint.position, fishReleasePoint.rotation);
        quantityOfFish++;
    }
}
