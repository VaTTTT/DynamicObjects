using UnityEngine;

public class MovingForward : MonoBehaviour
{
    [SerializeField] private float _movingSpeed;

    private void Update()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        this.transform.position += transform.forward * _movingSpeed * Time.deltaTime;
    }
}