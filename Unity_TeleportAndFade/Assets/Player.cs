using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Scene Scene;

    // Start is called before the first frame update
    void Start()
    {
        Scene = FindObjectOfType<Scene>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        print("載入下ㄧ關");
        if (other.name == "傳送裝置")
        {
            StartCoroutine(Scene.NextLevel());
        }
        if (other.name == "畫面淡去")
        {
            StartCoroutine(Scene.Fadeout());
        }
    }
}
