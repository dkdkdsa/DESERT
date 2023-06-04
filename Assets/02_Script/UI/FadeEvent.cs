using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.Events;

public class FadeEvent : MonoBehaviour
{

    [SerializeField] private float fadeDuration;
    [SerializeField] private UnityEvent fadeInEndEvt, fadeOutEndEvt;

    private Image baseImage;

    private void Awake()
    {
        
        baseImage = GetComponent<Image>();

    }

    public void FadeIn()
    {

        baseImage.DOFade(1, fadeDuration).OnComplete(() => fadeInEndEvt.Invoke());

    }

    public void FadeOut()
    {

        baseImage.DOFade(0, fadeDuration).OnComplete(() => fadeOutEndEvt.Invoke());

    }

}
