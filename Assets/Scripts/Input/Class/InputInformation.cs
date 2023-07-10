using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class InputInformation
{
    private readonly Dictionary<EnableDirection, KeyState> _keyStateDictionary = null;
    public IReadOnlyDictionary<EnableDirection, KeyState> KeyStateDictionary => _keyStateDictionary;

    private int _pressingCount = 0;
    public int PressingCount => _pressingCount;

    public InputInformation()
    {
        _keyStateDictionary = new Dictionary<EnableDirection, KeyState>();

        for (int i = 0; i < Enum.GetValues(typeof(EnableDirection)).Length; ++i)
        {
            _keyStateDictionary.Add((EnableDirection)i, KeyState.None);
        }
    }

    public void SetKeyState(EnableDirection enableButton, KeyState keyState)
    {
        _keyStateDictionary[enableButton] = keyState;
        SetPressingCount();
    }

    private void SetPressingCount()
    {
        _pressingCount = _keyStateDictionary.Values.Count(keyState => (int)keyState < 2);
    }
}
