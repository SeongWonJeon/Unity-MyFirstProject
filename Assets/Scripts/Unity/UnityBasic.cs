using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEditor.SceneManagement;
using UnityEngine;

public class UnityBasic : MonoBehaviour
{
    public GameObject thisGameObject;
    public AudioSource audioSource;
    public void Start()
    {
        GameObjectBasic();
        ComponentBasic();
    }

    public void GameObjectBasic()
    {
        // <���ӿ�����Ʈ ����>
        // ������Ʈ�� �پ��ִ� ���ӿ�����Ʈ�� gameObject �Ӽ��� �̿��Ͽ� ���ٰ���
        // gameObject.name;                // ���ӿ�����Ʈ�� �̸� ����
        // gameObject.activeSelf;          // ���ӿ�����Ʈ�� Ȱ��ȭ ���� ����
        // gameObject.tag;                 // ���ӿ�����Ʈ�� �±� ����
        // gameObject.layer;               // ���ӿ�����Ʈ�� ���̾� ����

        // <�� ���� ���ӿ�����Ʈ Ž��>
        // thisGameObject = GameObject.Find("player");           // �̸����� ã��
        // thisGameObject = GameObject.FindGameObjectWithTag("MyTag");    // �±׷� �ϳ� ã��
        // thisGameObject = GameObject.FindGameObjectsWithTag(");    // �±׷� �ϳ� ã��

        // <���ӿ�����Ʈ ����>
        GameObject newGameObject = new GameObject("New Game Object");   // �Ʒ��� �ٿ��� ()�ȿ� ������ �ٷ� �����Ѵ�.
        newGameObject.name = "New Game Object";

        // <���ӿ�����Ʈ ����>
        Destroy(thisGameObject, 3f); // ������ ������Ʈ��, �ð�

    }
    public void ComponentBasic()
    {
        // <���ӿ�����Ʈ �� ������Ʈ ����>
        // GetComponent�� �̿��Ͽ� ���ӿ�����Ʈ �� ������Ʈ ����
        audioSource = GetComponent<AudioSource>();
        // ������Ʈ���� GetComponent�� ����� ��� �����Ǿ� �ִ� ���ӿ�����Ʈ�� �������� ����
        audioSource = gameObject.GetComponent<AudioSource>(); // ���ӿ�����Ʈ �������� ������Ʈ ����
        GetComponent<AudioSource>();                    // �ڽ� ���ӿ�����Ʈ ���� ������Ʈ ����
        GetComponents<AudioSource>();                   // �ڽ� ���ӿ�����Ʈ ���� ������Ʈ�� ����
        gameObject.GetComponent<AudioSource>();         // �θ� ���ӿ�����Ʈ ���� ������Ʈ ����
        gameObject.GetComponents<AudioSource>();        // �θ� ���ӿ�����Ʈ ���� ������Ʈ�� ����

        GetComponentInChildren<AudioSource>();             // �ڽİ��ӿ�����Ʈ ���� ������Ʈ ����
        GetComponentsInChildren<AudioSource>();            // �ڽİ��ӿ�����Ʈ ���� ���� ������Ʈ ����
        gameObject.GetComponentInChildren<AudioSource>();  // ���ӿ�����Ʈ�� �ڽĿ�����Ʈ�� ������Ʈ ����
        gameObject.GetComponentsInChildren<AudioSource>(); // ���ӿ�����Ʈ�� �ڽĿ�����Ʈ�� ������Ʈ�� ����

        GetComponentInParent<AudioSource>();             // �θ���ӿ�����Ʈ ���� ������Ʈ ����
        GetComponentsInParent<AudioSource>();            // �θ���ӿ�����Ʈ ���� ���� ������Ʈ ����
        gameObject.GetComponentInParent<AudioSource>();  // ���ӿ�����Ʈ�� �θ������Ʈ�� ������Ʈ ����
        gameObject.GetComponentsInParent<AudioSource>(); // ���ӿ�����Ʈ�� �θ��ڽĿ�����Ʈ�� ������Ʈ�� ����

        // <������Ʈ Ž��>
        FindObjectOfType<AudioSource>();            // ������ ������Ʈ Ž��
        FindObjectsOfType<AudioSource>();           // �� ���� ��� ������Ʈ Ž��

        // <������Ʈ �߰�>
        // Rigidbody rigid = new Rigidbody();	    // �����ϳ� �ǹ̾���, ������Ʈ�� ���ӿ�����Ʈ�� �����Ǿ� �����Կ� �ǹ̰� ����
        Rigidbody rigid = gameObject.AddComponent<Rigidbody>();		// ���ӿ�����Ʈ�� ������Ʈ �߰�

        // <������Ʈ ����>
        Destroy(GetComponent<Collider>());
    }
}
