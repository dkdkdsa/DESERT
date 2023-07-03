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

        fairyMovement.SetMove(fairyMoveClass[0].line.GetLine(), fairyMoveClass[0].speed, fairyMoveClass[0].endEvent);

    }

    public void GetMoveEvt(int idx)
    {

        fairyMovement.SetMove(fairyMoveClass[idx].line.GetLine(), fairyMoveClass[idx].speed, fairyMoveClass[idx].endEvent);

    }

    public void GetMoveEvt(string key)
    {

        var obj = fairyMoveClass.Find(x => x.key == key);

        fairyMovement.SetMove(obj.line.GetLine(), obj.speed, obj.endEvent);

    }

}
