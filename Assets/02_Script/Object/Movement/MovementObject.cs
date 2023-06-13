using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEvent : MonoBehaviour
{

    [SerializeField] private Vector3 direction;
    [SerializeField] private float speed;
    [SerializeField] private float moveTime;

    private float curTime;
    private bool isMovementing = false;

    private void FixedUpdate()
    {

        Movement();

    }

    private void Movement()
    {

        if (!isMovementing || curTime >= moveTime) return;

        curTime += Time.fixedDeltaTime;

        transform.Translate(direction * speed * Time.fixedDeltaTime);

    }

    public void StartMovement()
    {

        isMovementing = true;

    }

}
