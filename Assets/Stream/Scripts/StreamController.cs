using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StreamController : MonoBehaviour
{
    public string StreamName = "Untitled";
    public GameObject spinner;
    public bool Connecting = true;
    public GameObject partitionsControllerGameObject;

    private GameObject streamText;

    // Start is called before the first frame update
    void Start()
    {
        streamText = GameObject.Find("StreamText");

        // Set the text
        //
        var textMesh = streamText.GetComponent<TextMeshPro>();
        textMesh.text = StreamName;

        // Grab the partitions controller
        //
        var partitionsController = partitionsControllerGameObject.GetComponent<PartitionsController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if spinner should be enabled
        //
        spinner.SetActive(Connecting);
        
    }
}
