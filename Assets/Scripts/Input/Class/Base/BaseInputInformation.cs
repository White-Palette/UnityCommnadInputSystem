using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class BaseInputInformation<T> where T : Enum
{
    private readonly Dictionary<T, KeyState> _keyStateDictionary = null;
    public IReadOnlyDictionary<T, KeyState> KeyStateDictionary => _keyStateDictionary;

    private int _pressingCount = 0;
    public int PressingCount => _pressingCount;

    public BaseInputInformation()
    {
        _keyStateDictionary = new Dictionary<T, KeyState>();

        for (int i = 0; i < Enum.GetValues(typeof(T)).Length; ++i)
        {
            _keyStateDictionary.Add((T)Enum.ToObject(typeof(T), i), KeyState.None);
        }
    }

    public void SetKeyState(T enableButton, KeyState keyState)
    {
        _keyStateDictionary[enableButton] = keyState;
        SetPressingCount();
    }

    private void SetPressingCount()
    {
        _pressingCount = _keyStateDictionary.Values.Count(keyState => (int)keyState < 2);
    }
}
