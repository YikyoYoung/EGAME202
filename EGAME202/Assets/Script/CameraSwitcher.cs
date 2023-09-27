using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitcher : MonoBehaviour
{
    public List<CinemachineVirtualCamera> cameralist;
    public int activeCameraIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            activeCameraIndex++;
            if (activeCameraIndex >= cameralist.Count)
            {
                activeCameraIndex = 0;
            }

            for (int i = 0; i < cameralist.Count; i++)
            {
                int newPriority = 0;
                if (i == activeCameraIndex)
                {
                    newPriority = 100;
                }
                cameralist[i].Priority = newPriority;
            }

        }
    }
}
