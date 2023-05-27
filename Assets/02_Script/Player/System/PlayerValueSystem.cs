using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerValueSystem : MonoBehaviour
{

    [field: SerializeField] public float moveSpeed {  get; private set; }
    [field: SerializeField] public float rotateSpeed { get; private set; }
    [field: SerializeField] public float maxRotateAngle { get; private set; }

}
