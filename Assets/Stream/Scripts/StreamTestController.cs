using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreamTestController : MonoBehaviour
{
    public GameObject partitionsControllerGameObject;

    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var partitionsController = partitionsControllerGameObject.GetComponent<PartitionsController>();
        if (Input.GetKeyDown("]"))
        {
            count++;
            partitionsController.SetNumberOfPartitions(count);
        }
        if (Input.GetKeyDown("["))
        {
            count--;
            partitionsController.SetNumberOfPartitions(count);
        }
    }
}
