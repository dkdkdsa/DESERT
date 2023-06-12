using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveObject : MonoBehaviour
{

    [SerializeField] private InteractionObjectRoot[] interactionObjects;

    private void Awake()
    {

        foreach (var interactionObject in interactionObjects)
        {

            interactionObject.enabled = false;

        }

    }

    public void EnableObject()
    {

        foreach (var interactionObject in interactionObjects)
        {

            interactionObject.enabled = true;

        }

    }

}
