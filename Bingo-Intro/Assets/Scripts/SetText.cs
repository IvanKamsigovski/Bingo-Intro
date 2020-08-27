using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetText : MonoBehaviour
{
    public static SetText setText;
    public TMP_InputField [] textInput;
    public List<string> textList = new List<string>();

    public string  topText;
    public string midleText;
    public string bottomText1;
    public string bottomText2;
    public string bottomText3;

    public bool setBoll;


    private void Awake()
    {
        textList.Add(topText);
        textList.Add(midleText);
        textList.Add(bottomText1);
        textList.Add(bottomText2);
        textList.Add(bottomText3);

        setBoll = false;
        if (setText == null)
        {
            setText = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }
    public void Submit()
    {
        setBoll = true;

        for (int i = 0; i < textInput.Length; i++)
        {
            textList[i] = textInput[i].text;
        }
    }

}
