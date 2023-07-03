using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Class;

public class FairyLineMoveManager : MonoBehaviour
{

    [SerializeField] private List<FairyLineMoveClass> fairyMoveClass;

    private FairyMovement fairyMovement;

    private void Awake()
    {
        
        fairyMovement = FindObjectOfType<FairyMovement>();

    }

    private void Start()
    {

        fairyMovement.SetMove(fairyMoveClass[0].line.GetLine(), fairyMoveClass[0].speed);

    }

}
