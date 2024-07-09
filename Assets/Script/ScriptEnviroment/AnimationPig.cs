using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPig : MonoBehaviour
{
    Animator aniPig;

    private void Awake()
    {

      
        aniPig = GetComponent<Animator>();
    }

    public void isPigMoving()
    {
        aniPig.SetBool("isMove", true);
    }

    public void isPigIdle()
    {
        aniPig.SetBool("isMove", false);
    }

    public void MoveXPig(float moveXPig)
    {
        aniPig.SetFloat("MoveX", moveXPig);
    }

    public void MoveYPig(float moveYPig)
    {
        aniPig.SetFloat("MoveY", moveYPig);
    }
}
