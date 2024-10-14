using System;
using Unity.Mathematics;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{
    [SerializeField] private SpriteRenderer characterRenderer;      // ĳ���� �������� ȿ���� ����

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

        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;        // ���콺�� ���ʿ� ���� �� �������
    }
}