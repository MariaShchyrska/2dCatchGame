using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    [SerializeField]
    private PlayerController _playerController;
    [SerializeField]
    private Animator _animator;
    
    private void Update()
    {
        _animator.SetFloat("Speed", Mathf.Abs(_playerController.SpeedX));
        _animator.SetBool("isJump", _playerController.InJump);

        if(_playerController.SpeedX < -0.1f)
        {
            Vector3 scale = transform.localScale;
            scale.x = -1;
            transform.localScale = scale;
        }
        else if(_playerController.SpeedX > 0.1f)
        {
            Vector3 scale = transform.localScale;
            scale.x = 1;
            transform.localScale = scale;
        }
    }
}