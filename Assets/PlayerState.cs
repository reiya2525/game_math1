using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerState : MonoBehaviour
{
    public List<int> answer;
    public List<int> question;
    public List<List<int>> question2;



    // Start is called before the first frame update
    void Start()
    {
        answer = new List<int>();
        question = new List<int>();
        question2 = new List<List<int>>();
    }
    public void Enter(int value)
    {
        answer.Add(value);
    }
    public bool Divide()
    {
        if (answer.Count == 0 || question.Count == 0)
        {
            return false; // 割る数、または割られる数がない場合
        }

        int divisor = answer[0];  // 割る数 (answer の先頭)
        int dividend = question[0]; // 割られる数 (question の先頭)

        if (dividend % divisor == 0) // 割り切れる場合
        {
            question.RemoveAt(0); // `question` の先頭を削除
            answer.RemoveAt(0);   // `answer` の先頭を削除

            if (question2.Count > 0)
            {
                question2.RemoveAt(0); // `question2` も合わせて削除
            }

            return true;
        }
        return false;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
