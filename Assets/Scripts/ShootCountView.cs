using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShootCountView : MonoBehaviour
{
    // UI�� ������(��)�� ������������

    // View�� ������ �����ִ� �������θ� ����

    // TMP = TextMeshPro
    private TMP_Text textView;

    private void Awake()
    {
        textView = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        GameManager.Data.OnShootCountChanged += ChangeText;
    }
    /*private void OnDisable()
    {
        GameManager.Data.OnShootCountChanged -= ChangeText;
    }*/

    private void ChangeText(int count)
    {
        textView.text = count.ToString();
    }
}