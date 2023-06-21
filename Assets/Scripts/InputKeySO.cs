using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InputKeySO")]
public class InputKeySO : ScriptableObject
{
    [SerializeField]
    private KeyCode[] _inputKeys = null;


    private Dictionary<int, KeyCode> _keyDictionary = new Dictionary<int, KeyCode>();
}

public class InputKey
{
    private KeyCode key;
}
