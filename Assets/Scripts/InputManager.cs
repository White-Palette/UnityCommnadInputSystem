using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private InputKeyRecordUI _inputKeyRecordUI = null;

    [SerializeField]
    private InputKeyListSO _inputKeyListSO = null;

    private Key[] _useKeyArray = null;

    void Awake()
    {
        var useKeyCodeArray = _inputKeyListSO.GetUseKeyArray();
        _useKeyArray = new Key[useKeyCodeArray.Length];

        for (int i = 0; i < useKeyCodeArray.Length; ++i)
        {
            _useKeyArray[i].keyCode = useKeyCodeArray[i];
            _useKeyArray[i].state = KeyState.None;
        }
    }

    private void Update()
    {
        for (int i = 0; i < _useKeyArray.Length; ++i)
        {
            KeyCode checkedKeyCode = _useKeyArray[i].keyCode;
            KeyState checkedKeyState = _useKeyArray[i].state;

            if (Input.GetKeyDown(checkedKeyCode))
            {
                _useKeyArray[i].state = KeyState.Down;
            }
            else if (Input.GetKeyUp(checkedKeyCode))
            {
                _useKeyArray[i].state = KeyState.Up;
            }
            else if (checkedKeyState == KeyState.Down)
            {
                _useKeyArray[i].state = KeyState.Press;
            }
            else if (checkedKeyState == KeyState.Up)
            {
                _useKeyArray[i].state = KeyState.None;
            }
        }

        for (int i = 0; i < _inputKeyListSO.Length; ++i)
        {
            InputKey inputKey = _inputKeyListSO.inputKeys[i];

            KeyCode[] keyCodes = inputKey.keyCodes;
            bool isAllPress = true;
            for (int j = 0; j < keyCodes.Length; ++j)
            {
                KeyCode keyCode = keyCodes[j];
                KeyState keyState = _useKeyArray.First(x => x.keyCode == keyCode).state;

                if ((int)keyState >= 2)
                {
                    isAllPress = false;
                    break;
                }
            }

            if (isAllPress)
            {
                _inputKeyRecordUI.InputDirectionKey(inputKey.EventName);
            }
        }
    }
}

public struct Key
{
    public KeyCode keyCode;
    public KeyState state;
}