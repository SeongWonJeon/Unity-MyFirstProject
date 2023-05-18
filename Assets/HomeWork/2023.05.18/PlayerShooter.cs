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

    // canFire�� �����ų� true���߸� �߻簡��
    private void OnFire(InputValue value)
    {
        Fire();
    }
    // Coroutine�� ����Ͽ� WaitForIt�Լ��� ����� coolDownTime��ŭ�� �ð��� ������ canfire�� ture�� ��ȯ
    IEnumerator WaitForIt()
    {
        canFire = false;
        yield return new WaitForSeconds(coolDownTime);
        canFire = true;
    }
}
