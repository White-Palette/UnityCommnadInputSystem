using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private InputKeyListSO _inputKeyListSO = null;

    [SerializeField]
    private CommandListSO _commandListSO = null;

    private InputInformation _inputInformation = null;

    private InputDetector _inputDetector = null;
    private InputProcessor _inputProcessor = null;




    void Awake()
    {
        _inputInformation = new InputInformation(_inputKeyListSO.GetUseKeyArray());
        _inputDetector = new InputDetector(_inputInformation);
        _inputProcessor = new InputProcessor(_inputInformation);
    }

    private void Update()
    {
        _inputDetector.RecognizeInput();
        _inputProcessor.Process();
    }
}

