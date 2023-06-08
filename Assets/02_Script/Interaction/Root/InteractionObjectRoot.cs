using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Enums;

public abstract class InteractionObjectRoot : MonoBehaviour
{

    public abstract void OnCursorClickEvent(InteractionClickKey key);
    public abstract void OnCursorOnEvent();

}