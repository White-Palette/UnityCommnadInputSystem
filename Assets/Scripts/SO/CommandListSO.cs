using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CommandListSO")]
public class CommandListSO : ScriptableObject
{
    public Direction[] inputKeys;
    public string commandName;
}

