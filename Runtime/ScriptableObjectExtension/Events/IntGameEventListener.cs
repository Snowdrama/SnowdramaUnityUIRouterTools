using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class IntGameEventListener : MonoBehaviour
{
    public IntGameEvent gameEvent;
    public UnityEvent<int> unityEvent;
    private Action<int> scriptEvent;
    private void OnEnable()
    {
        gameEvent.RegisterListener(this);
    }

    private void OnDisable()
    {
        gameEvent.UnregisterListener(this);
    }

    public void OnEventRaised(int value)
    {
        scriptEvent?.Invoke(value);
        unityEvent?.Invoke(value);
    }
}
