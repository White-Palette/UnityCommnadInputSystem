using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class InputActionExecutor : BaseInputInformationEditor
{
    private readonly InputActionSO _inputActionSO = null;

    public InputActionExecutor(InputInformation inputInformation, InputActionSO inputActionSO) : base(inputInformation)
    {
        _inputActionSO = inputActionSO;
    }

    public void CheckAndExecutor()
    {
        _inputActionSO._inputActionMappings.ToList().ForEach(inputActionMapping =>
        {
            if (inputActionMapping.EnableButton.ToList().TrueForAll(enableButton => InputInformation.KeyStateDictionary[enableButton] == KeyState.Press) && inputActionMapping.EnableButton.Length == InputInformation.PressingCount)
            {
                InputEventManager.ExecuteEvent(inputActionMapping.InputName);
            }
        });
    }
}
