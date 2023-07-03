using System;
using System.Collections.Generic;

public static class InputEventManager
{
    private static Dictionary<InputEvent, List<Action>> _directionEventDictionary = new Dictionary<InputEvent, List<Action>>();

    public static void AddEvent(InputEvent direction, Action action)
    {
        if (_directionEventDictionary.TryGetValue(direction, out var eventList))
        {
            eventList.Add(action);
        }
        else
        {
            eventList = new List<Action>() { action };
            _directionEventDictionary.Add(direction, eventList);
        }
    }

    public static void RemoveEvent(InputEvent direction, Action action)
    {
        if (_directionEventDictionary.TryGetValue(direction, out var eventList))
        {
            eventList.Remove(action);
            if (eventList.Count == 0)
            {
                _directionEventDictionary.Remove(direction);
            }
        }
    }

    public static void ExecuteEvent(InputEvent direction)
    {
        if (_directionEventDictionary.TryGetValue(direction, out var eventList))
        {
            foreach (var action in eventList)
            {
                action?.Invoke();
            }
        }
    }
}
