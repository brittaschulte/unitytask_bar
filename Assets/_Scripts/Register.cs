using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// models the functionality of the cash register
/// </summary>
public class Register : MonoBehaviour
{
    public Counter counter;

    public GameObject speechBubble;
    public GameObject text;
    public GameObject speechBubbleBackground;

    void OnMouseDown()
    {
        resizeBubble();
        text.GetComponent<TextMeshPro>().text = "You bought:\n" + counter.itemListToFormattedString() + "Your total is: " + counter.getTotal();
        speechBubble.SetActive(true);
    }

    /// <summary>
    /// resizes the background of the speech bubble, according to the nr of items chosen
    /// </summary>
    private void resizeBubble()
    {
        if(counter.getItemCount() > 0)
        {
            speechBubbleBackground.transform.localScale = new Vector3(speechBubbleBackground.transform.localScale.x, (0.15f + counter.getItemCount() * 0.1f), speechBubbleBackground.transform.localScale.z);
        }
        else
        {
            speechBubbleBackground.transform.localScale = new Vector3(speechBubbleBackground.transform.localScale.x, 0.25f, speechBubbleBackground.transform.localScale.z);
        }
    }
}
