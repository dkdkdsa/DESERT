using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyMovement : MonoBehaviour
{

    private FairyState state;
    private Vector3 originPos;

    private void Awake()
    {
        
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


    }

    public void SetMove(Vector3[] arr, float spd)
    {


        state = FairyState.Move;

        StartCoroutine(MoveCo(arr, spd));

    }

    private IEnumerator MoveCo(Vector3[] arr, float spd)
    {


        for (int i = 0; i < arr.Length; i++)
        {

            transform.position = arr[i];
            yield return new WaitForSeconds(spd / arr.Length);

        }

        originPos = transform.position;
        state = FairyState.Idle;

    }

}
