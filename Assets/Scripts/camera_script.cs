using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_script : MonoBehaviour
{
    public GameObject player;
    private Vector3 distance;
    // Start is called before the first frame update
    void Start()
    {
        distance = new Vector3(0, 8, -100);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (0,0, player.transform.position.z)  + distance;
    }
}
