using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private Vector3 selectedAxis;
    private int rotationSpeed;
    private int scaleFactor;

    private int[] scaleFactors = new int[] { 1, 2, 3 };
    private Vector3[] availableAxes = new Vector3[] { Vector3.up, Vector3.forward, Vector3.right };
    private int[] possibleSpeeds = new int[] { 45, 90, 180 };
    private Color[] colorPalette = new Color[] { Color.cyan, Color.yellow, Color.magenta }; 

    private void Start()
    {
        // set the position of the cube
        transform.position = new Vector3(3, 4, 1);

        // set the scale of the cube
        scaleFactor = scaleFactors[Random.Range(0, 3)];
        transform.localScale = Vector3.one * scaleFactor;

        // choose the axis of rotation from our array
        selectedAxis = availableAxes[Random.Range(0, 3)];

        // choose the speed for the rotation
        rotationSpeed = possibleSpeeds[Random.Range(0, 3)];
        
        // set the cube to a random color from our array
        Material material = Renderer.material;
        material.color = colorPalette[Random.Range(0, 3)];
    }
    
    private void Update()
    {
        // rotate the cube
        transform.Rotate(selectedAxis, rotationSpeed * Time.deltaTime);
    }

}
