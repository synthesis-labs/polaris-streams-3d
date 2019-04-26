using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreamBoxController : MonoBehaviour
{
    public GameObject streamPlaquePrototype;

    public List<StreamPlaqueController> StreamPlaques = new List<StreamPlaqueController>();

    void Start()
    {
        AddStream("Users");
        AddStream("Payments");
    }

    public void AddStream(string name)
    {
        // Check if we have it already
        //
        if (StreamPlaques.Exists((e) => e.StreamName == name))
            return;

        // Add it
        //
        var newStreamPlaqueController = Instantiate(streamPlaquePrototype, transform.transform).GetComponent<StreamPlaqueController>();
        newStreamPlaqueController.StreamName = name;
        StreamPlaques.Add(newStreamPlaqueController);
    }

    void Update()
    {
        // Layout plaques
        //
        float padding = 3.5f * gameObject.transform.localScale.y;
        float offset = (StreamPlaques.Count * padding / 2.0f) - (padding / 2.0f);
        for (int i = 0; i < StreamPlaques.Count; i++)
        {
            var streamPlaqueGameObject = StreamPlaques[i].gameObject;
            streamPlaqueGameObject.transform.position = new Vector3(streamPlaqueGameObject.transform.position.x, offset - (i * padding));
        }
    }
}
