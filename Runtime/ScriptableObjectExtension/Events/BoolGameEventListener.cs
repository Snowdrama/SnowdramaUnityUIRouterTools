using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class BoolGameEventListner : MonoBehaviour
{
    public BoolGameEvent gameEvent;
    public UnityEvent<bool> unityEvent;
    private Action<bool> scriptEvent;
    private void OnEnable()
    {
        gameEvent.RegisterListener(this);
    }

    private void OnDisable()
    {
        gameEvent.UnregisterListener(this);
    }

    public void OnEventRaised(bool value)
    {
        scriptEvent?.Invoke(value);
        unityEvent?.Invoke(value);
    }
}
