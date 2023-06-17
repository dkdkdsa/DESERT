using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyMovement : MonoBehaviour
{

    [SerializeField] private float moveSpeed;

    private FairyState state;
    private Vector3 targetPos;
    private Vector3 originPos;

    private void Awake()
    {
        
        targetPos = transform.position;
        originPos = transform.position;

    }

    private void Update()
    {
        
        if(state == FairyState.Idle)
        {

            transform.position = new Vector3(
                originPos.x + (Mathf.Sin(Time.time * 2) / 3),
                originPos.y + (Mathf.Cos(Time.time * 3) / 3),
                originPos.z + (Mathf.Sin(Time.time * 5) / 3));

        }
        else
        {

            transform.position = Vector3.Lerp(originPos, targetPos, moveSpeed * Time.deltaTime);

            if(Vector3.Distance(transform.position, targetPos) <= 0.1f)
            {

                originPos = transform.position;
                state = FairyState.Idle;

            }

        }

    }

    public void SetMoev(Vector3 vec, float spd)
    {

        originPos = transform.position;
        targetPos = vec;
        moveSpeed = spd;

        state = FairyState.Move;

    }

}
