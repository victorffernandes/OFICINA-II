using UnityEngine;
using System.Collections;

public class CameraFollow : Default
{

    public float dampTime = 0.15f;
    private Vector3 velocity = Vector3.zero;
    public Transform target;

    // Update is called once per frame
    void Update()
    {

        if (target)
        {
            //transform.position = new Vector3(target.transform.position.x + 3f,target.transform.position.y,-10);
            LookAt2D(Gerenc.player.GetComponent<Player>().current.transform.position);
        }
        if (target)
        {
            /*Vector3 point = camera.WorldToViewportPoint(target.localPosition );
            Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
            Vector3 destination = transform.position + (delta);
            transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);*/
            Vector3 t = new Vector3(target.position.x, target.position.y, -10);
            transform.position = Vector3.MoveTowards(transform.localPosition, t, 2f);
            transform.position = new Vector3(transform.position.x, transform.position.y, -10);
        }
    }
}