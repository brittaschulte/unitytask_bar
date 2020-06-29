using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// shows a circle when the cursor is on this object
/// </summary>
public class SelectionCircle : MonoBehaviour
{
    public GameObject circle;

    void OnMouseOver()
    {
        circle.SetActive(true);
    }

    void OnMouseExit()
    {
        circle.SetActive(false);
    }
}
