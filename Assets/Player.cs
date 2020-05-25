using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.TransformDirection(Vector3.forward * speed);
        transform.rotation = Quaternion.Euler(0,0,0);

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += new Vector3(0, 0.1f, 0);
        }
        // else if (Input.GetButtonDown("Left"))
        // {
        //     transform.position += new Vector3(0, 0.1f, 0);
        //     Debug.Log("Left Key Pressed");
        // }

        
#if UNITY_EDITOR
        float rightLeftKey = Input.GetAxis("rightLeftKeyUnityEditor");
#else
        float rightLeftKey = Input.GetAxis("rightLeftKeyWebGLChrome");
#endif
        if (rightLeftKey < 0)
        {
            transform.position += new Vector3(-0.5f, 0, 0);
            transform.rotation = Quaternion.Euler(0,0,30);
        }
        if (rightLeftKey > 0)
        {
            transform.position += new Vector3(0.5f, 0, 0);
            transform.rotation = Quaternion.Euler(0,0,-30);
        }
        
#if UNITY_EDITOR
        float upDownKey = Input.GetAxis("upDownKeyUnityEditor");
#else
        float upDownKey = Input.GetAxis("upDownKeyWebGLChrome");
#endif
        if (upDownKey < 0)
        {
            transform.position += new Vector3(0, 0.5f, 0);
            transform.rotation = Quaternion.Euler(-30,0,0);
        }
        if (upDownKey > 0)
        {
            transform.position += new Vector3(0, -0.5f, 0);
            transform.rotation = Quaternion.Euler(30,0,0);
        }
    }

}
