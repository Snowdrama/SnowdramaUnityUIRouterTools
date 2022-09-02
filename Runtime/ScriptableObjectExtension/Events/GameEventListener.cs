using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class GameEventListener : MonoBehaviour
{
    public GameEvent gameEvent;
    public UnityEvent unityEvent;
    private Action scriptEvent;
    private void OnEnable()
    {
        gameEvent.RegisterListener(this);
    }

    private void OnDisable()
    {
        gameEvent.UnregisterListener(this);
    }

    public void OnEventRaised()
    {
        scriptEvent?.Invoke();
        unityEvent?.Invoke();
    }
}
