using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "String Variable", menuName = "Snowdrama/Scripable Object/String/Variable")]
public class StringVariable : ScriptableObject
{
    private Action<string> onValueChanged;
    private string _value;
    public string Value
    {
        get { return _value; }
        set
        {
            _value = value;
            onValueChanged?.Invoke(_value);
        }
    }

    public void RegisterOnChangeListener(Action<string> valueChangeListener)
    {
        onValueChanged += valueChangeListener;
    }

    public void UnregisterOnChangeListener(Action<string> valueChangeListenerToRemove)
    {
        onValueChanged -= valueChangeListenerToRemove;
    }
}
