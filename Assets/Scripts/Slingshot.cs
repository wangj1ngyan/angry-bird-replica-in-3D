using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
    public GameObject pellet; 
    public Transform shootPoint; // Point from where the pellet will be shot
    private Vector3 initialPosition;
    private SpringJoint springJoint;
    private bool isDragging = false;
    
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = pellet.transform.position;
        springJoint = pellet.GetComponent<SpringJoint>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            springJoint.connectedBody = null; // Optionally disconnect while dragging
        }
        if (isDragging)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
            pellet.transform.position = new Vector3(mousePosition.x, mousePosition.y, initialPosition.z);
        }
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
            springJoint.connectedBody = shootPoint.GetComponent<Rigidbody>(); // Reconnect or maintain connection
            pellet.GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
