using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public int indexBulletPrefab;
    public Transform handFire; 

    private float fireRate = 1.5f; 
    private float nextFire = 0f; 
    private GameObject currentBullet; 

    void Start()
    {
        InvokeRepeating("RandomIndexBulletPrefab", 0f, 2f);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.time > nextFire)
        {
            nextFire = Time.time + 1f / fireRate;

            Vector3 fireDirection = handFire.right;

            if (currentBullet != null && currentBullet.activeSelf)
            {
                StartCoroutine(ReturnBulletAfterDelay(currentBullet, 2f));
                currentBullet = null; 
            }

            currentBullet = BulletPool.Instance.GetBullet(indexBulletPrefab);

            if (currentBullet != null)
            {
                currentBullet.transform.position = handFire.position;
                currentBullet.transform.rotation = Quaternion.identity; 

                currentBullet.SetActive(true);

                   StartCoroutine(ReturnBulletAfterTime(currentBullet, 2f));

                Rigidbody2D rbBullet = currentBullet.GetComponent<Rigidbody2D>();

                rbBullet.velocity = fireDirection * 20f;
            }
        }
      
    }

    private void RandomIndexBulletPrefab()
    {
        indexBulletPrefab = Random.Range(0, BulletPool.Instance.bulletPrefabs.Count);
    }

    private IEnumerator ReturnBulletAfterDelay(GameObject bullet, float delay)
    {
        yield return new WaitForSeconds(delay);
        BulletPool.Instance.ReturnBullet(bullet);
    }

    private IEnumerator ReturnBulletAfterTime(GameObject bullet, float time)
    {
        yield return new WaitForSeconds(time);

        if (bullet != null && bullet.activeSelf)
        {
            BulletPool.Instance.ReturnBullet(bullet);
        }
    }
}
