using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualStick : MonoBehaviour
{
    private const float _moveDistance = 145f;

    private RectTransform _stick = null;

    private void Awake()
    {
        _stick = transform.Find("Stick").GetComponent<RectTransform>();
    }

    private void Start()
    {
        InputEventManager.AddEvent(Direction.LeftDown, () => { });
    }

    public void MoveStick(float posX, float posY)
    {

    }
}
