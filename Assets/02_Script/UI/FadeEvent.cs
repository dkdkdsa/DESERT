using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeEvent : MonoBehaviour
{

    private Image baseImage;

    private void Awake()
    {
        
        baseImage = GetComponent<Image>();

    }

}
