using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UltimateXR;
using UltimateXR.Manipulation;
using System;
using UnityEngine.Events;

public class UXRGrabEvents : MonoBehaviour
{
    public UnityEvent onGrab, onRelease;
    private UxrGrabbableObject _grab;

    private void Start()
    {
        _grab = GetComponent<UxrGrabbableObject>();
        _grab.Grabbed += OnGrabbed;
    }

    private void OnGrabbed(object sender = null, UxrManipulationEventArgs e = null)
    {
        onGrab?.Invoke();
    }


    private void OnReleased(object sender = null, UxrManipulationEventArgs e = null)
    {
        onRelease?.Invoke();
    }





    [ContextMenu("Editor Force onGrabbed")]
    void testGrab()
    {
        OnGrabbed();
    }


    [ContextMenu("Editor Force onReleased")]
    void testReleased()
    {
        OnReleased();
    }
}