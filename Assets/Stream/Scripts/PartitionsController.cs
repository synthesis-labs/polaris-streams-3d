using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartitionsController : MonoBehaviour
{
    public List<GameObject> Partitions = new List<GameObject>();

    public GameObject prototype;

    void Start()
    {
        
    }

    public void SetNumberOfPartitions(int numPartitions)
    {
        // Destroy old ones
        //
        foreach (var partitionGameObject in Partitions)
        {
            Destroy(partitionGameObject);
        }
        Partitions.Clear();

        // Create new ones
        //
        for (int i = 0; i < numPartitions; i++)
        {
            var partitionGameObject = Instantiate(prototype, gameObject.transform);
            var partitionController = partitionGameObject.GetComponent<PartitionController>();
            partitionController.PartitionNumber = i.ToString();
            Partitions.Add(partitionGameObject);
        }
    }

    void Update()
    {
        // Layout partitions
        //
        float padding = 3.5f * gameObject.transform.localScale.y;
        float offset = (Partitions.Count * padding / 2.0f) - (padding / 2.0f);
        for (int i = 0; i < Partitions.Count; i++)
        {
            var partitionGameObject = Partitions[i];
            partitionGameObject.transform.position = new Vector3(partitionGameObject.transform.position.x, offset - (i * padding));
        }
    }
}
