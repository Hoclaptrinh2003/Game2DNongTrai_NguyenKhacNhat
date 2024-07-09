using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationFish : MonoBehaviour
{
    Animator aniFish;

    private void Awake()
    {
        aniFish = GetComponent<Animator>();
    }

    public void isFishMoving()
    {
        aniFish.SetBool("isMove", true);
    }

    public void isFishIdle()
    {
        aniFish.SetBool("isMove", false);
    }

    public void MoveXFish(float moveXFish)
    {
        aniFish.SetFloat("MoveX", moveXFish);
    }

    public void MoveYFish(float moveYFish)
    {
        aniFish.SetFloat("MoveY", moveYFish);
    }
}
