using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;

    private Vector3 offset;

    private Vector3 newPosition;

    [SerializeField] private float lerpValue;
    void Start()
    {
        offset = transform.position - playerTransform.position;
    }

    private void LateUpdate()
    {
        SetCameraSmoothFollow();
    }

    private void SetCameraSmoothFollow()
    {
        newPosition = Vector3.Lerp(transform.position, new Vector3(0f, playerTransform.position.y, playerTransform.position.z)+ offset, lerpValue * Time.deltaTime);
        transform.position = newPosition;
    }
}
