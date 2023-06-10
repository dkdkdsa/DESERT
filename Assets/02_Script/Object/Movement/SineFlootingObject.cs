using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Class;

public class SineFlootingObject : MonoBehaviour
{

    [SerializeField] private SineAdd rotateSine;

    private float offsetY;

    private void Awake()
    {
        
        offsetY = transform.position.y;

    }

    private void Update()
    {

        transform.position = new Vector3(transform.position.x, offsetY + rotateSine.GetSinValue(), transform.position.z);

    }

}