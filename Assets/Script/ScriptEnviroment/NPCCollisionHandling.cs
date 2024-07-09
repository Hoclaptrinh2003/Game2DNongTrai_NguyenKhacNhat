using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCCollisionHandling : MonoBehaviour
{
    AnimationNPC aniNPC;
    Rigidbody2D rbNPC;
    [SerializeField] private GameObject PigWall;

    private void Awake()
    {
        aniNPC= GetComponent<AnimationNPC>();
        rbNPC = GetComponent<Rigidbody2D>();

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
        if (collision.CompareTag("wall") )
        {
            aniNPC.isNPCIdle();
            PigWall.SetActive(true);
            rbNPC.velocity = Vector2.zero;
        }



    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("wall"))
        {
            PigWall.SetActive(true);
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        PigWall.SetActive(false);
    }
}
