using UnityEngine;

public class CapsuleScale : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    void Update()
    {
        transform.localScale += Vector3.one * _scaleSpeed * Time.deltaTime;
    }
}
