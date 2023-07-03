using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class InputInformation
{
    private Dictionary<KeyCode, KeyState> _keyDictionary = new();

    private int _pressingKeyCount = 0;
    private int _pressedKeyCount = 0;

    public InputInformation(KeyCode[] keyCodes)
    {
        for (int i = 0; i < keyCodes.Length; ++i)
        {
            _keyDictionary.Add(keyCodes[i], KeyState.None);
        }
    }

    public KeyCode[] GetKeyCodeArray() => _keyDictionary.Keys.ToArray();
    public KeyState[] GetKeyStateArray() => _keyDictionary.Values.ToArray();

    public void SetKeyState(KeyCode keyCode, KeyState keyState)
    {
        _keyDictionary[keyCode] = keyState;
    }

    public int KeyCount => _keyDictionary.Count;
}
