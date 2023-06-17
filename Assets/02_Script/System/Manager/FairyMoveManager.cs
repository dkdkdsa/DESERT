using Class;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyMoveManager : MonoBehaviour
{

    [SerializeField] private List<FairyMoveClass> moves = new List<FairyMoveClass>();

    private FairyMovement fairy;

    private void Awake()
    {
        
        fairy = FindObjectOfType<FairyMovement>();

    }

    public void SetMove(string key)
    {

        var obj = moves.Find(x => x.key == key);

        fairy.SetMoev(obj.targetObj.transform.position, obj.speed);

    }

}
