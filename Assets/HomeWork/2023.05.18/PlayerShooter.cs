using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class PlayerShooter : MonoBehaviour
{
    [SerializeField] private Transform bulletPoint;
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float coolDownTime;
    private bool canFire = true;
    private Animator animator;
    public UnityEvent OnFired;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void Fire()
    {
        if (canFire)
        {
            Instantiate(bulletPrefab, bulletPoint.position, bulletPoint.rotation);
            animator.SetTrigger("Fire");
            StartCoroutine(WaitForIt());
            GameManager.Data.AddShootCount(1);
        }
        OnFired?.Invoke();
    }

    // canFire가 눌리거나 true여야만 발사가능
    private void OnFire(InputValue value)
    {
        Fire();
    }
    // Coroutine을 사용하여 WaitForIt함수를 만들고 coolDownTime만큼의 시간이 지나면 canfire를 ture로 전환
    IEnumerator WaitForIt()
    {
        canFire = false;
        yield return new WaitForSeconds(coolDownTime);
        canFire = true;
    }
}
