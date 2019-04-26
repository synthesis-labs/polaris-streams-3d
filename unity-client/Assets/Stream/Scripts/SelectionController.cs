using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionController : MonoBehaviour
{
    public Camera theCamera;

    // Update is called once per frame
    void Update()
    {
        // Ray cast for selection
        //
        RaycastHit hit;
        Ray ray = theCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            Transform objectHit = hit.transform;

            // Do something with the object that was hit by the raycast.
            print(objectHit.gameObject.name);
        }
    }
}
