using UnityEngine;

public class ChangingSize : MonoBehaviour
{
    [SerializeField] private float _increasingSizeSpeed;

    private void Update()
    {
        IncreaseSize();
    }

    private void IncreaseSize()
    {
        Vector3 sizeStep = new Vector3(0.1f, 0.1f, 0.1f);

        this.transform.localScale += sizeStep * _increasingSizeSpeed * Time.deltaTime;
    }
}