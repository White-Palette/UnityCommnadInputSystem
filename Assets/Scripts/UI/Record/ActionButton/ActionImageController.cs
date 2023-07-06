using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionImageController : ImageBaseController<Direction>
{
    [SerializeField]
    private Sprite[] _buttonSprites = null;

    public override void SetImage(Direction eventType)
    {
        switch (eventType)
        {
            case Direction.LP:
                CommandImage.sprite = _buttonSprites[0];
                break;
            case Direction.RP:
                CommandImage.sprite = _buttonSprites[1];
                break;
            case Direction.LK:
                CommandImage.sprite = _buttonSprites[2];
                break;
            case Direction.RK:
                CommandImage.sprite = _buttonSprites[3];
                break;
        }

        gameObject.SetActive(true);
    }
}
