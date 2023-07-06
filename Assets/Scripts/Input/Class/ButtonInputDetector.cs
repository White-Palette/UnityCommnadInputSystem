using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonInputDetector : InputInformationEditor
{
    public ButtonInputDetector(InputInformation inputInformation) : base(inputInformation) { }

    public void RecognizeInput()
    {
        KeyCode[] keyCodes = InputInformation.GetKeyCodeArray();
        KeyState[] keyStates = InputInformation.GetKeyStateArray();

        for (int i = 0; i < InputInformation.KeyCount; ++i)
        {
            KeyCode checkedKeyCode = keyCodes[i];
            KeyState checkedKeyState = keyStates[i];

            if (Input.GetKeyDown(checkedKeyCode))
            {
                InputInformation.SetKeyState(checkedKeyCode, KeyState.Down);
            }
            else if (Input.GetKeyUp(checkedKeyCode))
            {
                InputInformation.SetKeyState(checkedKeyCode, KeyState.Up);
            }
            else if (checkedKeyState == KeyState.Down)
            {
                InputInformation.SetKeyState(checkedKeyCode, KeyState.Press);
            }
            else if (checkedKeyState == KeyState.Up)
            {
                InputInformation.SetKeyState(checkedKeyCode, KeyState.None);
            }
        }
    }
}
