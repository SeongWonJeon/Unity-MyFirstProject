using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameSetting : MonoBehaviour
{
    // ����Ƽ�� ���ӽ������ڸ��� �Լ��� ���ٸ�
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Init()
    {
        // ������ �����ϱ� �� �ʿ��� �������� ���⼭ ����
        // ������ �����ߴµ� �����ϱ� �� �ʿ��� ���ӸŴ����� ���̸�
        if (GameManager.Instance == null)
        {
            // ���ӸŴ����� ������Ʈ�� ���������
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
