using UnityEngine;

public class TestPlayerState : MonoBehaviour
{
    private PlayerState playerState;

    void Start()
    {
        // PlayerState コンポーネントを取得
        playerState = GetComponent<PlayerState>();

        // 動作確認のためのデータをセット
        playerState.Enter(2);
        playerState.Enter(11);
        playerState.Enter(3);

        playerState.question.Add(22);
        playerState.question.Add(36);
        playerState.question.Add(12);

        Debug.Log("Before Divide:");
        Debug.Log("answer = " + string.Join(", ", playerState.answer));
        Debug.Log("question = " + string.Join(", ", playerState.question));

        // Divide() を実行して確認
        bool result1 = playerState.Divide();
        Debug.Log("After 1st Divide: " + result1);
        Debug.Log("answer = " + string.Join(", ", playerState.answer));
        Debug.Log("question = " + string.Join(", ", playerState.question));

        bool result2 = playerState.Divide();
        Debug.Log("After 2nd Divide: " + result2);
        Debug.Log("answer = " + string.Join(", ", playerState.answer));
        Debug.Log("question = " + string.Join(", ", playerState.question));
    }
}
