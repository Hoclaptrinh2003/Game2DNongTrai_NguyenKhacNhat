using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChicken : MonoBehaviour
{
    Animator aniChicken;
    void Start()
    {
        aniChicken = GetComponent<Animator>();
    }

    void Update()
    {
        
    }

    public void moveChicken()
    {
        aniChicken.SetBool("isMove",true);
    }

    public void IdleChicken()
    {
        aniChicken.SetBool("isMove", false);
    }
}
