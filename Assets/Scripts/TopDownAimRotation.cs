using System;
using Unity.Mathematics;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;      // 캐릭터 뒤집히는 효과를 위해

    private TopDownController controller;

    private void Awake() 
    {
        controller = GetComponent<TopDownController>();
    }

    private void Start() 
    {
        controller.OnLookEvent += OnFlip;
    }

    private void OnFlip(Vector2 direction)
    {
        FlipPlayer(direction);
    }

    private void FlipPlayer(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;        // 마우스가 왼쪽에 있을 때 뒤집어라
    }
}