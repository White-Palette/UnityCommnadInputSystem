using System;
using System.Collections.Generic;

public static class InputEventManager
{
    private static Dictionary<Direction, List<Action>> _directionEventDictionary = new Dictionary<Direction, List<Action>>();

    public static void AddEvent(Direction direction, Action action)
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

    public static void RemoveEvent(Direction direction, Action action)
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

    public static void ExecuteEvent(Direction direction)
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
