using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Class
{

    [System.Serializable]
    public class SineClass
    {

        [field:SerializeField] public float x { get; private set; }
        [field:SerializeField] public float y { get; private set; }

        public float GetSineGrahp()
        {

            return x * Mathf.Sin(y * Time.time);

        }

    }

    [System.Serializable]
    public class SineAdd
    {

        [SerializeField] private SineClass[] sineClasses = null;

        public float GetSinValue()
        {

            float xVel = 0, sinVel = 0;

            foreach (var s in sineClasses) 
            {

                sinVel += s.GetSineGrahp();
                xVel += s.x;

            }

            return (sinVel / (xVel * 2));

        }

    }

    [System.Serializable]
    public class UIManagedClass
    {

        public string key;
        public GameObject uiObject;

    }

    [System.Serializable]
    public class ObjectManageClass
    {

        public string key;
        public List<DissolveObject> managedObjects = new List<DissolveObject>();
        public bool isRev;

    }

    [System.Serializable]
    public class CutSceneEventClass
    {

        public Vector3 targetVec;
        public Vector3 targetRotate;
        public float cutSceneSpeed;

    }

    [System.Serializable]
    public class UIEventClass
    {

        public string key;
        public UnityEvent uiEvent;

    }

    [System.Serializable]
    public class MapEventClass
    {

        public string key;
        public UnityEvent mapEvent;

    }

    [System.Serializable]
    public class FairyMoveClass
    {

        public string key;
        public float speed;
        public GameObject targetObj;

    }

    [System.Serializable]
    public class FairyLineMoveClass
    {

        public string key;
        public float speed;
        public FairyLine line;
        public UnityEvent endEvent;

    }

}