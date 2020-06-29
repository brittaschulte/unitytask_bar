using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitBox : MonoBehaviour
{
    public Pickable item;
    public Counter counter;

    void OnMouseDown()
    {
        counter.addItem(item);
    }
}
