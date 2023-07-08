using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionImageController : ImageBaseController<Direction>
{
    [SerializeField]
    private Sprite[] _buttonSprites = null;

    public override void SetImage(Direction eventType)
    {
        

        gameObject.SetActive(true);
    }
}
