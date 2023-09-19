using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    public Transform activRoom;

    public float dampSpeed;

    public static Camera instance;

    [Range(-50, 50)]
    public float minModX, maxModX, minModY, maxModY;

    [Range(-50, 50)]
    public float posCamX;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    // Update is called once per frame
    void Update()
    {
        var minPosY = activRoom.GetComponent<BoxCollider2D>().bounds.min.y + minModY;
        var maxPosY = activRoom.GetComponent<BoxCollider2D>().bounds.max.y + maxModY;
        var minPosX = activRoom.GetComponent<BoxCollider2D>().bounds.min.x + minModX;
        var maxPosX = activRoom.GetComponent<BoxCollider2D>().bounds.max.x + maxModX;

        Vector3 clampedPos = new Vector3(
            Mathf.Clamp(player.position.x + posCamX, minPosX, maxPosX),
            Mathf.Clamp(player.position.y, minPosY, maxPosY),
            Mathf.Clamp(player.position.z, -10, -10));

        Vector3 smoohtPos = Vector3.Lerp(transform.position, clampedPos, dampSpeed * Time.deltaTime);

        transform.position = smoohtPos;
    }
}