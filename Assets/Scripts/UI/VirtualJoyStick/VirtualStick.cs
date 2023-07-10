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
        InputEventManager.AddEvent("1", () => MoveStick(-_moveDistance, -_moveDistance));
        InputEventManager.AddEvent("2", () => MoveStick(0f, -_moveDistance));
        InputEventManager.AddEvent("3", () => MoveStick(_moveDistance, -_moveDistance));
        InputEventManager.AddEvent("4", () => MoveStick(-_moveDistance, 0f));
        InputEventManager.AddEvent("6", () => MoveStick(_moveDistance, 0f));
        InputEventManager.AddEvent("7", () => MoveStick(-_moveDistance, _moveDistance));
        InputEventManager.AddEvent("8", () => MoveStick(0f, _moveDistance));
        InputEventManager.AddEvent("9", () => MoveStick(_moveDistance, _moveDistance));

        InputEventManager.AddEvent("N", () => MoveStick(0f, 0f));
    }

    public void MoveStick(float posX, float posY)
    {
        _stick.localPosition = new Vector3(posX, posY, 0f);
    }
}
