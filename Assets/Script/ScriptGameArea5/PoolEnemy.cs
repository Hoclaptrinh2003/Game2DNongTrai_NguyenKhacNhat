using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolEnemy : MonoBehaviour
{
    public List<GameObject> enemyPrefabs;
    public int poolSize = 10; 
    public static PoolEnemy instance;   
    private List<List<GameObject>> enemyPools; 
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
    }
    void Start()
    {
        enemyPools = new List<List<GameObject>>();

        foreach (GameObject enemyPrefab in enemyPrefabs)
        {
            List<GameObject> pool = new List<GameObject>();

            for (int i = 0; i < poolSize; i++)
            {
                GameObject enemy = Instantiate(enemyPrefab, transform); 
                enemy.SetActive(false);
                pool.Add(enemy);
            }

            enemyPools.Add(pool);
        }
    }

    public GameObject GetPooledEnemy(int enemyIndex)
    {
        if (enemyIndex < 0 || enemyIndex >= enemyPools.Count)
        {
            Debug.LogError("Lỗi: Index enemy không hợp lệ!");
            return null;
        }

        List<GameObject> pool = enemyPools[enemyIndex];

        foreach (GameObject enemy in pool)
        {
            if (!enemy.activeInHierarchy)
            {
                return enemy;
            }
        }

        GameObject newEnemy = Instantiate(enemyPrefabs[enemyIndex], transform);
        newEnemy.SetActive(false);
        pool.Add(newEnemy);
        return newEnemy;
    }

    public void ReturnToPool(GameObject enemy)
    {
        enemy.SetActive(false); 

       
        enemy.transform.position = transform.position;

        foreach (List<GameObject> pool in enemyPools)
        {
            if (pool.Contains(enemy))
            {
                return; 
            }
        }

    
        enemyPools[0].Add(enemy); 
    }
}
