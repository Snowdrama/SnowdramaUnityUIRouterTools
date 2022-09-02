using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Int Variable Event", menuName = "Snowdrama/Scripable Object/Int/Event")]
public class IntGameEvent : ScriptableObject
{
    private List<IntGameEventListener> listeners = new List<IntGameEventListener>();

    public void Raise(int value)
    {
        for (int i = listeners.Count; i >= 0; i--)
        {
            listeners[i].OnEventRaised(value);
        }
    }

    public void RegisterListener(IntGameEventListener listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(IntGameEventListener listener)
    {
        listeners.Remove(listener);
    }

}
