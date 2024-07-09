using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float smoothing;
    Vector3 offset;
    float lowY;

    void Start()
    {
        offset = transform.position - player.position;
        lowY = transform.position.y;
    }


    void FixedUpdate()
    {
        Vector3 playerCamPos = player.position + offset;
        transform.position = Vector3.Lerp(transform.position, playerCamPos, smoothing * Time.deltaTime);
    }
}


