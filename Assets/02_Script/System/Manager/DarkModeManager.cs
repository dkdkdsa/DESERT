using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DarkModeManager : MonoBehaviour
{

    [SerializeField] private GameObject[] darkModeObjcetArr;
    
    public static DarkModeManager instance { get; private set; }

    private void Awake()
    {
        
        foreach(var item in darkModeObjcetArr)
        {

            item.SetActive(false);

        }

        instance = this;

    }

    public void SetMode(bool enable)
    {

        if (enable)
        {

            foreach (var item in darkModeObjcetArr)
            {

                item.SetActive(true);

            }

        }
        else
        {

            foreach (var item in darkModeObjcetArr)
            {

                item.SetActive(false);

            }

        }

    }

}
