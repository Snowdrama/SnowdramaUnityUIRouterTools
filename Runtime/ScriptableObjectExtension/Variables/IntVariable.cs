using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Int Variable", menuName = "Snowdrama/Scripable Object/Int/Variable")]
public class IntVariable : ScriptableObject
{
    private Action<int> onValueChanged;
    private int _value;
    public int Value
    {
        get { return _value; }
        set { 
            _value = value;
            onValueChanged?.Invoke(_value);
        }
    }

    public void RegisterOnChangeListener(Action<int> valueChangeListener)
    {
        onValueChanged += valueChangeListener;
    }

    public void UnregisterOnChangeListener(Action<int> valueChangeListenerToRemove)
    {
        onValueChanged -= valueChangeListenerToRemove;
    }
}
