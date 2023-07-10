using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ButtonInputDetector : InputInformationEditor
{
    public ButtonInputDetector(InputInformation inputInformation, ButtonSettingSO buttonSettingSO) : base(inputInformation)
    {
        _buttonSettingSO = buttonSettingSO;
    }

    private ButtonSettingSO _buttonSettingSO = null;

    public void RecognizeInput()
    {
        KeyCode[] mappingKeyCodes = new KeyCode[Enum.GetValues(typeof(EnableButton)).Length];

        for (int i = 0; i < Enum.GetValues(typeof(EnableButton)).Length; ++i)
        {
            mappingKeyCodes[i] = _buttonSettingSO._buttonMappings[i].KeyCode;
        }

        for (int i = 0; i < Enum.GetValues(typeof(EnableButton)).Length; ++i)
        {
            if (Input.GetKeyDown(mappingKeyCodes[i]))
            {
                InputInformation.SetKeyState((EnableButton)i, KeyState.Down);
            }
            else if (Input.GetKeyUp(mappingKeyCodes[i]))
            {
                InputInformation.SetKeyState((EnableButton)i, KeyState.Up);
            }
            else if (InputInformation.KeyStateDictionary[(EnableButton)i] == KeyState.Down)
            {
                InputInformation.SetKeyState((EnableButton)i, KeyState.Press);
            }
            else if (InputInformation.KeyStateDictionary[(EnableButton)i] == KeyState.Up)
            {
                InputInformation.SetKeyState((EnableButton)i, KeyState.None);
            }
        }
    }
}
