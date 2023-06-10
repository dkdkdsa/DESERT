using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChangeObjcet : InteractionObjectRoot
{

    [SerializeField] private float sencingRange = 5;

    private Transform playerTrm;
    private bool isPosChanging = false;

    private void Awake()
    {

        playerTrm = GameObject.Find("Player").transform;

    }

    public override void OnCursorClickEvent(InteractionClickKey key)
    {

        if(key == InteractionClickKey.Left && Vector3.Distance(transform.position, playerTrm.position) <= sencingRange && !isPosChanging)
        {

            StartCoroutine(PosChangeCo());

        }

    }

    public override void OnCursorOnEvent()
    {

        if (Vector3.Distance(transform.position, playerTrm.position) > sencingRange) return;

    }

    private void ChangePosition()
    {

        var curTrm = transform.position;
        var rutTrm = playerTrm.position;

        transform.position = rutTrm;
        playerTrm.position = curTrm;

    }

    private IEnumerator PosChangeCo()
    {

        isPosChanging = true;

        yield return null;

        float per = 0;

        while (per < 1)
        {

            per += Time.deltaTime;
            CameraManager.instance.SetFOV(
                Mathf.Lerp(CameraManager.instance.GetFOV(), 50, per));
            yield return null;

        }

        yield return new WaitForSeconds(0.5f);

        ChangePosition();

        yield return new WaitForSeconds(0.01f);

        while (per < 1)
        {

            per += Time.deltaTime * 5;
            CameraManager.instance.SetFOV(
                Mathf.Lerp(CameraManager.instance.GetFOV(), 60, per));
            yield return null;



        }

        isPosChanging = false;

    }

}
