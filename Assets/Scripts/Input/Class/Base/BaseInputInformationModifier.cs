using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseInputInformationEditor
{
    private readonly InputInformation _inputInformation = null;
    protected InputInformation InputInformation => _inputInformation;

    protected BaseInputInformationEditor(InputInformation inputInformation)
    {
        _inputInformation = inputInformation;
    }
}
