using UnityEngine;

public class Enemy : MonoBehaviour
{
    Animator aniEnemy;
    public string nameBool;
    private PoolEnemy pool; 

    void Start()
    {
        aniEnemy = GetComponent<Animator>();
        pool = FindObjectOfType<PoolEnemy>();
    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Gamer") || collision.CompareTag("bullet"))
        {
            aniEnemy.SetBool(nameBool, true);

            Invoke("ReturnToPool", 0.5f);
        }
    }

    private void ReturnToPool()
    {
        if (pool != null)
        {
            pool.ReturnToPool(gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }

        aniEnemy.SetBool(nameBool, false);
    }
}
