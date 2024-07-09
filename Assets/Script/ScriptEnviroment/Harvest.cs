using UnityEngine;
using System.Collections;
//using static UnityEditor.ShaderData;

public class Harvest : MonoBehaviour
{
    public Transform Warehouse_store;

    public float moveTime = 1f;

    void Start()
    {
    }

     public IEnumerator MoveToWarehouse(Vector3 targetPosition, float time)
    {
        Vector3 startPosition = transform.position;
        float time_past = 0f;

        while (time_past < time)
        {
            transform.position = Vector3.Lerp(startPosition, targetPosition, time_past / time);
            time_past += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPosition;
    }

    public void Warehouse_destination(Transform warehouse_destination)
    {
        Warehouse_store = warehouse_destination;
    }

    

    
}
