using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// the counter class stores and manages the chosen items
/// </summary>
public class Counter : MonoBehaviour
{
    List<Pickable> pickedItems;

    public Transform[] itemSlots;

    public GameObject[] fruitBaskets;


    public GameObject registerText;

    private void Start()
    {
        pickedItems = new List<Pickable>();
    }

    /// <summary>
    /// adds a pickable item to the item list and instantiates it within the scene
    /// </summary>
    /// <param name="item">the chosen item</param>
    public void addItem(Pickable item)
    {
        if(pickedItems.Count < 5)
        { 
            Transform itemSlot = itemSlots[pickedItems.Count];
            Pickable newItem = Instantiate(item, itemSlot);
            pickedItems.Add(newItem);
            registerText.GetComponent<TextMeshPro>().text = getTotal().ToString();

            if(pickedItems.Count == 5)
            {
                disableBaskets();
            }
        }
        
    }

    private void disableBaskets()
    {
        foreach (GameObject go in fruitBaskets)
        {
            go.GetComponent<Collider>().enabled = false;
        }
    }

    /// <summary>
    /// adds up the prices of all stored items and returns the total price
    /// </summary>
    /// <returns></returns>
    public float getTotal()
    {
        float total = 0;

        foreach (Pickable item in pickedItems)
        {
            total += item.price;
        }

        return total;
    }

    /// <summary>
    /// returns the nr of stored items
    /// </summary>
    /// <returns></returns>
    public int getItemCount()
    {
        return pickedItems.Count;
    }

    /// <summary>
    /// returns names of all stored items, in a list formatted to fit inside the speech bubble
    /// </summary>
    /// <returns></returns>
    public string itemListToFormattedString()
    {
        string list = "";

        if(pickedItems.Count > 0)
        {
            foreach (Pickable item in pickedItems)
            {
                list += item.itemName + "\n";
            }
        }
        else
        {
            list = "no items.\n";
        }

        return list;
    }


}
