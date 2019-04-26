using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StreamPlaqueController : MonoBehaviour
{
    public TextMeshPro textMeshPro;

    public string StreamName = "Untitled";

    void Start()
    {
    }

    void Update()
    {
        textMeshPro.text = StreamName;
    }
}
