using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingPassiveItem : PassiveItems
{
    protected override void ApplyModifier()
    {
        player.CurrentMoveSpeed *= 1 + passiveitemData.Multipler / 100f;
    }
}