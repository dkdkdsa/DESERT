using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveObject : MonoBehaviour
{

    [SerializeField] private InteractionObjectRoot[] interactionObjects;

    private Collider objCol;

    private void Awake()
    {
        objCol = GetComponent<Collider>();
        if (objCol != null) objCol.enabled = false;

        foreach (var interactionObject in interactionObjects)
        {

            interactionObject.enabled = false;

        }

    }

    public void EnableObject()
    {

        if (objCol != null) objCol.enabled = true;

        foreach (var interactionObject in interactionObjects)
        {

            interactionObject.enabled = true;

        }

    }

}
