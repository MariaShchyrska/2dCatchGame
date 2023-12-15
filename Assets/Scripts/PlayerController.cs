using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float _moveSpeed = 5f;
    [SerializeField]
    private float _jumpForce = 10f;
    [SerializeField]
    private float _checkRadius = 0.5f;
    [SerializeField]
    private LayerMask _whatIsGround;
    [SerializeField]
    private Transform _feetPos;
    
    private Rigidbody2D _rb;
    private float _moveInput;
    private bool _isGrounded;
    private InputWrapper _inputWrapper;

    public float SpeedX => _rb.velocity.x;
    public bool InJump => !_isGrounded;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _inputWrapper = new InputWrapper();
    }

    void Update()
    {
        _moveInput = _inputWrapper.GetHorizontalInput();
        _rb.velocity = new Vector2(_moveInput * _moveSpeed, _rb.velocity.y);

        _isGrounded = Physics2D.OverlapCircle(_feetPos.position, _checkRadius, _whatIsGround);

        if(_isGrounded && _inputWrapper.GetJumpInput())
        {
            _rb.velocity = Vector2.up * _jumpForce;
        }
    }
}