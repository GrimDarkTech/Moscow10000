using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

[Serializable]
public class Dialogue
{
    public string characterName;
    [SerializeField]
    private string text;
    public string textByChar;

    public List<Answer> answers = new List<Answer>(); 

    public void SetText(string text)
    {
        this.text = text;
        this.textByChar = "";
    }

    public IEnumerator ReadTextByChar(float delay)
    {
        this.textByChar = "";
        yield return new WaitForSeconds(0.01f);
        foreach (char c in text)
        {
            yield return new WaitForSeconds(delay);
            this.textByChar += c;
        }
    }
}

[Serializable]
public class Answer
{
    public string text;
    [SerializeField]
    private UnityEvent onSelected;

}