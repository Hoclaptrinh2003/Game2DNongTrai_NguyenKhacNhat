using UnityEngine;

public class ChickenController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rbChicken;
  private AnimationChicken aniChicken;

    private void Awake()
    {
        rbChicken = GetComponent<Rigidbody2D>();
       aniChicken = GetComponent<AnimationChicken>();
    }

    void Start()
    {
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
                aniChicken.IdleChicken();
                this.transform.localScale = new Vector3(3, 3, 1);
                break;
            case 1:
                aniChicken.moveChicken();
                this.transform.localScale = new Vector3(3, 3, 1);

                forceDirection = Vector2.right;
                break;
            case 2:
                aniChicken.moveChicken();
                this.transform.localScale = new Vector3(-3, 3, 1);
                forceDirection = -Vector2.right;
                break;
            case 3:
                aniChicken.moveChicken();
                this.transform.localScale = new Vector3(3, 3, 1);

                forceDirection = Vector2.up;
                break;
            case 4:
                aniChicken.moveChicken();
                this.transform.localScale = new Vector3(3, 3, 1);

                forceDirection = -Vector2.up;
                break;
        }

        rbChicken.velocity = forceDirection * moveSpeed;
    }
}
