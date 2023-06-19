using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{

    [SerializeField] private string nextScene;
    [SerializeField] private FadeEvent fadeEvent;

    private bool isInteraction;

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.transform.CompareTag("Player") && !isInteraction)
        {

            isInteraction = true;

            fadeEvent.FadeIn();

        }

    }

    public void ChangeScene()
    {

        SceneManager.LoadScene(nextScene);

    }

}
