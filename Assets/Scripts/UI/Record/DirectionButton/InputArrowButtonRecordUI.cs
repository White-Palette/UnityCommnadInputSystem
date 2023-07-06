using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputArrowButtonRecordUI : InputButtonBaseRecorder<Direction>
{
    protected override void Start()
    {
        InputEventManager.AddEvent(Direction.Up, () => ButtonSetting(Direction.Up));
        InputEventManager.AddEvent(Direction.Down, () => ButtonSetting(Direction.Down));
        InputEventManager.AddEvent(Direction.Left, () => ButtonSetting(Direction.Left));
        InputEventManager.AddEvent(Direction.Right, () => ButtonSetting(Direction.Right));
        InputEventManager.AddEvent(Direction.LeftUp, () => ButtonSetting(Direction.LeftUp));
        InputEventManager.AddEvent(Direction.LeftDown, () => ButtonSetting(Direction.LeftDown));
        InputEventManager.AddEvent(Direction.RightUp, () => ButtonSetting(Direction.RightUp));
        InputEventManager.AddEvent(Direction.RightDown, () => ButtonSetting(Direction.RightDown));

        InputEventManager.AddEvent(Direction.Neutral, () => ButtonSetting(Direction.Neutral));
    }
}
