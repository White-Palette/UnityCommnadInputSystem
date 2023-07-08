using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualStick : MonoBehaviour
{
    private const float _moveDistance = 145f;

    private RectTransform _stick = null;

    private void Awake()
    {
        _stick = transform.GetChild(0).Find("Stick").GetComponent<RectTransform>();
    }

    private void Start()
    {
        InputEventManager.AddEvent(Direction.LeftDown, () => MoveStick(-_moveDistance, -_moveDistance) );
        InputEventManager.AddEvent(Direction.Down, () => MoveStick(0f, -_moveDistance) );
        InputEventManager.AddEvent(Direction.RightDown, () => MoveStick(_moveDistance, -_moveDistance) );
        InputEventManager.AddEvent(Direction.Left, () => MoveStick(-_moveDistance, 0f) );
        InputEventManager.AddEvent(Direction.Right, () => MoveStick(_moveDistance, 0f) );
        InputEventManager.AddEvent(Direction.LeftUp, () => MoveStick(-_moveDistance, _moveDistance) );
        InputEventManager.AddEvent(Direction.Up, () => MoveStick(0f, _moveDistance) );
        InputEventManager.AddEvent(Direction.RightUp, () => MoveStick(_moveDistance, _moveDistance) );
        
        InputEventManager.AddEvent(Direction.Neutral, () => MoveStick(0f, 0f) );
    }

    public void MoveStick(float posX, float posY)
    {
        _stick.localPosition = new Vector3(posX, posY, 0f);
    }
}
