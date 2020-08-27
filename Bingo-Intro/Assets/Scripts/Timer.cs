using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Playables;

public class Timer : MonoBehaviour
{
    public Slider slider;
    public TMP_Text timerText;
    public TMP_Text lastSecText;
    public GameObject countDownHolder;
    public GameObject timerAnimation;
    public GameObject endCanvas;
    public PlayableDirector playableDirector;

    float startingTime = 60f;
    float currentTime = 0f;
    bool countdownActivator;
    bool endCnavasBool;

    void Start()
    {
        slider.maxValue = startingTime;
        currentTime = startingTime;
        countdownActivator = false;
        endCnavasBool = false;
    }

    void Update()
    {
        countDown();
        countDownHolder.SetActive(countdownActivator);
        endCanvas.SetActive(endCnavasBool);
    }

    void countDown()
    {
        currentTime -= 1 * Time.deltaTime;
        timerText.text = currentTime.ToString("0");
        slider.value = currentTime;

        
        if(currentTime <= 10)
        {
            lastSecText.text = currentTime.ToString("0");
            countdownActivator = true;
            playableDirector.Play();
        }
        if(currentTime <= 0)
        {
            currentTime = 0;
            playableDirector.Stop();
            countdownActivator = false;
            timerAnimation.SetActive(false);
            endCnavasBool = true;
        }

    }



}
