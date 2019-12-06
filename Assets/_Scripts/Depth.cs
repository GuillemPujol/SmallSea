using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Depth : MonoBehaviour
{
    public Transform target;
    public Text depth;

    void Update()
    {
        depth.text = Mathf.Round(target.position.y).ToString()+'m';
    }
}

