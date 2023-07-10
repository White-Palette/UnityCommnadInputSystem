using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputActionExecutor : InputInformationEditor
{
    private readonly InputActionSO _inputActionSO = null;

    public InputActionExecutor(InputInformation inputInformation, InputActionSO inputActionSO) : base(inputInformation)
    {
        _inputActionSO = inputActionSO;
    }

    public void CheckAndExecutor()
    {
        var k = InputInformation.GetKeyCodeArray();
        var s = InputInformation.GetKeyStateArray();

        for (int i = 0; i < _inputActionSO._inputActionMappings.Length; ++i)
        {
            var inputActionMapping = _inputActionSO._inputActionMappings[i];

            for (int j = 0; j < k.Length; ++j)
            {

            }
        }
    }
}
