using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class InputProcessor : InputInformationEditor
{
    public InputProcessor(InputInformation inputInformation, InputButtonListSO inputKeyListSO, CommandListSO commandListSO) : base(inputInformation)
    {
        _inputKeyListSO = inputKeyListSO;
        _commandListSO = commandListSO;
    }

    private InputButtonListSO _inputKeyListSO = null;
    private CommandListSO _commandListSO = null;

    private Stack<Direction> _inputEventStack = new Stack<Direction>();

    public void Process()
    {
        CheckInputKey();
    }

    private void CheckInputKey()
    {
        if (InputInformation.IsInputChanged)
        {
            CheckCommand();
        }
    }

    private void CheckCommand()
    {
        bool isAllUp = true;

        for (int i = 0; i < _inputKeyListSO.Length; ++i)
        {
            InputButton inputButton = _inputKeyListSO.inputKeys[i];

            KeyCode[] keyCodes = inputButton.keyCodes;
            bool isAllPress = true;
            for (int j = 0; j < keyCodes.Length; ++j)
            {
                KeyCode keyCode = keyCodes[j];
                KeyState keyState = InputInformation.GetKeyState(keyCode);

                if ((int)keyState >= 2)
                {
                    isAllPress = false;
                    break;
                }
            }

            // 여기 조건 약간 변경해야 될듯
            isAllPress = isAllPress && keyCodes.Length == InputInformation.PressingKeyCount;

            if (isAllPress)
            {
                isAllUp = false;
                InputEventManager.ExecuteEvent(inputButton.EventName);
                _inputEventStack.Push(inputButton.EventName);
                break;
            }
        }

        // command 입력 확인하는 코드
        for (int j = 0; j < _commandListSO.commands.Length; ++j)
        {
            var stackTemp = new Stack<Direction>(_inputEventStack);
            List<Direction> inputEventList = new List<Direction>();

            int count = stackTemp.Count;

            for (int i = 0; i < _commandListSO.commands[j].InputKeys.Length; ++i)
            {
                if (count < _commandListSO.commands[j].InputKeys.Length)
                {
                    break;
                }
                inputEventList.Add(stackTemp.Pop());
            }

            if (inputEventList.SequenceEqual(_commandListSO.commands[j].InputKeys))
            {
                Debug.Log(_commandListSO.commands[j].CommandName);
                _inputEventStack.Clear();
            }
        }

        if (isAllUp)
        {
            InputEventManager.ExecuteEvent(Direction.Neutral);
        }
    }
}
