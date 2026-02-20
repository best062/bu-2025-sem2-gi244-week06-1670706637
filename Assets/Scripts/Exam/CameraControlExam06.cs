using System;
using UnityEngine;

public class CameraControlExam06 : MonoBehaviour
{
    public Transform player1;
    public Transform player2;
    public Camera targetCamera;
    public float offset;
    
    public float offsetY = 10f;
    public float zoomMultiplier = .5f;

    private void Update()
    {
        Vector3 Center = (player1.position + player2.position) / 2f;
        transform.position = new Vector3(Center.x, offsetY, Center.z);
        float distance = Vector3.Distance(player1.position, player2.position);
        targetCamera.orthographicSize = distance * zoomMultiplier;
    }
}
