using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    public float price;
    public string itemName;

    public Counter counter;

    void OnMouseDown()
    {
        counter.addItem(this);
    }
}
