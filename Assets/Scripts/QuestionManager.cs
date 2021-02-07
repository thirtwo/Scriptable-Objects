using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Scripts/QuestionManager")] // Attribute for component menu.
public class QuestionManager : MonoBehaviour
{
    //[SerializeField] private ScriptableText[] scriptableTexts; This method use array index. Keeping all scriptable objects in an array. Increasing array index and using it.  
    //[SerializeField] private int Scriptable_Index = 0;
    [SerializeField] private ScriptableText scriptableText;
    [SerializeField] private Text questionText;
    [SerializeField] private Text answer0Button;
    [SerializeField] private Text answer1Button;
    [SerializeField] private GameObject answer0GO;
    [SerializeField] private GameObject answer1GO;
    private string question;
    private string answer0;
    private string answer1;
    private int answer0Price;
    private int answer1Price;
    public int bonusPrice = 0;


    void Start()
    {
        QuestionPrepare();
    }

    public void NextQuestionButtonLeft()
    {
        //if (Scriptable_Index < scriptableTexts.Length-1)
        //{
        //    bonusPrice += answer1Price;
        //    Scriptable_Index++;
        //    QuestionPrepare();
        //}
        if (scriptableText.NextQuestion() != null)
        {
            bonusPrice += answer1Price;
            scriptableText = scriptableText.NextQuestion();
            QuestionPrepare();
        }
        else
        {
            answer0GO.SetActive(false);
            answer1GO.SetActive(false);
            bonusPrice += answer1Price;
            questionText.text = "You have earned " + bonusPrice + "$";
        }
    }
    public void NextQuestionButtonRight()
    {
        //if (Scriptable_Index < scriptableTexts.Length - 1)
        //{
        //    bonusPrice += answer0Price;
        //    Scriptable_Index++;
        //    QuestionPrepare();
        //}
        if (scriptableText.NextQuestion() != null)
        {
            bonusPrice += answer0Price;
            scriptableText = scriptableText.NextQuestion();
            QuestionPrepare();
        }
        else
        {
            answer0GO.SetActive(false);
            answer1GO.SetActive(false);
            bonusPrice += answer0Price;
            questionText.text = "You have earned " + bonusPrice + "$";
        }
    }

    private void QuestionPrepare()
    {
        //question = scriptableTexts[Scriptable_Index].question;
        //answer0 = scriptableTexts[Scriptable_Index].Answer0;
        //answer1 = scriptableTexts[Scriptable_Index].Answer1;
        //answer0Price = scriptableTexts[Scriptable_Index].Answer0Price;
        //answer1Price = scriptableTexts[Scriptable_Index].Answer1Price;
        question = scriptableText.question;
        answer0 = scriptableText.Answer0;
        answer1 = scriptableText.Answer1;
        answer0Price = scriptableText.Answer0Price;
        answer1Price = scriptableText.Answer1Price;
        questionText.text = question;
        answer0Button.text = answer0;
        answer1Button.text = answer1;
    }
}
