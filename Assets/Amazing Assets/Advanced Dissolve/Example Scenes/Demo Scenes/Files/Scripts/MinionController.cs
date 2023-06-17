﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AmazingAssets.AdvancedDissolve.ExampleScripts
{
    public class MinionController : MonoBehaviour
    {
        public AdvancedDissolveKeywordsController keywordsController;
        public AdvancedDissolveGeometricCutoutController geometricCutoutController;

        public GameObject minion1;
        public GameObject minion2;
        public GameObject minion3;

        bool minionsAreActive;

        // Use this for initialization
        void Start()
        {
            Hide();
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.M))
            {
                if (minionsAreActive)
                    Hide();
                else
                    Show();
            }
        }

        void Show()
        {
            minion1.SetActive(true);
            minion2.SetActive(true);
            minion3.SetActive(true);

            minionsAreActive = true;


            keywordsController.cutoutGeometricCount = AdvancedDissolveKeywords.CutoutGeometricCount.Four;
            geometricCutoutController.count = AdvancedDissolveKeywords.CutoutGeometricCount.Four;
        }

        void Hide()
        {
            minion1.SetActive(false);
            minion2.SetActive(false);
            minion3.SetActive(false);

            minionsAreActive = false;

            keywordsController.cutoutGeometricCount = AdvancedDissolveKeywords.CutoutGeometricCount.One;
            geometricCutoutController.count = AdvancedDissolveKeywords.CutoutGeometricCount.One;

        }
    }
}