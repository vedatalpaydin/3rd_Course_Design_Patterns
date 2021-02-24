using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (fileName = "New Event",menuName = "Game Event", order = 52)]
public class Event : ScriptableObject
{
    private List<EventListener> eListeners = new List<EventListener>();

    public void Register(EventListener listener)
    {
        eListeners.Add(listener);
    }

    public void UnRegister(EventListener listener)
    {
        eListeners.Remove(listener);
    }

    public void Occured()
    {
        for (int i = 0; i < eListeners.Count; i++)
        {
            eListeners[i].OnEventOccurs();
        }
    }
}
