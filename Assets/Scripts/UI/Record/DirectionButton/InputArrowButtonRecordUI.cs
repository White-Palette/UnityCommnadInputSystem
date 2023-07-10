using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputArrowButtonRecordUI : InputButtonBaseRecorder<string>
{
    protected override void Start()
    {
        InputEventManager.AddEvent("8", () => ButtonSetting("8"));
        InputEventManager.AddEvent("2", () => ButtonSetting("2"));
        InputEventManager.AddEvent("4", () => ButtonSetting("4"));
        InputEventManager.AddEvent("6", () => ButtonSetting("6"));
        InputEventManager.AddEvent("7", () => ButtonSetting("7"));
        InputEventManager.AddEvent("1", () => ButtonSetting("1"));
        InputEventManager.AddEvent("9", () => ButtonSetting("9"));
        InputEventManager.AddEvent("3", () => ButtonSetting("3"));

        InputEventManager.AddEvent("N", () => ButtonSetting("N"));
    }
}
