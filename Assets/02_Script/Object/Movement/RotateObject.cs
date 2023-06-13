using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

    [SerializeField] private float rotateSpeed = 3f;

    private void FixedUpdate()
    {

        Rotate();

    }

    private void Rotate()
    {

        transform.eulerAngles += new Vector3(0, rotateSpeed * Time.fixedDeltaTime, 0);

    }

}
