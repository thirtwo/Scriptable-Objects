using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableText")]
public class ScriptableText : ScriptableObject
{
    [TextArea(4, 4)] [SerializeField] private string questionText;
    [SerializeField] private string answer0;
    [SerializeField] private string answer1;
    [SerializeField] private int answer0Price;
    [SerializeField] private int answer1Price;


    public string question
    {
        get
        {
            return questionText;
        }
    }
    public string Answer0
    {
        get
        {
            return answer0;
        }
    }
    public string Answer1
    {
        get
        {
            return answer1;
        }
    }
    public int Answer0Price
    {
        get
        {
            return answer0Price;
        }
    }
    public int Answer1Price
    {
        get
        {
            return answer1Price;
        }
    }
}
