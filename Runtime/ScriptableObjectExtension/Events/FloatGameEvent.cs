using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Float Variable Event", menuName = "Snowdrama/Scripable Object/Float/Event")]
public class FloatGameEvent : ScriptableObject
{
    private List<FloatGameEventListner> listeners = new List<FloatGameEventListner>();

    public void Raise(float value)
    {
        for (int i = listeners.Count; i >= 0; i--)
        {
            listeners[i].OnEventRaised(value);
        }
    }

    public void RegisterListener(FloatGameEventListner listener)
    {
        listeners.Add(listener);
    }

    public void UnregisterListener(FloatGameEventListner listener)
    {
        listeners.Remove(listener);
    }

}
