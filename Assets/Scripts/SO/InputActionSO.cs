using System;
using UnityEngine;

[CreateAssetMenu(fileName = "InputAction")]
public class InputActionSO : ScriptableObject
{
    public InputActionMapping[] _inputActionMappings = null;
}

[Serializable]
public class InputActionMapping
{
    public EnableDirection[] EnableButton;
    public string InputName;
}