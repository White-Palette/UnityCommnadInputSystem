using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField]
    private InputKeyRecordUI _inputKeyRecordUI = null;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _inputKeyRecordUI.InputDirectionKey(Direction.Left);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            _inputKeyRecordUI.InputDirectionKey(Direction.Right);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            _inputKeyRecordUI.InputDirectionKey(Direction.Up);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            _inputKeyRecordUI.InputDirectionKey(Direction.Down);
        }
        else
        {
            _inputKeyRecordUI.InputDirectionKey(Direction.Neutral);
        }
    }
}
