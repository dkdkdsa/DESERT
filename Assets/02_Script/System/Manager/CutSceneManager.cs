using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutSceneManager : MonoBehaviour
{

    [SerializeField] private CutSceneRoot firstCutScene;

    private IEnumerator Start()
    {
        
        yield return null;
        firstCutScene.StartCutScene();

    }

}
