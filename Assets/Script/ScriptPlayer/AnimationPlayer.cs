using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPlayer : MonoBehaviour
{
    Animator aniPlayer;
    public static AnimationPlayer instance;

    private void Awake()
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


        aniPlayer = GetComponent<Animator>();
    }
    
    public void isPlayerMoving()
    {
        aniPlayer.SetBool("isMove", true);
    }
    
    public void isPlayerIdle()
    {
        aniPlayer.SetBool("isMove", false);
    }

    public void MoveXPlayer(float moveXPlayer)
    {
        aniPlayer.SetFloat("MoveX", moveXPlayer);
    }

    public void MoveYPlayer(float moveYPlayer)
    {
        aniPlayer.SetFloat("MoveY", moveYPlayer);
    }
}
