using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextSetting : MonoBehaviour
{

    private bool isShow;
    private TMP_Text text;

    private void Awake()
    {
        
        text = GetComponent<TMP_Text>();

    }

    private void Update()
    {

        if (isShow)
        {

            isShow = false;

        }
        else
        {

            text.text = "";

        }

    }

    public void SetText(string value)
    {

        text.text = value;
        isShow = true;

    }

}
