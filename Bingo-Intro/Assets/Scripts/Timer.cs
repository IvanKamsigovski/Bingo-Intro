using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public Slider slider;
    public TMP_Text timerText;

    float startingTime = 60f;
    float currentTime = 0f;

    void Start()
    {
        slider.maxValue = startingTime;
        currentTime = startingTime;
    }

    void Update()
    {
        CountDown();
    }

    void CountDown()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString("0");
        slider.value = currentTime;

        if(currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
