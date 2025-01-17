using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRoot : MonoBehaviour
{

    protected Rigidbody rigid;
    protected PlayerValueSystem valueSystem;
    protected GroundScncer groundScncer;

    protected virtual void Awake()
    {

        rigid = GetComponent<Rigidbody>();
        valueSystem = GetComponent<PlayerValueSystem>();
        groundScncer = GetComponentInChildren<GroundScncer>();

    }

}
