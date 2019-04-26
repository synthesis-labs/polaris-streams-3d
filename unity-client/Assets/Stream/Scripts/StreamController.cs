using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Grpc.Core;
using Helloworld;

public class StreamController : MonoBehaviour
{
    public string StreamName = "Untitled";
    public GameObject spinner;
    public bool Connecting = true;
    public PartitionsController partitionsController;
    public TextMeshPro textMeshPro;

    private Channel channel;
    private Helloworld.Greeter.GreeterClient client;

    // Start is called before the first frame update
    void Start()
    {
        // GRPC Test
        //
        channel = new Channel("127.0.0.1:50051", ChannelCredentials.Insecure);
        client = new Helloworld.Greeter.GreeterClient(channel);
        var reply = client.SayHello(new HelloRequest { Name = "Tom" });
        print(reply);
    }

    // Update is called once per frame
    void Update()
    {
        // Set the text
        //
        textMeshPro.text = StreamName;

        // Check if spinner should be enabled
        //
        spinner.SetActive(Connecting);
    }
}
