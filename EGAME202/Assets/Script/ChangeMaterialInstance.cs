using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialInstance : MonoBehaviour
{
    public Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            renderer.material.color = Color.red;
        }
    }
}
