using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] private LayerMask groundLayer;
    public Transform camera1;
    public float speed, rotSpeed;
    private float rotX, rotY;
    private Rigidbody rb;
    private Vector3 offset;
    private Vector3 moveDelta;

    private void Awake()
    {
        offset = camera1.position - transform.position;
        rb = GetComponent<Rigidbody>();

    }


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    void Update()
    {
        Rotate();
        Move();
    }




    void Rotate()
    {
        rotY += Input.GetAxisRaw("Mouse X") * rotSpeed * Time.deltaTime;
        rotX -= Input.GetAxisRaw("Mouse Y") * rotSpeed * Time.deltaTime;

        rotX = Mathf.Clamp(rotX, -30, 50f);

        transform.rotation = Quaternion.Euler(0f, rotY, 0f);
        camera1.rotation = Quaternion.Euler(rotX, rotY, 0f);
    }

    void Move()
    {
        camera1.position = transform.position + offset;
        moveDelta = transform.forward * Input.GetAxisRaw("Vertical") + transform.right * Input.GetAxisRaw("Horizontal");
        rb.linearVelocity = moveDelta.normalized * speed;
    }

}
