using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDarkMode : PlayerBehaviorRoot
{

    private void DrakGaugeDissolve()
    {

        if (!valueSystem.darkMode) return;

    }

    public override void AddEvent()
    {

        eventSystem.OnUpdateEvent += DrakGaugeDissolve;

    }

    public override void RemoveEvent()
    {

        eventSystem.OnUpdateEvent -= DrakGaugeDissolve;

    }
}