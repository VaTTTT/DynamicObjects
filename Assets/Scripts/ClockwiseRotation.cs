using UnityEngine;

public class ClockwiseRotation : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        RotateClockwise();
    }

    private void RotateClockwise()
    {
        float angleStep = 10;

        this.transform.Rotate(new Vector3(0, angleStep, 0) * _rotationSpeed * Time.deltaTime); 
    }
}