﻿using System;
using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    public Event gEvent;
    public UnityEvent response;

    private void OnEnable()
    {
        gEvent.Register(this);
    }

    private void OnDisable()
    {
        gEvent.UnRegister(this);
    }

    public void OnEventOccurs()
    {
        response.Invoke();
    }
}
