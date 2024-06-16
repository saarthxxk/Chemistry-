using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.XR;
public class CameraMovement : MonoBehaviour
{
    public float moveDistance = 1.0f; // The distance the camera should move forward on click
    public class CameraMoveOnClick : MonoBehaviour, IPointerClickHandler
{
    public float moveDistance = 1.0f; // The distance the camera should move forward on click

    public void OnPointerClick(PointerEventData eventData)
    {
        MoveCameraForward();
    }

    private void MoveCameraForward()
    {
        Vector3 forwardDirection = transform.forward;
        Vector3 newPosition = transform.position + (forwardDirection * moveDistance);
        transform.position = newPosition;
    }
}

}
