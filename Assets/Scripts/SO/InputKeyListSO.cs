using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

[CreateAssetMenu(fileName = "InputKeyListSO")]
public class InputKeyListSO : ScriptableObject
{
    public InputKey[] inputKeys;

    public int Length => inputKeys.Length;

    public KeyCode[] GetUseKeyArray()
    {
        List<KeyCode> keyCodes = new List<KeyCode>();

        foreach (var inputKey in inputKeys)
        {
            keyCodes.AddRange(inputKey.keyCodes);
        }

        return keyCodes.Distinct().ToArray();
    }
}

[Serializable]
public class InputKey
{
    public KeyCode[] keyCodes;

    [SerializeField]
    private Direction eventName = Direction.Neutral;

    public Direction EventName => eventName;
}