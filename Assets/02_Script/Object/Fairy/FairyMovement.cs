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

            transform.position = new Vector3(
                targetPos.x + (Mathf.Sin(Time.time * 2) / 3),
                targetPos.y + (Mathf.Cos(Time.time * 3) / 3),
                targetPos.z + (Mathf.Sin(Time.time * 5) / 3));

        }

    }

}
