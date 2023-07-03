using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FairyLine : MonoBehaviour
{

    [SerializeField] private Vector3 start, startControll, end, endControll;
    [SerializeField] private Vector3[] arr;
    [SerializeField] private LineRenderer lineRenderer;
    [SerializeField] private int count;

    public void SettingArray()
    {

        lineRenderer.positionCount = count;
        arr = DOCurve.CubicBezier.GetSegmentPointCloud(start, startControll, end, endControll, count);
        lineRenderer.SetPositions(arr);

    }

}
