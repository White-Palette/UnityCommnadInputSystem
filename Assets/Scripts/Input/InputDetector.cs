using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDetector
{
    public void RecognizeInput(ref Key[] keys)
    {
        for (int i = 0; i < keys.Length; ++i)
        {
            KeyCode checkedKeyCode = keys[i].keyCode;
            KeyState checkedKeyState = keys[i].state;

            if (Input.GetKeyDown(checkedKeyCode))
            {
                keys[i].state = KeyState.Down;
            }
            else if (Input.GetKeyUp(checkedKeyCode))
            {
                keys[i].state = KeyState.Up;
            }
            else if (checkedKeyState == KeyState.Down)
            {
                keys[i].state = KeyState.Press;
            }
            else if (checkedKeyState == KeyState.Up)
            {
                keys[i].state = KeyState.None;
            }
        }
    }
}
