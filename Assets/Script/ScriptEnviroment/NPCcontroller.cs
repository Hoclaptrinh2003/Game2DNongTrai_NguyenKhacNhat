using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NPCcontroller : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rbNPC;
    AnimationNPC aniNPC;
    private void Awake()
    {
        rbNPC = GetComponent<Rigidbody2D>();
        aniNPC = GetComponent<AnimationNPC>();
    }

    void Start()
    {
        InvokeRepeating("MoveRandom", 0f, 10f);
    }

    private void MoveRandom()
    {
        int moveDirection = Random.Range(0, 5);

        Vector2 forceDirection = Vector2.zero;

        switch (moveDirection)
        {
            case 0:
                aniNPC.isNPCIdle(); 
                break;
            case 1:
                aniNPC.isNPCMoving();
                aniNPC.MoveXNPC(1); 
                forceDirection = Vector2.right;
                break;
            case 2:
                aniNPC.isNPCMoving();
                aniNPC.MoveXNPC(-1); 
                forceDirection = -Vector2.right;
                break;
            case 3:
                aniNPC.isNPCMoving(); 
                aniNPC.MoveYNPC(1); 
                forceDirection = Vector2.up;
                break;
            case 4:
                aniNPC.isNPCMoving(); 
                aniNPC.MoveYNPC(-1); 
                forceDirection = -Vector2.up;
                break;
        }

        rbNPC.velocity = forceDirection * moveSpeed;
    }
}
