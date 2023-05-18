using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShootCountViewBot : MonoBehaviour
{
    private TMP_Text textCount;

    private void Awake()
    {
        textCount = GetComponent<TMP_Text>();
    }

    private void OnEnable()
    {
        GameManager.Data.OnShootCountChanged += ChangeText;
    }
    private void OnDisable()
    {
        GameManager.Data.OnShootCountChanged -= ChangeText;
    }

    private void ChangeText(int count)
    {
        textCount.text = count.ToString();
    }
}
