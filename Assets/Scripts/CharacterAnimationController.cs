using UnityEngine;

public class CharacterAnimationController : AnimationController
{
    private static readonly int IsWalking = Animator.StringToHash("IsWalking");

    private readonly float magnituteThreshold = 0.5f;       
    protected override void Awake()
    {
        base.Awake();
    }

    private void Start() 
    {
        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 obj)
    {
        animator.SetBool(IsWalking, obj.magnitude > magnituteThreshold);    // 벡터의 크기가 0.5보다 큰 경우에만 움직인걸로 처리
    }
}
