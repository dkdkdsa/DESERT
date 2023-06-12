using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{

    public static ObjectManager instance;

    private void Awake()
    {
        
        instance = this;

    }

}
