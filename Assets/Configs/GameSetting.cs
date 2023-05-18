using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameSetting : MonoBehaviour
{
    // 유니티가 게임시작하자마나 함수가 없다면
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Init()
    {
        // 게임을 시작하기 전 필요한 설정들을 여기서 진행
        // 게임을 시작했는데 시작하기 전 필요한 게임매니저가 널이면
        if (GameManager.Instance == null)
        {
            // 게임매니저를 오브잭트로 만들어주자
            GameObject gameManager = new GameObject() { name = "GameManager" };
            gameManager.AddComponent<GameManager>();
        }
    }


    /*[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Init()
    {
        InitGameManager();
    }

    private static void InitGameManager()
    {
        if (GameManager.Instance == null)
        {
            GameObject gameManager = new GameObject() { name = GameManager.DefaultName };
            gameManager.AddComponent<GameManager>();
        }
    }*/
}
