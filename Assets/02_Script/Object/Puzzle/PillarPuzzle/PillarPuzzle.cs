using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PillarPuzzle : PuzzleRoot
{

    [SerializeField] private float rotateSpeed;
    [SerializeField] private float targetAngle;
    [SerializeField] private UnityEvent puzzleClearEvt = null;

    private PillarObject[] puzzles;

    private void Awake()
    {
        
        puzzles = GetComponentsInChildren<PillarObject>();

        foreach(var puzzle in puzzles) 
        {

            puzzle.SettingRotateSpeed(rotateSpeed);

        }

    }

    private void Update()
    {

        bool clear = false;

        foreach(var puzzle in puzzles) 
        {

            if (Mathf.Abs(puzzle.transform.eulerAngles.y - targetAngle) < 5f)
            {

                clear = true;

            }
            else
            {

                clear = false;
                break;

            }
        
        }

        if(clear) PuzzleClearEvent();

    }

    public override void PuzzleClearEvent()
    {

        foreach(var puzzle in puzzles) 
        { 
            
            Destroy(puzzle);

        }

        puzzleClearEvt?.Invoke();

        Destroy(this);

    }
}
