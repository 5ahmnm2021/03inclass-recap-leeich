using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorChanger : MonoBehaviour
{
    public GameObject color;

    public void ChangeColor()
    {
        Color[] colors =
        {
            new Color32(255,205,25,100),
            new Color32(95,34,0,100),
            new Color32(207,63,21,100),
            new Color32(102,47,84,100)
        };

        if (Input.GetKeyDown("space"))
        {
            color.GetComponent<Image>().color = colors[Random.Range(0, colors.Length)];
        }
    }

    void Update()
    {
        ChangeColor();
    }
}