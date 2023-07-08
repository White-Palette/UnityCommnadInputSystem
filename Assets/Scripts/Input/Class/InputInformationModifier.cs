using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InputInformationEditor
{
    private readonly InputInformation _inputInformation = null;
    protected InputInformation InputInformation => _inputInformation;

    protected InputInformationEditor(InputInformation inputInformation)
    {
        _inputInformation = inputInformation;
    }
}
