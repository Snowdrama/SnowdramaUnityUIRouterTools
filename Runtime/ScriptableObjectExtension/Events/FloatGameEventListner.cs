using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FloatGameEventListner : MonoBehaviour
{
    public FloatGameEvent gameEvent;
    public UnityEvent<float> unityEvent;
    private Action<float> scriptEvent;
    private void OnEnable()
    {
        gameEvent.RegisterListener(this);
    }

    private void OnDisable()
    {
        gameEvent.UnregisterListener(this);
    }

    public void OnEventRaised(float value)
    {
        scriptEvent?.Invoke(value);
        unityEvent?.Invoke(value);
    }
}
