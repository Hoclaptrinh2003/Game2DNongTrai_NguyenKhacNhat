using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    public static BulletPool Instance; 

    public List<GameObject> bulletPrefabs; 
    public int poolSize = 10; 
    private List<List<GameObject>> objectPool; 

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        InitializeObjectPool();
    }

    void InitializeObjectPool()
    {
        objectPool = new List<List<GameObject>>();

        foreach (GameObject bulletPrefab in bulletPrefabs)
        {
            List<GameObject> bulletPool = new List<GameObject>();

            for (int i = 0; i < poolSize; i++)
            {
                GameObject bullet = Instantiate(bulletPrefab, transform); 
                bullet.SetActive(false);
                bulletPool.Add(bullet);
            }

            objectPool.Add(bulletPool);
        }
    }

    public GameObject GetBullet(int index)
    {
        if (index < 0 || index >= objectPool.Count)
        {
            return null;
        }


        List<GameObject> currentPool = objectPool[index];

      
        foreach (GameObject bullet in currentPool)
        {
            if (!bullet.activeSelf) 
            {
                bullet.SetActive(true); 
                return bullet;
            }
        }

        GameObject newBullet = Instantiate(bulletPrefabs[index], transform); 
        newBullet.SetActive(false);
        currentPool.Add(newBullet);
        return newBullet;
    }

    public void ReturnBullet(GameObject bullet)
    {
        bullet.SetActive(false); 
    }
}
