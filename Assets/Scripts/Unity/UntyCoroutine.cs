using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UntyCoroutine : MonoBehaviour
{
    /************************************************************************
	 * �ڷ�ƾ (Coroutine)
	 * 
	 * �۾��� �ټ��� �����ӿ� �л��� �� �ִ� �񵿱�� �۾�
	 * �ݺ������� �۾��� �л��Ͽ� �����ϸ�, ������ �Ͻ������ϰ� �ߴ��� �κк��� �ٽý����� �� ����
	 * ��, �ڷ�ƾ�� �����尡 �ƴϸ� �ڷ�ƾ�� �۾��� ������ ���� �����忡�� ����
	 ************************************************************************/

    /*private void Start()
    {
		StartCoroutine(SubRoutine());
    }
    // <�ڷ�ƾ ����>
    // �ݺ������� �۾��� StartCorouine�� ���� ����
    IEnumerator SubRoutine()
	{
		// 3�� ��ٷȴٰ� ����׷� �α����
        yield return new WaitForSeconds(3f);
		Debug.Log("�α����");
		
		// 1�ʰ� ���������� ����� �α� ǥ��
        for (int i = 0; i < 10; i++)
		{
			Debug.Log($"{i}�� ����");
			yield return new WaitForSeconds(1f);
		}
	}*/

    // <�ڷ�ƾ ����>
    // �ݺ������� �۾��� StartCorouine�� ���� ����
    IEnumerator SubRoutine()
    {
        for (int i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(1);
            Debug.Log("�ڷ�ƾ 1��");
        }
    }

    private Coroutine routine;
    private void CoroutineStart()
    {
        routine = StartCoroutine(SubRoutine());
    }

    // <�ڷ�ƾ ����>
    // StopCoroutine�� ���� ���� ���� �ڷ�ƾ ����
    // StopAllCoroutine�� ���� ���� ���� ��� �ڷ�ƾ ����
    // �ݺ������� �۾��� ��� �Ϸ�Ǿ��� ��� �ڵ� ����
    // �ڷ�ƾ�� �����Ų ��ũ��Ʈ�� ��Ȱ��ȭ�� ��� �ڵ� ����

    private void CoroutineStop()
    {
        StopCoroutine(routine);     // ������ �ڷ�ƾ ����
        StopAllCoroutines();        // ��� �ڷ�ƾ ����, ��behaviour�� �����Ų �ڷ�ƾ�� ����
    }

    // <�ڷ�ƾ �ð� ����>
    // �ڷ�ƾ�� �ð� ������ �����Ͽ� �ݺ������� �۾��� ���� Ÿ�̹��� ������ �� ����
    IEnumerator CoRoutineWait()
    {
        yield return new WaitForSeconds(1);     // n�ʰ� �ð�����
        yield return null;                      // �ð����� ����, ������Ʈ �� �� �� ��ٸ�
    }
}