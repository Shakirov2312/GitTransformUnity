using UnityEngine;

public class CombinationMove : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private float _speedRotation;
    [SerializeField] private float _speedScale;

    void Update()
    {
        transform.Translate(Vector3.forward * _speedMove * Time.deltaTime);
        transform.Rotate(Vector3.up * _speedRotation * Time.deltaTime);
        transform.localScale += Vector3.one * _speedScale * Time.deltaTime;
    }
}
