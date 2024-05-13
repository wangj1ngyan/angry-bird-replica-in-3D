using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchBird : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody birdRigidbody;
    private Vector3 initialPosition;
    private bool isDragging = false;

    void Start()
    {
        initialPosition = birdRigidbody.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDragging)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            birdRigidbody.position = new Vector3(mousePosition.x, mousePosition.y, initialPosition.z);
        }

        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            birdRigidbody.isKinematic = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
            birdRigidbody.isKinematic = false;
            Vector3 force = initialPosition - birdRigidbody.position;
            birdRigidbody.AddForce(force * 5, ForceMode.Impulse);
        }
    }
}
