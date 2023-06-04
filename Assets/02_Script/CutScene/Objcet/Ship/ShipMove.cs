using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShipMove : MonoBehaviour
{

    [SerializeField] private float endZ;
    [SerializeField] private float moveSpd;
    [SerializeField] private UnityEvent endEvt;

    private void FixedUpdate()
    {
        
        if(transform.position.z >= endZ)
        {

            endEvt?.Invoke();
            return;

        }

        transform.Translate(transform.forward * Time.fixedDeltaTime * moveSpd);

    }

}
