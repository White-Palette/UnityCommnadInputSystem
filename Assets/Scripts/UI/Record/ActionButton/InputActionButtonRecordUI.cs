using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputActionButtonRecordUI : InputButtonBaseRecorder<Direction>
{
    protected override void Start()
    {
        InputEventManager.AddEvent(Direction.LP, () => ButtonSetting(Direction.LP));
        InputEventManager.AddEvent(Direction.RP, () => ButtonSetting(Direction.RP));
        InputEventManager.AddEvent(Direction.LK, () => ButtonSetting(Direction.LK));
        InputEventManager.AddEvent(Direction.RK, () => ButtonSetting(Direction.RK));
    }
}
