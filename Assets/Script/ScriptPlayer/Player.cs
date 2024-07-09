using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb2DPlayer;
    public static Player instance;

    private float speed = 6;
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
        rb2DPlayer = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {

    }

    void Update()
    {

    }

    private void FixedUpdate()
    {
        MovePlayer();

    }

    private void MovePlayer()
    {

        float inputMoveX = Input.GetAxis("Horizontal");
        float inputMoveY = Input.GetAxis("Vertical");
        Vector2 inputMove = new Vector2(inputMoveX*speed, inputMoveY*speed);
        rb2DPlayer.MovePosition(rb2DPlayer.position + inputMove * Time.fixedDeltaTime);


        if (inputMove.magnitude >0)
        {
            AnimationPlayer.instance.isPlayerMoving();
            AnimationPlayer.instance.MoveXPlayer(inputMove.x);
            AnimationPlayer.instance.MoveYPlayer(inputMove.y);
        }
        else
        {
            AnimationPlayer.instance.isPlayerIdle();

        }


    }
}
