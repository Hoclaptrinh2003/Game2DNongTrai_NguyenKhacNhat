using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationNPC : MonoBehaviour
{
    Animator aniNPC;
    public static AnimationNPC instance;

    private void Awake()
    {
      

        aniNPC = GetComponent<Animator>();
    }

    public void isNPCMoving()
    {
        aniNPC.SetBool("isMove", true);
    }

    public void isNPCIdle()
    {
        aniNPC.SetBool("isMove", false);
    }

    public void MoveXNPC(float moveXNPC)
    {
        aniNPC.SetFloat("MoveX", moveXNPC);
    }

    public void MoveYNPC(float moveYNPC)
    {
        aniNPC.SetFloat("MoveY", moveYNPC);
    }
}
