using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public Slider slider;
    public TMP_Text timerText;
    public TMP_Text lastSecText;
    public GameObject countDownHolder;

    float startingTime = 60f;
    float currentTime = 0f;

    void Start()
    {
        slider.maxValue = startingTime;
        currentTime = startingTime;
        countDownHolder.SetActive(false);
    }

    void Update()
    {
        countDown();
    }

    void countDown()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString("0");
        slider.value = currentTime;

        if(currentTime <= 0)
        {
            currentTime = 0;
        }

        if(currentTime <= 10)
        {
            lastSecText.text = currentTime.ToString("0");
            countDownHolder.SetActive(true);
        }
    }

}
