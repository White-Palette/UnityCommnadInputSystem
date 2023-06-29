using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class InputEventManager
{
    private static Dictionary<Direction, Action> _directionEventDictionary = new Dictionary<Direction, Action>();

    public static void AddEvent(Direction direction, Action action)
    {
        if (_directionEventDictionary.ContainsKey(direction))
        {
            _directionEventDictionary[direction] += action;
        }
        else
        {
            _directionEventDictionary.Add(direction, action);
        }
    }

    public static void RemoveEvent(Direction direction, Action action)
    {
        if (_directionEventDictionary.ContainsKey(direction))
        {
            _directionEventDictionary[direction] -= action;
        }
    }

    public static void ExecuteEvent(Direction direction)
    {
        if (_directionEventDictionary.ContainsKey(direction))
        {
            _directionEventDictionary[direction]?.Invoke();
        }
    }
}
