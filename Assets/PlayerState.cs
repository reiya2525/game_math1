using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour
{
    public Queue<int> answer;
    public Queue<int> question;
    public List<List<int>> question2;

    void Awake() // Start ‚Å‚Í‚È‚­ Awake ‚ðŽg—p
    {
        answer = new Queue<int>();
        question = new Queue<int>();
        question2 = new List<List<int>>();
    }

    public void Enter(int value)
    {
        answer.Enqueue(value);
    }

    public bool Divide()
    {
        if (answer.Count == 0 || question.Count == 0)
        {
            return false; // Š„‚é”A‚Ü‚½‚ÍŠ„‚ç‚ê‚é”‚ª‚È‚¢ê‡
        }

        int divisor = answer.Peek();
        int dividend = question.Peek();

        if (dividend % divisor == 0)
        {
            question.Dequeue();
            answer.Dequeue();

            if (question2.Count > 0)
            {
                question2.RemoveAt(0);
            }

            return true;
        }
        return false;
    }
}



