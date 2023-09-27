using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public Camera camera;



    void FixedUpdate()
    {
        Vector2 mousePosition = Input.mousePosition;

        Ray mouseOriginAndDirection = camera.ScreenPointToRay(mousePosition);

        if (Physics.Raycast(mouseOriginAndDirection, out RaycastHit hitInfo, 100))
        {
            ClickableObject clickableObject = hitInfo.transform.GetComponent<ClickableObject>();
            if (clickableObject)
            {
                clickableObject.Clicked();
            }

            Debug.Log("on top of something!");
        }

        Debug.DrawRay(mouseOriginAndDirection.origin, mouseOriginAndDirection.direction*100);

    }
}
