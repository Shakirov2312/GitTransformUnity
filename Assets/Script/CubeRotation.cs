using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    [SerializeField] private float _speedRotation;

    void Update()
    {
        transform.Rotate(Vector3.up*_speedRotation*Time.deltaTime);
    }
}
