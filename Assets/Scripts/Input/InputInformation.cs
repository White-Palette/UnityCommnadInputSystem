using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class InputInformation
{
    private Dictionary<KeyCode, KeyState> _keyDictionary = new();

    private int _pressingKeyCount = 0;
    public int PressingKeyCount => _pressingKeyCount;

    private int _pressedKeyCount = 0;

    public bool IsInputChanged => _pressingKeyCount != _pressedKeyCount;

    public InputInformation(KeyCode[] keyCodes)
    {
        for (int i = 0; i < keyCodes.Length; ++i)
        {
            _keyDictionary.Add(keyCodes[i], KeyState.None);
        }
    }

    public KeyCode[] GetKeyCodeArray() => _keyDictionary.Keys.ToArray();
    public KeyState[] GetKeyStateArray() => _keyDictionary.Values.ToArray();

    public KeyState GetKeyState(KeyCode keyCode) => _keyDictionary[keyCode];

    public void SetKeyState(KeyCode keyCode, KeyState keyState)
    {
        _keyDictionary[keyCode] = keyState;
        UpdateKeyPressCount();
    }

    public int KeyCount => _keyDictionary.Count;

    private void UpdateKeyPressCount()
    {
        _pressedKeyCount = _pressingKeyCount;
        _pressingKeyCount = 0;

        foreach (KeyState keyState in _keyDictionary.Values)
        {
            if ((int)keyState < 2)
            {
                ++_pressingKeyCount;
            }
        }
    }
}
