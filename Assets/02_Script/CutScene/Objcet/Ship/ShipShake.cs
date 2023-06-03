using Class;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShake : MonoBehaviour
{

    [SerializeField] private SineAdd sineAdd;
    [SerializeField] private float rotatePower = 120f;
    [SerializeField] private float moveDis;

    private void Awake()
    {
        


    }

    private void FixedUpdate()
    {

        var vec = transform.eulerAngles;
        transform.eulerAngles = new Vector3(vec.x, vec.y, (sineAdd.GetSinValue() / moveDis) * rotatePower);

    }

}
