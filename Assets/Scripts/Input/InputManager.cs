using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private InputButtonListSO _inputButtonListSO = null;

    [SerializeField]
    private CommandListSO _commandListSO = null;

    private InputInformation _inputInformation = null;

    private ButtonInputDetector _inputDetector = null;
    private InputProcessor _inputProcessor = null;

    private void Awake()
    {
        _inputInformation = new InputInformation(_inputButtonListSO.GetUseKeyArray());
        _inputDetector = new ButtonInputDetector(_inputInformation);
        _inputProcessor = new InputProcessor(_inputInformation, _inputButtonListSO, _commandListSO);
    }

    private void Update()
    {
        _inputDetector.RecognizeInput();
        _inputProcessor.Process();
    }
}

