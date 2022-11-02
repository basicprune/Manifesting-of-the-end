using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class d3PlayerController : MonoBehaviour
{

    public Transform Cam;
    public float moveSpeed = 5f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = input.GetAxisRaw("Vertical");
        vector3 dir = new Vector3(h, 0, v).normalized;
        if (dir.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, tarAngle, ref turnSmoothVelocity, turnSmoothTime);
            // transform.rotation = 
        }









    }
}
