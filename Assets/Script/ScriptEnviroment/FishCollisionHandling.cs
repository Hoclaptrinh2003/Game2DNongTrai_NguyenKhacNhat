using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCollisionHandling : MonoBehaviour
{
    AnimationFish aniFish;
    Rigidbody2D rbFish;
    [SerializeField] private GameObject FishWall;
    fishGrowingTimeHUDC fishGrowingTimeHUDC;
    private void Awake()
    {
        aniFish = GetComponent<AnimationFish>();
        rbFish = GetComponent<Rigidbody2D>();
        fishGrowingTimeHUDC = GetComponent<fishGrowingTimeHUDC>();
    }

    private void Start()
    {
        FishWall.SetActive(false);
    }

    private void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lake") || collision.CompareTag("Pigsty") || collision.CompareTag("trough"))
        {
            aniFish.isFishIdle();
            FishWall.SetActive(true);
            rbFish.velocity = Vector2.zero;
        }

        if (collision.CompareTag("trough") && fishGrowingTimeHUDC.TimeFishGrowrun< fishGrowingTimeHUDC.TimeFishToMature)
        {
            fishGrowingTimeHUDC.TimeFishToMature -= 100;
        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Lake") || collision.CompareTag("Pigsty"))
        {
            FishWall.SetActive(true);
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        FishWall.SetActive(false);
    }
}
