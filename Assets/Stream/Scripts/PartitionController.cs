using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PartitionController : MonoBehaviour
{
    public string PartitionNumber
    {
        set
        {
            var textMesh = partitionTextGameObject.GetComponent<TextMeshPro>();
            textMesh.text = value;
        }
    }
    public bool Connecting = true;

    public GameObject spinner;
    public GameObject partitionTextGameObject;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Check if spinner should be enabled
        //
        spinner.SetActive(Connecting);

    }
}
