using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BullethHit : MonoBehaviour
{
    [SerializeField] private GameObject bulletExplosion;
    // ��ü�� �΋H���� �Ѿ� ����
    private void OnCollisionEnter(Collision collision)
    {
        /***************************************************************
        �Ѿ��� �ε����� �� ������ ����� ��������Ʈ�� �־ �߰��Ͽ����ϴ�.
        ***************************************************************/
        Instantiate(bulletExplosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
