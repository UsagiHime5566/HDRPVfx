using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class SpawnEvent : MonoBehaviour
{
    public VisualEffect vfx;
    void Start()
    {
        
    }

    [ContextMenu("SendStart")]
    void SendStart(){
        vfx.SendEvent("OnPlay");
    }

    [ContextMenu("SendEnd")]
    void SendEnd(){
        vfx.SendEvent("OnEnd");
    }
}
