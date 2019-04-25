using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
using Confluent.Kafka;
using Confluent.Kafka.Admin;
using Confluent.Kafka.Impl;
*/
using System;

public class StreamTestController : MonoBehaviour
{
    public GameObject partitionsControllerGameObject;

    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        /*
        using (var adminClient = new AdminClientBuilder(new AdminClientConfig { BootstrapServers = "127.0.0.1:9021" }).Build())
        {
            var groups = adminClient.ListGroups(TimeSpan.FromSeconds(10));
            print($"Consumer Groups:");
            foreach (var g in groups)
            {
                print($"  Group: {g.Group} {g.Error} {g.State}");
                print($"  Broker: {g.Broker.BrokerId} {g.Broker.Host}:{g.Broker.Port}");
                print($"  Protocol: {g.ProtocolType} {g.Protocol}");
                print($"  Members:");
                foreach (var m in g.Members)
                {
                    print($"    {m.MemberId} {m.ClientId} {m.ClientHost}");
                    print($"    Metadata: {m.MemberMetadata.Length} bytes");
                    print($"    Assignment: {m.MemberAssignment.Length} bytes");
                }
            }
        }
        */
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
