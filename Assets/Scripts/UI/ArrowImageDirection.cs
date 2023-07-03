using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowImageDirection : MonoBehaviour
{
    private InputEvent _direction = InputEvent.Neutral;

    public void SetDirection(InputEvent direction)
    {
        this._direction = direction;

        switch (_direction)
        {
            case InputEvent.LeftDown:
                transform.rotation = Quaternion.Euler(0, 0, 225);
                break;
            case InputEvent.Down:
                transform.rotation = Quaternion.Euler(0, 0, 270);
                break;
            case InputEvent.RightDown:
                transform.rotation = Quaternion.Euler(0, 0, 315);
                break;
            case InputEvent.Left:
                transform.rotation = Quaternion.Euler(0, 0, 180);
                break;
            case InputEvent.Neutral:
                GetComponent<Image>().enabled = false;
                break;
            case InputEvent.Right:
                transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case InputEvent.LeftUp:
                transform.rotation = Quaternion.Euler(0, 0, 135);
                break;
            case InputEvent.Up:
                transform.rotation = Quaternion.Euler(0, 0, 90);
                break;
            case InputEvent.RightUp:
                transform.rotation = Quaternion.Euler(0, 0, 45);
                break;
        }

        gameObject.SetActive(true);
    }
}
