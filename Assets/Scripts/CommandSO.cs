using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CommandSO")]
public class CommandSO : ScriptableObject
{
    [SerializeField]
    private KeyCode[] _commandArrays = null;
}
