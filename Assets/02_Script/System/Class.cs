using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

}