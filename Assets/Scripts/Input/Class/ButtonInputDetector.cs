using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ButtonInputDetector
{
    public ButtonInputDetector(InputButtonInformation inputInformation, ButtonSettingSO buttonSettingSO)
    {
        _buttonSettingSO = buttonSettingSO;
        _inputInformation = inputInformation;
    }

    private readonly InputButtonInformation _inputInformation = null;
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
                _inputInformation.SetKeyState((EnableButton)i, KeyState.Down);
            }
            else if (Input.GetKeyUp(mappingKeyCodes[i]))
            {
                _inputInformation.SetKeyState((EnableButton)i, KeyState.Up);
            }
            else if (_inputInformation.KeyStateDictionary[(EnableButton)i] == KeyState.Down)
            {
                _inputInformation.SetKeyState((EnableButton)i, KeyState.Press);
            }
            else if (_inputInformation.KeyStateDictionary[(EnableButton)i] == KeyState.Up)
            {
                _inputInformation.SetKeyState((EnableButton)i, KeyState.None);
            }
        }
    }
}
