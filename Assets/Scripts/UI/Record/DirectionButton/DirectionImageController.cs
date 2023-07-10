using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class DirectionImageController : BaseImageController<string>
{
    private string _key = string.Empty;

    public override void SetImage(string eventType)
    {
        _key = eventType;

        switch (_key)
        {
            case "1":
                transform.rotation = Quaternion.Euler(0, 0, 225);
                break;
            case "2":
                transform.rotation = Quaternion.Euler(0, 0, 270);
                break;
            case "3":
                transform.rotation = Quaternion.Euler(0, 0, 315);
                break;
            case "4":
                transform.rotation = Quaternion.Euler(0, 0, 180);
                break;
            case "N":
                CommandImage.enabled = false;
                break;
            case "6":
                transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case "7":
                transform.rotation = Quaternion.Euler(0, 0, 135);
                break;
            case "8":
                transform.rotation = Quaternion.Euler(0, 0, 90);
                break;
            case "9":
                transform.rotation = Quaternion.Euler(0, 0, 45);
                break;
        }

        gameObject.SetActive(true);
    }
}
