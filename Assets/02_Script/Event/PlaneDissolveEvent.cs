using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Events;

public class PlaneDissolveEvent : EventRoot
{

    [SerializeField] private GameObject plane;
    [SerializeField] private Vector3 endPos;
    [SerializeField] private float duration;

    public override void StartEvent()
    {

        plane.transform.DOMove(endPos, duration).OnComplete(() => endEvent?.Invoke()); 

    }

}
