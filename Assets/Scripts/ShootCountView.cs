using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShootCountView : MonoBehaviour
{
    // UI에 데이터(모델)을 포함하지말자

    // View는 무조건 보여주는 목적으로만 하자

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
