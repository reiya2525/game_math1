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
            return false; // ���鐔�A�܂��͊����鐔���Ȃ��ꍇ
        }

        int divisor = answer[0];  // ���鐔 (answer �̐擪)
        int dividend = question[0]; // �����鐔 (question �̐擪)

        if (dividend % divisor == 0) // ����؂��ꍇ
        {
            question.RemoveAt(0); // `question` �̐擪���폜
            answer.RemoveAt(0);   // `answer` �̐擪���폜

            if (question2.Count > 0)
            {
                question2.RemoveAt(0); // `question2` �����킹�č폜
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
