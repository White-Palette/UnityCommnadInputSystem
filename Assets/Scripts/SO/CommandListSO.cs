using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "CommandListSO")]
public class CommandListSO : ScriptableObject
{
    public Command[] commands;
}

[Serializable]
public class Command
{
    [SerializeField]
    private Direction[] inputKeys;
    public Direction[] InputKeys => inputKeys;

    [SerializeField]
    private string commandName;
    public string CommandName => commandName;
}