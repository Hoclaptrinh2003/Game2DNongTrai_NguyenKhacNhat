using UnityEngine;

public class FishController : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rbFish;
    AnimationFish aniFish;

    void Start()
    {
        rbFish = GetComponent<Rigidbody2D>();
        aniFish = GetComponent<AnimationFish>();
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
                aniFish.isFishIdle();
                break;
            case 1:
                aniFish.isFishMoving();
                aniFish.MoveXFish(1);
                aniFish.MoveYFish(0);
                forceDirection = Vector2.right;
                break;
            case 2:
                aniFish.isFishMoving();
                aniFish.MoveXFish(-1);
                aniFish.MoveYFish(0);
                forceDirection = -Vector2.right;
                break;
            case 3:
                aniFish.isFishMoving();
                aniFish.MoveXFish(0);
                aniFish.MoveYFish(1);
                forceDirection = Vector2.up;
                break;
            case 4:
                aniFish.isFishMoving();
                aniFish.MoveXFish(0);
                aniFish.MoveYFish(-1);
                forceDirection = -Vector2.up;
                break;
        }

        rbFish.velocity = forceDirection * moveSpeed;
    }


 
}
