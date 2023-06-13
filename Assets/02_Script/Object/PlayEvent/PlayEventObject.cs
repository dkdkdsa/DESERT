using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayEventObject : SencerRoot
{

    [SerializeField] private UnityEvent sencingEvt;
    [SerializeField] private string[] sencingAbleTag;

    private void OnTriggerEnter(Collider other)
    {

        if (isSencing) return;

        foreach(var item in sencingAbleTag)
        {

            if (other.CompareTag(item))
            {

                isSencing = true;
                sencingEvt?.Invoke();
                break;

            }

        }

    }

}
