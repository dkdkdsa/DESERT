using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class EventRoot : MonoBehaviour
{

    [SerializeField] protected UnityEvent endEvent;

    public abstract void StartEvent();

}
