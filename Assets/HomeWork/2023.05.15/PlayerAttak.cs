using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttak : MonoBehaviour
{
    [SerializeField] private Transform firePosition;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] public float RepeatTime;
    private Coroutine coroutinebullet;

    private void OnFire(InputValue value)
    {
        Instantiate(bulletPrefab, firePosition.position, transform.rotation);
    }
    private void OnRepeat(InputValue value)
    {
            if (value.isPressed)
                coroutinebullet = StartCoroutine(BulletCoroutine());
            else
                StopCoroutine(coroutinebullet);
    }
    IEnumerator BulletCoroutine()
    {
        while (true)
        {
            Instantiate(bulletPrefab, firePosition.position, transform.rotation);
            yield return new WaitForSeconds(RepeatTime);
        }
    }
}
