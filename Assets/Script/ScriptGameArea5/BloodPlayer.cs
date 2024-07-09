using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloodPlayer : MonoBehaviour
{
    public Slider PlayerSlider;
    public int blood = 150;
    void Start()
    {
        PlayerSlider.maxValue = blood;
        PlayerSlider.value = PlayerSlider.maxValue;
    }

    void Update()
    {
        PlayerSlider.value = blood; ;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            blood -= 2;
        }
    }
}
