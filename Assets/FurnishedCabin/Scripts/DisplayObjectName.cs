using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayObjectName : MonoBehaviour
{
    public TextMeshProUGUI tagName;

    public GameObject nameDisplay;

    // Update is called once per frame
    public void displayTagName()
    {
            nameDisplay.gameObject.SetActive(true);
            tagName.text = "This is a " + gameObject.tag;
    }

}
