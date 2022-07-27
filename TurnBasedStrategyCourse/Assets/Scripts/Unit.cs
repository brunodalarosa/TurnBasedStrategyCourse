using DefaultNamespace;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private Vector3 TargetPosition { get; set; }

    private float MoveSpeed { get; set; } = 4f;

    void Update()
    {
        float stoppingDistance = .1f;

        if (Vector3.Distance(transform.position, TargetPosition) > stoppingDistance)
        {
            Vector3 moveDirection = (TargetPosition - transform.position).normalized;

            transform.position += moveDirection * MoveSpeed * Time.deltaTime;
        }

        if (Input.GetMouseButtonDown(0))
        {
            Move(MouseWorld.GetPosition());
        }
    }

    private void Move(Vector3 targetPosition)
    {
        TargetPosition = targetPosition;
    }

}
