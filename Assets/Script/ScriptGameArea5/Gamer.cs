using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamer : MonoBehaviour
{
    Rigidbody2D rb2DCharacter;
    public static Gamer instance; // Instance của class
    AnimationNPC aniNPC;

    private float speed = 5; // Tốc độ di chuyển của nhân vật

    void Awake()
    {
        aniNPC = GetComponent<AnimationNPC>();


        rb2DCharacter = GetComponent<Rigidbody2D>();

        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void FixedUpdate()
    {
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        // Lấy input từ bàn phím
        float inputMoveX = Input.GetAxis("Horizontal");
        float inputMoveY = Input.GetAxis("Vertical");
        Vector2 inputMove = new Vector2(inputMoveX * speed, inputMoveY * speed);

        // Di chuyển nhân vật bằng Rigidbody2D
        rb2DCharacter.MovePosition(rb2DCharacter.position + inputMove * Time.fixedDeltaTime);

        // Xử lý animation dựa trên input di chuyển
        if (inputMove.magnitude > 0)
        {
            aniNPC.isNPCMoving(); // Gọi phương thức isNPCMoving của AnimationNPC
            aniNPC.MoveXNPC(inputMove.x); // Đặt giá trị MoveXNPC trong AnimationNPC
            aniNPC.MoveYNPC(inputMove.y); // Đặt giá trị MoveYNPC trong AnimationNPC
        }
        else
        {
            aniNPC.isNPCIdle();
        }
    }
}
