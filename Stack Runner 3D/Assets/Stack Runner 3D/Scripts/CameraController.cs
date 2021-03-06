using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;     // player transform

    private Vector3 _target = Vector3.zero;

    public float[] cameraVector3Position; // refrence to the camera position

    void Update()     // make camera follow the player
    {
       
        _target = new Vector3(player.position.x+cameraVector3Position[0], player.position.y+ cameraVector3Position[1], player.position.z- cameraVector3Position[2]);
        transform.position = Vector3.Lerp(transform.position, _target, 1f);
    }
}
