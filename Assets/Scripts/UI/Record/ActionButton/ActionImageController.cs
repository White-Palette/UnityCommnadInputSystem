using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionImageController : BaseImageController<string>
{
    [SerializeField]
    private Sprite[] _buttonSprites = null;

    public override void SetImage(string eventType)
    {
        CommandImage.sprite = _buttonSprites[0];

        gameObject.SetActive(true);
    }
}
