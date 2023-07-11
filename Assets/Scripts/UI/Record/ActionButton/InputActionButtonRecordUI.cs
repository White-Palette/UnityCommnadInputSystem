using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputActionButtonRecordUI : BaseInputButtonRecorder<string>
{
    protected override void Start()
    {
        InputEventManager.AddEvent("LP", () => ButtonSetting("LP"));
        InputEventManager.AddEvent("RP", () => ButtonSetting("RP"));
        InputEventManager.AddEvent("LK", () => ButtonSetting("LK"));
        InputEventManager.AddEvent("RK", () => ButtonSetting("RK"));
    }
}
