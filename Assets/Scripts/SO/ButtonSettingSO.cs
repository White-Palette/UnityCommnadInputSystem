using System;
using UnityEngine;

[CreateAssetMenu(fileName = "ButtonSetting")]
public class ButtonSettingSO : ScriptableObject
{
    public ButtonMapping[] _buttonMappings = null;
}

[Serializable]
public class ButtonMapping
{
    public EnableButton EnableButton;
    public KeyCode KeyCode;
}