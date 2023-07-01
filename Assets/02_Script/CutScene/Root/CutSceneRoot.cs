using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public abstract class CutSceneRoot : MonoBehaviour
{

    [SerializeField] private UnityEvent cutSceneEndEvent;

    public abstract void StartCutScene();

}
