using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour, IInputTime
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
    public void IntInputing(float PlayerXVel, float PlayerZVel, float mouseUpRot, float mouseRightRot)
    {
        playerXVelocity = PlayerXVel;
        playerZVelocity = PlayerZVel;
        mouseUpRotation += mouseUpRot * _mouseSens;
        mouseRightRotation += mouseRightRot * _mouseSens;
    }
    // Update is called once per frame
    void Update()
    {
     
        //rotate camera vertically
        _cameraTransform.localEulerAngles = new Vector3(Mathf.Clamp(-mouseUpRotation, -camVerticalClamp, camVerticalClamp),0, 0);
        //rotate player
        _playerTransform.Rotate(new Vector3(0, mouseRightRotation, 0));
        //set player velocity
        _playerRB.velocity = (playerXVelocity * transform.right + playerZVelocity * transform.forward).normalized * _speed * Time.deltaTime;
    }
    private void FixedUpdate()
    {
        
    }
}
