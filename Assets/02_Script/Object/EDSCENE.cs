using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using DG.Tweening;
using UnityEngine.SceneManagement;
using FD.Dev;

public class EDSCENE : MonoBehaviour
{

    [SerializeField] private AudioSource audioSource;
    [SerializeField] private TMP_Text t1, t2, t3, t4;

    private void Start()
    {
        
        audioSource.Play();
        t1.DOFade(1, 2f).OnComplete(() =>
        {

            t1.DOFade(0, 2f).OnComplete(() =>
            {
                FAED.DelayInvoke(() =>
                {

                    audioSource.Play();
                    t2.DOFade(1, 2f).OnComplete(() =>
                    {

                        t2.DOFade(0, 2f).OnComplete(() =>
                        {

                            FAED.DelayInvoke(() =>
                            {


                                audioSource.Play();
                                t3.DOFade(1, 2f).OnComplete(() =>
                                {

                                    t3.DOFade(0, 2f).OnComplete(() =>
                                    {


                                        FAED.DelayInvoke(() =>
                                        {

                                            audioSource.Play();
                                            t4.DOFade(1, 2f).OnComplete(() =>
                                            {

                                                t4.DOFade(0, 2f).OnComplete(() =>
                                                {

                                                    SceneManager.LoadScene("IntroRM");

                                                });

                                            });

                                        }, 0.5f);

                                    });

                                });

                            }, 0.5f);//ID

                        });

                    });

                }, 0.5f);//ID
                

            });

        });

    }

}
