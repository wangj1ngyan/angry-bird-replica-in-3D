using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubberBand : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform leftAttachPoint;
    public Transform rightAttachPoint;
    public Transform pellet;
    
    private LineRenderer lineRenderer;
    
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        if (lineRenderer == null)
        {
            Debug.LogError("Missing LineRenderer component on " + gameObject.name);
            this.enabled = false; // Disable the script if LineRenderer is not found
            return;
        }
        lineRenderer.positionCount = 3; // Set the number of positions
    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer.SetPosition(0, leftAttachPoint.position);
        lineRenderer.SetPosition(1, pellet.position);
        lineRenderer.SetPosition(2, rightAttachPoint.position);
    }
}
