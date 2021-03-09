using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addNumbers : MonoBehaviour
{
    public InputField num1_if;
    public InputField num2_if;
    public Text result;

    public void AddNumbersOnClick()
    {
        float num1 = float.Parse(num1_if.text);
        float num2 = float.Parse(num2_if.text);
        float addResult = num1 + num2;
        result.text = addResult.ToString();
    }
}
