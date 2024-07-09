using UnityEngine;

public class CreateEnemy : MonoBehaviour
{
  
    [SerializeField] private Transform createEnemyTransform; 
    [SerializeField] private float spawnInterval = 4f; 
    private float spawnTimer = 0f; 

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
   
    }

    void Update()
    {

    }

    private void SpawnEnemy()
    {
        int randomEnemyIndex = Random.Range(0, PoolEnemy.instance.enemyPrefabs.Count); 

      
        GameObject newEnemy = PoolEnemy.instance.GetPooledEnemy(randomEnemyIndex);

        if (newEnemy != null)
        {
           
            newEnemy.transform.position = createEnemyTransform.position;
            newEnemy.transform.rotation = createEnemyTransform.rotation;

         
            newEnemy.SetActive(true);
        }
    }
}
