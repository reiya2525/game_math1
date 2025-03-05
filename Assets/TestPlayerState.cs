using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPlayerState : MonoBehaviour
{
    private PlayerState playerState;

    void Start()
    {
        // PlayerStateコンポーネントをアタッチ
        playerState = gameObject.AddComponent<PlayerState>();

        // テストデータの設定
        playerState.Enter(2);
        playerState.Enter(3);
        playerState.Enter(11);

        playerState.question.Enqueue(22);
        playerState.question.Enqueue(36);
        playerState.question.Enqueue(12);

        playerState.question2.Add(new List<int> { 2, 11 });
        playerState.question2.Add(new List<int> { 2, 2, 3, 3 });
        playerState.question2.Add(new List<int> { 2, 2, 3 });

        Debug.Log("Initial State:");
        PrintState();

        // Divide を実行
        Debug.Log("Performing Divide...");
        while (playerState.Divide())
        {
            PrintState();
        }
    }

    void PrintState()
    {
        Debug.Log("Answer Queue: " + string.Join(", ", playerState.answer));
        Debug.Log("Question Queue: " + string.Join(", ", playerState.question));

        string question2Content = "";
        foreach (var list in playerState.question2)
        {
            question2Content += "{" + string.Join(", ", list) + "} ";
        }
        Debug.Log("Question2 List: " + question2Content);
    }
}
