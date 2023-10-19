using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private Rigidbody rb;
    public Renderer transparentObjectRenderer;
    public Renderer secondObjectRenderer;
    public Renderer thirdObjectRenderer;
    public float transparency = 1.0f;
    private float timeAtPosition = 0f;
    private const float requiredTime = 3f;
    private const float tolerance = 0.18f;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Hello");
        rb = GetComponent<Rigidbody>();
        if (rb)
        {
            rb.isKinematic = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = Camera.main.transform.position;
        //Debug.Log("Main Camera Position X: " + cameraPosition.x);
        //Debug.Log("Main Camera Position Z: " + cameraPosition.z);
        //Debug.Log("Main Camera Position y: " + cameraPosition.y);

        if (Mathf.Abs(cameraPosition.x + 12.7f) < tolerance && Mathf.Abs(cameraPosition.z - 8.09f) < tolerance && Mathf.Abs(cameraPosition.y - 1.4f) < tolerance)
        {

            timeAtPosition += Time.deltaTime;
            Debug.Log(timeAtPosition);

            if (timeAtPosition >= requiredTime)
            {
                rb.isKinematic = false;
                ApplyChanges();
                timeAtPosition = 0f;
            }
        }
        else
        {
            timeAtPosition = 0f;
        }
    }

    private void ApplyChanges()
    {
        if (transparentObjectRenderer)
        {
            Color currentColor = transparentObjectRenderer.material.color;
            currentColor.a = 1.0f;  // Fully opaque
            transparentObjectRenderer.material.color = currentColor;
        }

        if (secondObjectRenderer)
        {
            Color currentColor = secondObjectRenderer.material.color;
            currentColor.a = 0.0f;  // Fully transparent
            secondObjectRenderer.material.color = currentColor;
        }

        if (thirdObjectRenderer)
        {
            Color currentColor = thirdObjectRenderer.material.color;
            currentColor.a = 0.0f;  // Fully transparent
            thirdObjectRenderer.material.color = currentColor;
        }
    }
}
