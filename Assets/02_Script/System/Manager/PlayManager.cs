using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayManager : MonoBehaviour
{

    [SerializeField] private UnityEvent firstEvent;

    public static PlayManager instance { get; private set; }

    private void Awake()
    {
        
        instance = this;

    }

    private void Start()
    {
        
        firstEvent?.Invoke();

    }

}
