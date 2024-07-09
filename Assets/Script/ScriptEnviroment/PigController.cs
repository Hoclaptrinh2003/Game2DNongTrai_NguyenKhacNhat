using UnityEngine;

public class PigController : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rbPIG;
    AnimationPig aniPig;
    private void Awake()
    {
        
    }
    void Start()
    {
        rbPIG = GetComponent<Rigidbody2D>();
        aniPig = GetComponent<AnimationPig>();
        InvokeRepeating("MoveRandom", 0f, 4f);
    }

    private void MoveRandom()
    {
        int moveDirection = Random.Range(0, 5);

        Vector2 forceDirection = Vector2.zero;

        switch (moveDirection)
        {
            case 0:
                forceDirection = Vector2.zero;
                aniPig.isPigIdle();
                break;
            case 1:
                aniPig.isPigMoving();
                aniPig.MoveXPig(1);
                aniPig.MoveYPig(0);
                forceDirection = Vector2.right;
                break;
            case 2:
                aniPig.isPigMoving();
                aniPig.MoveXPig(-1);
                aniPig.MoveYPig(0);
                forceDirection = -Vector2.right;
                break;
            case 3:
                aniPig.isPigMoving();
                aniPig.MoveXPig(0);
                aniPig.MoveYPig(1);
                forceDirection = Vector2.up;
                break;
            case 4:
                aniPig.isPigMoving();
                aniPig.MoveXPig(0);
                aniPig.MoveYPig(-1);
                forceDirection = -Vector2.up;
                break;
        }

        rbPIG.velocity = forceDirection * moveSpeed;
    }
}
