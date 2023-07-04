using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputArrowKeyRecordUI : MonoBehaviour
{
    [SerializeField]
    private GameObject _inputKeyPrefab = null;

    private Queue<DirectionImageController> _inputKeyQueue = new Queue<DirectionImageController>();

    private void Awake()
    {
        InputEventManager.AddEvent(Direction.Up, () => InputDirectionKey(Direction.Up));
        InputEventManager.AddEvent(Direction.Down, () => InputDirectionKey(Direction.Down));
        InputEventManager.AddEvent(Direction.Left, () => InputDirectionKey(Direction.Left));
        InputEventManager.AddEvent(Direction.Right, () => InputDirectionKey(Direction.Right));
        InputEventManager.AddEvent(Direction.LeftUp, () => InputDirectionKey(Direction.LeftUp));
        InputEventManager.AddEvent(Direction.LeftDown, () => InputDirectionKey(Direction.LeftDown));
        InputEventManager.AddEvent(Direction.RightUp, () => InputDirectionKey(Direction.RightUp));
        InputEventManager.AddEvent(Direction.RightDown, () => InputDirectionKey(Direction.RightDown));

        InputEventManager.AddEvent(Direction.Neutral, () => InputDirectionKey(Direction.Neutral));
    }

    public void InputDirectionKey(Direction direction)
    {
        var keyUI = Instantiate(_inputKeyPrefab, transform).GetComponent<DirectionImageController>();
        keyUI.SetDirection(direction);
        _inputKeyQueue.Enqueue(keyUI);

        if (_inputKeyQueue.Count > 32)
        {
            var key = _inputKeyQueue.Dequeue();
            Destroy(key.gameObject);
        }
    }
}
