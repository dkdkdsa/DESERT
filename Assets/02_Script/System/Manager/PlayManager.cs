using Class;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayManager : MonoBehaviour
{

    [SerializeField] private UnityEvent firstEvent;
    [SerializeField] private List<MapEventClass> mapEvents = new List<MapEventClass>();

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
