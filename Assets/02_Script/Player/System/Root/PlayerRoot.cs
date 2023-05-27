using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRoot : MonoBehaviour
{

    protected Rigidbody rigid;

    protected virtual void Awake()
    {

        rigid = GetComponent<Rigidbody>();

    }

}
