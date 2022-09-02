using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Bool Variable", menuName = "Snowdrama/Scripable Object/Bool/Variable")]
public class BoolVariable : ScriptableObject
{
    private Action<bool> onValueChanged;
    private bool _value;
    public bool Value
    {
        get { return _value; }
        set
        {
            _value = value;
            onValueChanged?.Invoke(_value);
        }
    }

    public void RegisterOnChangeListener(Action<bool> valueChangeListener)
    {
        onValueChanged += valueChangeListener;
    }

    public void UnregisterOnChangeListener(Action<bool> valueChangeListenerToRemove)
    {
        onValueChanged -= valueChangeListenerToRemove;
    }
}
