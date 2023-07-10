using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class InputInformation
{
    private readonly Dictionary<EnableButton, KeyState> _keyStateDictionary = null;
    public IReadOnlyDictionary<EnableButton, KeyState> KeyStateDictionary => _keyStateDictionary;

    private int _pressingCount = 0;
    public int PressingCount => _pressingCount;

    public InputInformation()
    {
        _keyStateDictionary = new Dictionary<EnableButton, KeyState>();

        for (int i = 0; i < Enum.GetValues(typeof(EnableButton)).Length; ++i)
        {
            _keyStateDictionary.Add((EnableButton)i, KeyState.None);
        }
    }

    public void SetKeyState(EnableButton enableButton, KeyState keyState)
    {
        _keyStateDictionary[enableButton] = keyState;
        SetPressingCount();
    }

    private void SetPressingCount()
    {
        _pressingCount = _keyStateDictionary.Values.Count(keyState => (int)keyState < 2);
    }
}
