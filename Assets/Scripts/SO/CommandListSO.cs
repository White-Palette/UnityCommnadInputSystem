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
    private InputEvent[] inputKeys;
    public InputEvent[] InputKeys => inputKeys;

    [SerializeField]
    private string commandName;
    public string CommandName => commandName;
}