using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BullethHit : MonoBehaviour
{
    [SerializeField] private GameObject bulletExplosion;
    // 물체에 부딫히면 총알 삭제
    private void OnCollisionEnter(Collision collision)
    {
        /***************************************************************
        총알이 부딪쳤을 때 나오는 사운드는 폭발이펙트에 넣어서 추가하였습니다.
        ***************************************************************/
        Instantiate(bulletExplosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
