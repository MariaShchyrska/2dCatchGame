using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField]
    private float _ySmallerDestroy = -5;
    
    public void Update()
    {
        if(transform.position.y < _ySmallerDestroy)
            Destroy(gameObject);
    }
}