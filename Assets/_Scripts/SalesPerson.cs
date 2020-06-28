using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalesPerson : MonoBehaviour
{
    void OnMouseDown()
    {
        GetComponent<Animator>().SetTrigger("Wave");
    }
}
