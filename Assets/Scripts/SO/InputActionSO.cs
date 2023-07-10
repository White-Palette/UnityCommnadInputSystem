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
    public EnableButton[] EnableButton;
    public string InputName;
}