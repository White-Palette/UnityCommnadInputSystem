using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualButton : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _buttonInputEffects = null;

    private void Start()
    {

    }

    private void UpdateButtonInputState()
    {
        for (int i = 0; i < _buttonInputEffects.Length; i++)
        {
            _buttonInputEffects[i].SetActive(true);
        }
    }
}
