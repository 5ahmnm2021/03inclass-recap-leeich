using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class addNumbers : MonoBehaviour
{
    public InputField num1_in;
    public InputField num2_in;
    float num1;
    float num2;
    public Text result;
    bool correctIn1 = false;
    bool correctIn2 = false;

    public void AddNumbersOnClick()
    {
     try
        {
            num1 = float.Parse(num1_in.text);
            correctIn1 = true;
        }
        catch (System.Exception)
        {
            num1_in.image.color = new Color32(255,0,0,100);
            correctIn1 = false;
            StartCoroutine(ResetCoroutine());
        }

        try
        {
            num2 = float.Parse(num2_in.text);
            correctIn2 = true;
        }
        catch (System.Exception)
        {
            num2_in.image.color = new Color32(255,0,0,100);
            correctIn2 = false;
            StartCoroutine(ResetCoroutine());
        }
        
        if (correctIn1 && correctIn2)
        {
            float addResult = num1 + num2;
            result.text = addResult.ToString();
        }
        else
        {
            result.text = "Wrong input";
        }

        IEnumerator ResetCoroutine()
        {
        yield return new WaitForSeconds(3);
        num2_in.image.color = new Color32(255,255,255,100);
        num1_in.image.color = new Color32(255,255,255,100);
        result.text = "...";
        num1_in.text = "...";
        num2_in.text = "...";
        }

    }
        
}

