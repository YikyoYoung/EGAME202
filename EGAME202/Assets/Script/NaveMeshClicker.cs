using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NaveMeshClicker : MonoBehaviour
{
    public NavMeshAgent agent;
    public Camera gameCamera;
    private ClickableObject currentClickedObject;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 MousePosition = Input.mousePosition;
            Ray mouseRay = gameCamera.ScreenPointToRay(MousePosition);

            if (Physics.Raycast(mouseRay, out RaycastHit hitInfo, 100))
            {
                agent.SetDestination(hitInfo.point);
            }
            


            }
        }
    }

