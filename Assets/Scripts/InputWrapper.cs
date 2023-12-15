using UnityEngine;

public class InputWrapper
{
    public float GetHorizontalInput()
    {
        return Input.GetAxisRaw("Horizontal");
    }

    public bool GetJumpInput()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }
}