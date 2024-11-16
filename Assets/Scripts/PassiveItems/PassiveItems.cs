using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassiveItems : MonoBehaviour
{
    protected PlayerStat player;
    public PassiveItemsScriptableobject passiveItemData;

    protected virtual void ApplyModifier()
    {

    }

    void Start()
    {
        player = FindAnyObjectByType<PlayerStat>();
        ApplyModifier();
    }
}
