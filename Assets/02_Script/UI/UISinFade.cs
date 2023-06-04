using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UISinFade : MonoBehaviour
{

    [SerializeField] private float fadeSpeed;

    private TMP_Text tmpText;

    private void Awake()
    {

        tmpText = GetComponent<TMP_Text>();

    }


    private void FixedUpdate()
    {


        tmpText.color = new Color(1, 1, 1, Mathf.Sin(Time.time * fadeSpeed) + 0.5f);

    }

}
