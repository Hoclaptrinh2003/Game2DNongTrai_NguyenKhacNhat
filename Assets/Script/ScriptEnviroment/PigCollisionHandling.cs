using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigCollisionHandling : MonoBehaviour
{
    AnimationPig aniPig;
    Rigidbody2D rbPIG;
    [SerializeField] private GameObject PigWall;
    pigGrowingTimeHUDC pigGRowTime;
    private void Awake()
    {
       aniPig = GetComponent<AnimationPig>();
        rbPIG = GetComponent<Rigidbody2D>();
        pigGRowTime = GetComponent<pigGrowingTimeHUDC>();
    }

    private void Start()
    {
        PigWall.SetActive(false);
    }

    private void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pigsty") || collision.CompareTag("trough"))
        {
            aniPig.isPigIdle();
            PigWall.SetActive(true);
            rbPIG.velocity = Vector2.zero;
        }
        if (collision.CompareTag("trough") && pigGRowTime.TimepigGrowrun<pigGRowTime.TimepigToMature)
        {
            pigGRowTime.TimepigToMature -= 50;
        }
      

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Pigsty") || collision.CompareTag("trough"))
        {
            PigWall.SetActive(true);
        }

       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PigWall.SetActive(false);
    }
}
