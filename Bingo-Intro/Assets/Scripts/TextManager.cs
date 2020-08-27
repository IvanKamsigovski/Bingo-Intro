using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Playables;

public class TextManager : MonoBehaviour
{
    public TMP_Text [] textArr;

    private void Awake()
    {
        if(SetText.setText.setBoll == true)
        {
            for (int i = 0; i < textArr.Length; i++)
            {
                textArr[i].text = SetText.setText.textList[i];
            }
        }  
    }
}
