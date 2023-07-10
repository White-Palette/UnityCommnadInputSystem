using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private InputButtonListSO _inputButtonListSO = null;

    private InputInformation _inputInformation = null;

    private ButtonInputDetector _inputDetector = null;

    private void Awake()
    {
        _inputInformation = new InputInformation(_inputButtonListSO.GetUseKeyArray());
        _inputDetector = new ButtonInputDetector(_inputInformation);
    }

    private void Update()
    {
        _inputDetector.RecognizeInput();

    }
}

