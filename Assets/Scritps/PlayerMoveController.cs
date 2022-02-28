using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerMoveController : MonoBehaviour
{
    public float moveSpeed = 5.0f; // 플레이어 이동 속도

    float horizontal; // 왼쪽, 오른쪽 방향값을 받는 변수

    private void FixedUpdate() // 플레이어 이동은 항상 중요하게 이루어지므로 Fixed Update를 이용
    {
        Move(); // 플레이어 이동
    }

    void Move()
    {
        horizontal = Input.GetAxis("Horizontal");

        Vector3 dir = horizontal * Vector3.right; // 변수의 자료형을 맞추기 위해 생성한 새로운 Vector3 변수

        this.transform.Translate(dir * moveSpeed * Time.deltaTime); // 오브젝트 이동 함수
    }


    // https://wikidocs.net/91319
}
