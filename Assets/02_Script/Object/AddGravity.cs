using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGravity : MonoBehaviour
{

    private const float gravityPower = 9.81f;
    private Rigidbody rigid;
    private GroundScncer groundScncer;

    private void Awake()
    {
        
        rigid = GetComponent<Rigidbody>();
        groundScncer = GetComponentInChildren<GroundScncer>();

    }

    private void FixedUpdate()
    {

        if (groundScncer.isSencing) return;

        rigid.velocity -= Vector3.up * gravityPower * Time.fixedDeltaTime;

    }

}
