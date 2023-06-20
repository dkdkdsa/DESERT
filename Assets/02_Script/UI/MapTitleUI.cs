using DG.Tweening;
using FD.Dev;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MapTitleUI : MonoBehaviour
{

    private TMP_Text text;
    private AudioSource audioSource;

    private void Awake()
    {
        
        text = GetComponent<TMP_Text>();
        audioSource = GetComponent<AudioSource>();

    }

    public void ShowTitleUI(string title)
    {

        text.text = title;

        audioSource.Play();
        text.DOFade(1, 2).OnComplete(() =>
        {


            FAED.DelayInvoke(() =>
            {

                text.DOFade(0, 2);

            }, 1f);
            

        });

    }

}
