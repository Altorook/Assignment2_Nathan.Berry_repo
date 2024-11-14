using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] Rigidbody _playerRB;
    [SerializeField] Transform _playerTransform;
    [SerializeField] float _speed;
    [SerializeField] float _mouseSens;
    [SerializeField] Transform _cameraTransform;
    [SerializeField] float camVerticalClamp;
    private float playerXVelocity;
    private float playerZVelocity;
    private float mouseUpRotation;
    private float mouseRightRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerXVelocity = Input.GetAxis("Horizontal");
        playerZVelocity = Input.GetAxis("Vertical");
        mouseUpRotation += Input.GetAxis("Mouse Y") * _mouseSens;
        mouseRightRotation = Input.GetAxis("Mouse X") * _mouseSens;
        _cameraTransform.localEulerAngles = new Vector3(Mathf.Clamp(-mouseUpRotation, -camVerticalClamp, camVerticalClamp),0, 0);
    }
    private void FixedUpdate()
    {
        _playerTransform.Rotate(new Vector3(0,mouseRightRotation, 0));
        _playerRB.velocity = (playerXVelocity * transform.right  + playerZVelocity * transform.forward ).normalized * _speed;
    }
}
