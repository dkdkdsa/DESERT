using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineDrawSc : MonoBehaviour
{

    [HideInInspector] public Vector3[] renderArr = null;

    public void SetArr(Vector3[] renderArr)
    {

        this.renderArr = renderArr;

    }

#if UNITY_EDITOR

    private void OnDrawGizmosSelected()
    {
        
        if(renderArr == null) return;

    }

#endif

}
