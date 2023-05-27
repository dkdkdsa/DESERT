using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : PlayerBehaviorRoot
{

    private void Jump()
    {

        if (groundScncer.isSencing) rigid.velocity += Vector3.up * valueSystem.jumpPower;

    }

    public override void AddEvent()
    {

        eventSystem.OnJumpKeyPressEvent += Jump;

    }

    public override void RemoveEvent()
    {

        eventSystem.OnJumpKeyPressEvent -= Jump;

    }
}
