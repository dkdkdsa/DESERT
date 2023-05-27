using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScncer : SencerRoot
{

    [SerializeField] private string[] sencingAbleTag;

    private void OnTriggerEnter(Collider other)
    {
        
        foreach(var tag in sencingAbleTag)
        {

            if (other.CompareTag(tag))
            {

                isSencing = true;
                break;

            }

        }

    }

    private void OnTriggerStay(Collider other)
    {

        foreach (var tag in sencingAbleTag)
        {

            if (other.CompareTag(tag))
            {

                isSencing = true;
                break;

            }

        }

    }

    private void OnTriggerExit(Collider other)
    {

        foreach (var tag in sencingAbleTag)
        {

            if (other.CompareTag(tag))
            {

                isSencing = false;
                break;

            }

        }

    }

}
