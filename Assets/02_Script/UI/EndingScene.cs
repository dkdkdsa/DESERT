using FD.Dev;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class EndingScene : MonoBehaviour
{

    [SerializeField] private TMP_Text text;

    private void Start()
    {

        FAED.DelayInvoke(() =>
        {

            text.DOFade(1, 5).OnComplete(() => SceneManager.LoadScene("Intro"));

        }, 3f);

    }

}
