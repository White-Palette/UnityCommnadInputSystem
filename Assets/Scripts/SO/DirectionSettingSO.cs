using System;
using UnityEngine;

[CreateAssetMenu(fileName = "DirectionSetting")]
public class DirectionSettingSO : ScriptableObject
{
    public DirectionMapping[] _buttonMappings = null;
}

[Serializable]
public class DirectionMapping
{
    public EnableDirection EnableButton;
    public KeyCode KeyCode;
}