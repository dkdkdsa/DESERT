using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverAnimator : MonoBehaviour
{

    private readonly int LeverUpHash = Animator.StringToHash("LeverUp");

    private Animator animator;

    private void Awake()
    {
        
        animator = GetComponent<Animator>();

    }

    public void SetLeverUpHash()
    {

        animator.SetBool(LeverUpHash, true);

    }

}
