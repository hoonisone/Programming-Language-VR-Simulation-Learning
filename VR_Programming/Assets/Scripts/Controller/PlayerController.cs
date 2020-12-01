using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 5.0f;
    public float rotSpeed = 3.0f;
    public float jumpPower = 3.5f;
    public Camera playerCamera;

    Rigidbody rigidbody;
    Collider collider;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = gameObject.GetComponent<Rigidbody>();
        collider = gameObject.GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveControl();
        RotControl();
        Jump();
    }

    void MoveControl(){
        if (Input.GetKey(KeyCode.W)) {
            this.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S)) {
            this.transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A)) {
            this.transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D)) {
            this.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }   
    }

    void Jump(){
        
        if (Input.GetKeyDown(KeyCode.Space)){
            if (Physics.Raycast(transform.position, Vector3.down, collider.bounds.extents.y + 0.1f))
                rigidbody.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
     
    void RotControl(){
        float rotX = Input.GetAxis("Mouse Y") * rotSpeed;
        float rotY = Input.GetAxis("Mouse X") * rotSpeed;

        this.transform.localRotation *= Quaternion.Euler(0, rotY, 0);
        playerCamera.transform.localRotation *= Quaternion.Euler(-rotX, 0, 0);
    }

}
