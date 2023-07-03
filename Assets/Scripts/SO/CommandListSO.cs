using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CommandListSO")]
public class CommandListSO : ScriptableObject
{
    public InputEvent[] inputKeys;
    public string commandName;
}

