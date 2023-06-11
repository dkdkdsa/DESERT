using Enums;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionChangeObjcet : InteractionObjectRoot
{

    [SerializeField] private float sencingRange = 5;

    private Transform playerTrm;
    private PlayerController playerController;
    private Rigidbody playerRigid;
    private bool isPosChanging = false;

    private void Awake()
    {

        playerController = FindObjectOfType<PlayerController>();
        playerTrm = GameObject.Find("Player").transform;
        playerRigid = playerTrm.GetComponent<Rigidbody>();

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
        playerController.RemoveAll();
        playerRigid.velocity = Vector3.zero;

        yield return null;

        float per = 0;

        CameraManager.instance.CameraShake(0.5f, 0.25f, 0.5f);

        while (CameraManager.instance.GetFOV() > 50)
        {

            per += Time.deltaTime;
            CameraManager.instance.SetFOV(
                Mathf.Lerp(60, 40, per));
            yield return null;

        }

        ChangePosition();

        yield return new WaitForSeconds(0.01f);

        while (CameraManager.instance.GetFOV() > 60)
        {

            per += Time.deltaTime;
            CameraManager.instance.SetFOV(
                Mathf.Lerp(40, 60, per));
            yield return null;

        }

        CameraManager.instance.SetFOV(60);
        playerController.AddAll();
        isPosChanging = false;

    }

}
