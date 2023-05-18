using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField]private int shootCount;

    public Action<int> OnShootCountChanged;

    public void AddShootCount(int count)
    {
        shootCount += count;
        OnShootCountChanged?.Invoke(shootCount);
    }
}
