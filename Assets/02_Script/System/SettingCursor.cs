using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingCursor : MonoBehaviour
{

    [SerializeField] private bool isVisable = true;

    private void Awake()
    {

        if (!isVisable)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;

        }
        else
        {

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

        }

    }

    public void SetVis()
    {

        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;


    }

    public void SetDis()
    {

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

    }

}
