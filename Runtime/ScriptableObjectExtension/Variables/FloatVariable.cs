using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Float Variable", menuName = "Snowdrama/Scripable Object/Float/Variable")]
public class FloatVariable : ScriptableObject
{
    private Action<float> onValueChanged;
    private float _value;
    public float Value
    {
        get { return _value; }
        set
        {
            _value = value;
            onValueChanged?.Invoke(_value);
        }
    }

    public void RegisterOnChangeListener(Action<float> valueChangeListener)
    {
        onValueChanged += valueChangeListener;
    }

    public void UnregisterOnChangeListener(Action<float> valueChangeListenerToRemove)
    {
        onValueChanged -= valueChangeListenerToRemove;
    }
}
