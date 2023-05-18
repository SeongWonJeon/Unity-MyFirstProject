using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private static DataManager dataManager;
    public static GameManager Instance { get { return instance; } }
    public static DataManager Data { get { return dataManager; } }

    // Awake로 gamemanager가 무조건 하나만 남도록 하며 하나만 사용할 수 있게 추가로 생성하면 바로 삭제됨
    private void Awake()
    {
        // 인스턴스가 null이 아니면
        if (instance != null)
        {
            // 얘 지워줘
            Destroy(this);
            return;
        }
        // 씬을 전환해도 사라지지 않도록 유지
        DontDestroyOnLoad(this);
        // null이이면
        instance = this;
        InitManagers();
    }
    // Gamemanager를 전부 삭제했을 시
    private void OnDestroy()
    {
        // 삭제한 인스턴스가 this와 같다면
        if (instance == this)
        {
            // 현재 instance를 null로 설정
            instance = null;
        }
    }
    private void InitManagers()
    {
        GameObject dataObj = new GameObject() { name = "DataManager" };
        dataObj.transform.SetParent(transform);
        dataManager = dataObj.AddComponent<DataManager>();
    }
}

