using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed;

    private FairyState state;
    private Vector3 targetPos;

    private void Awake()
    {
        
        targetPos = transform.position;

    }

    private void Update()
    {
        
        if(state == FairyState.Idle)
        {

            

        }

    }

}
