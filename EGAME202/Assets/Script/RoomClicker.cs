using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class RoomClicker : MonoBehaviour
{
    public Camera gameCamera;
    public Room[] rooms;
    public CinemachineVirtualCamera[] allCameras;
    public CinemachineVirtualCamera overheadCamera;

    // Start is called before the first frame update
    void Start()
    {
        rooms = GameObject.FindObjectsOfType<Room>();
        allCameras = GameObject.FindObjectsOfType<CinemachineVirtualCamera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Input.mousePosition;
            Ray mouseRay = gameCamera.ScreenPointToRay(mousePosition);

            if (Physics.Raycast(mouseRay, out RaycastHit hitInfo, 100))
            {
                Room room = hitInfo.transform.GetComponent<Room>();
                if (room)
                {

                    SwitchToCamera(room.roomCamera);
                }
                else
                {

                    SwitchToCamera(overheadCamera);
                }
            }
        }
    }
    public void SwitchToCamera(CinemachineVirtualCamera thisCamera)
    {
        foreach (CinemachineVirtualCamera camera in allCameras)
        {
            int cameraPriority = 0;
            if (camera == thisCamera)
            {
                cameraPriority = 100;
            }
            camera.Priority = cameraPriority;
        }
    }
}
