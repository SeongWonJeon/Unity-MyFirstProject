using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    private static DataManager dataManager;
    public static GameManager Instance { get { return instance; } }
    public static DataManager Data { get { return dataManager; } }

    // Awake�� gamemanager�� ������ �ϳ��� ������ �ϸ� �ϳ��� ����� �� �ְ� �߰��� �����ϸ� �ٷ� ������
    private void Awake()
    {
        // �ν��Ͻ��� null�� �ƴϸ�
        if (instance != null)
        {
            // �� ������
            Destroy(this);
            return;
        }
        // ���� ��ȯ�ص� ������� �ʵ��� ����
        DontDestroyOnLoad(this);
        // null���̸�
        instance = this;
        InitManagers();
    }
    // Gamemanager�� ���� �������� ��
    private void OnDestroy()
    {
        // ������ �ν��Ͻ��� this�� ���ٸ�
        if (instance == this)
        {
            // ���� instance�� null�� ����
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

