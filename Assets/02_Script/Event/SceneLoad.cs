using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{

    [SerializeField] private string next;

    public void Change()
    {

        SceneManager.LoadScene(next);

    }

    public void Exit()
    {

        Application.Quit();

    }

}
