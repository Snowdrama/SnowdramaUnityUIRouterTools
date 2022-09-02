using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Bool Variable Event", menuName = "Snowdrama/Scripable Object/Bool/Event")]
public class BoolGameEvent : ScriptableObject
{
    private List<BoolGameEventListner> listeners = new List<BoolGameEventListner>();

    public void Raise(bool value)
    {
        for (int i = listeners.Count; i >= 0; i--)
        {
            listeners[i].OnEventRaised(value);
        }
    }

    public void RegisterListener(BoolGameEventListner listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(BoolGameEventListner listener)
    {
        listeners.Remove(listener);
    }

}
