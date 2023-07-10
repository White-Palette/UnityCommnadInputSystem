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
    private @string[] inputKeys;
    public @string[] InputKeys => inputKeys;

    [SerializeField]
    private string commandName;
    public string CommandName => commandName;
}