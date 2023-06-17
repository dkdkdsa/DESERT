using FD.Dev;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIShowEvent : MonoBehaviour
{

    [SerializeField] private GameObject showUI;
    [SerializeField] private float dissolveTime;

    public void ShowUI()
    {

        showUI.SetActive(true);

        FAED.DelayInvoke(() =>
        {

            showUI.SetActive(false);

        }, dissolveTime);

    }

}
