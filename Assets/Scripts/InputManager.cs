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
    private int _pressingKeyCount = 0;

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
        _pressingKeyCount = 0;

        for (int i = 0; i < _useKeyArray.Length; ++i)
        {
            KeyCode checkedKeyCode = _useKeyArray[i].keyCode;
            KeyState checkedKeyState = _useKeyArray[i].state;

            if (Input.GetKeyDown(checkedKeyCode))
            {
                _useKeyArray[i].state = KeyState.Down;
                ++_pressingKeyCount;
            }
            else if (Input.GetKeyUp(checkedKeyCode))
            {
                _useKeyArray[i].state = KeyState.Up;
            }
            else if (checkedKeyState == KeyState.Down)
            {
                _useKeyArray[i].state = KeyState.Press;
                ++_pressingKeyCount;
            }
            else if (checkedKeyState == KeyState.Press)
            {
                ++_pressingKeyCount;
            }
            else if (checkedKeyState == KeyState.Up)
            {
                _useKeyArray[i].state = KeyState.None;
            }
        }

        bool isAllUp = true;
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

            // 여기 조건 약간 변경해야 될듯
            isAllPress = isAllPress && keyCodes.Length == _pressingKeyCount;

            if (isAllPress)
            {
                isAllUp = false;
                Debug.Log(inputKey.EventName);
                InputEventManager.ExecuteEvent(inputKey.EventName);
            }
        }

        if (isAllUp)
        {
            _inputKeyRecordUI.InputDirectionKey(Direction.Neutral);
        }
    }
}

public struct Key
{
    public KeyCode keyCode;
    public KeyState state;
}
