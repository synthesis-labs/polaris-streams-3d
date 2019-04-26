using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardTestController : MonoBehaviour
{
    public StreamBoxController StreamBoxController;
    public PartitionsController PartitionsController;

    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("]"))
        {
            count++;
            PartitionsController.SetNumberOfPartitions(count);
        }
        if (Input.GetKeyDown("["))
        {
            count--;
            PartitionsController.SetNumberOfPartitions(count);
        }
        if (Input.GetKeyDown("."))
        {
            StreamBoxController.AddStream("Hello " + count);
        }
    }
}
