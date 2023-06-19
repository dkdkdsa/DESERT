using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerValueSystem : MonoBehaviour
{

    [field: SerializeField] public float moveSpeed {  get; private set; }
    [field: SerializeField] public float rotateSpeed { get; private set; }
    [field: SerializeField] public float maxRotateAngle { get; private set; }
    [field: SerializeField] public float jumpPower { get; private set; }
    [field: SerializeField] public LayerMask interactionMask { get; private set; }
    [field: SerializeField] public AudioSource posChangeObject { get; private set; }
    [field: SerializeField] public AudioSource mapChangeSound { get; private set; }

}
