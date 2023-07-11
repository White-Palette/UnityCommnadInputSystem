using System;
using UnityEngine;

[CreateAssetMenu(fileName = "InputButtonAction")]
public class InputButtonActionSO : ScriptableObject
{
    public InputButtonActionMapping[] _inputActionMappings = null;
}

[Serializable]
public class InputButtonActionMapping
{
    public EnableButton[] EnableButton;
    public string InputName;
}