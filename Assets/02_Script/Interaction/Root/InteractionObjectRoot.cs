using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InteractionObjectRoot : MonoBehaviour
{

    public abstract void OnCursorOnEvent();
    public abstract void OnCursorClickEvent();

}