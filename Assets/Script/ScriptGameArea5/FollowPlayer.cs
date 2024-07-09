using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public float followSpeed;
    
    void Update()
    {
       
            Vector3 targetPosition = Gamer.instance.transform.position;

            transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);
        
    }
}
