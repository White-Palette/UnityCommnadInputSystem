using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionImageController : BaseImageController<string>
{
    [SerializeField]
    private Sprite[] _buttonSprites = null;

    public override void SetImage(string eventType)
    {
        switch (eventType)
        {
            case "LP":
                CommandImage.sprite = _buttonSprites[0];
                break;
            case "RP":
                CommandImage.sprite = _buttonSprites[1];
                break;
            case "LK":
                CommandImage.sprite = _buttonSprites[2];
                break;
            case "RK":
                CommandImage.sprite = _buttonSprites[3];
                break;
        }

        gameObject.SetActive(true);
    }
}
