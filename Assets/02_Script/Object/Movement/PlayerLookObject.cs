using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookObject : MonoBehaviour
{

    private Transform playerTrm;

    private void Awake()
    {

        playerTrm = GameObject.Find("Player").transform;

    }


    private void FixedUpdate()
    {

        Look();

    }

    private void Look()
    {

        var fwd = playerTrm.position - transform.position;
        fwd.y = 0;

        transform.rotation = Quaternion.LookRotation(-fwd);

    }


}
