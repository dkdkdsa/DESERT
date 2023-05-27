using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRoot : MonoBehaviour
{
    
    protected CharacterController characterController;

    protected virtual void Awake()
    {

        characterController = GetComponent<CharacterController>();

    }

}
