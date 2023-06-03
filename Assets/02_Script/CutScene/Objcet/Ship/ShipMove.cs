using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMove : MonoBehaviour
{

    [SerializeField] private float endZ;
    [SerializeField] private float moveSpd;

    private void FixedUpdate()
    {
        
        transform.Translate(transform.forward * Time.fixedDeltaTime * moveSpd);

    }

}
