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

    }
}
