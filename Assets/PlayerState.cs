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
            return false; // äÑÇÈêîÅAÇ‹ÇΩÇÕäÑÇÁÇÍÇÈêîÇ™Ç»Ç¢èÍçá
        }

        int divisor = answer[0];  // äÑÇÈêî (answer ÇÃêÊì™)
        int dividend = question[0]; // äÑÇÁÇÍÇÈêî (question ÇÃêÊì™)

        if (dividend % divisor == 0) // äÑÇËêÿÇÍÇÈèÍçá
        {
            question.RemoveAt(0); // `question` ÇÃêÊì™ÇçÌèú
            answer.RemoveAt(0);   // `answer` ÇÃêÊì™ÇçÌèú

            if (question2.Count > 0)
            {
                question2.RemoveAt(0); // `question2` Ç‡çáÇÌÇπÇƒçÌèú
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
