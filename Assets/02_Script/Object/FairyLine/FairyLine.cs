using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyLine : MonoBehaviour
{

    [SerializeField] private Transform start, startControll, end, endControll;
    [SerializeField] private Vector3[] arr;
    [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private int count;

    public Vector3[] GetLine() => arr;

    public void SettingArray()
    {

        lineRenderer.positionCount = count;
        arr = DOCurve.CubicBezier.GetSegmentPointCloud(start.position, startControll.position, end.position, endControll.position, count);
        lineRenderer.SetPositions(arr);

    }


    private void Awake()
    {

        lineRenderer.enabled = false;

    }

#if UNITY_EDITOR

    private void OnDrawGizmos()
    {
        
        if(start == null || end == null || startControll == null || endControll == null) return;

        var old = Gizmos.color;

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(start.position, 0.3f);
        Gizmos.DrawWireSphere(end.position, 0.3f);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(startControll.position, 0.3f);
        Gizmos.DrawWireSphere(endControll.position, 0.3f);

        Gizmos.color = old;
    }

#endif

}
