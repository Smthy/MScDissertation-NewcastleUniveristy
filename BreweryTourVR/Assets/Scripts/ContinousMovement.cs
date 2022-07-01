using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class ContinousMovement : MonoBehaviour
{
    public XRNode inputSource;
    private Vector2 inputAxis;

    private XRRig rig;

    private CharacterController character;

    public float height = 0.2f;
    public float speed = 1.0f;
    public float gravity = -9.81f;
    private float fallspeed;

    public LayerMask groundLayer;
    
    void Start()
    {
        character = GetComponent<CharacterController>();
        rig = GetComponent<XRRig>();
    }

    
    void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
    }

    private void FixedUpdate()
    {
        CapsuleFollowHeadset();

        Quaternion headYaw = Quaternion.Euler(0, rig.cameraGameObject.transform.eulerAngles.y, 0);
        Vector3 direction = headYaw * new Vector3(inputAxis.x, 0, inputAxis.y);

        character.Move(direction * Time.fixedDeltaTime * speed);

        bool isGrounded = CheckIfGrounded();

        if (isGrounded)
        {
            fallspeed = 0;
        }
        else
        {
            fallspeed += gravity * Time.fixedDeltaTime;
        }
        
        character.Move(Vector3.up * fallspeed * Time.fixedDeltaTime);

    }

    void CapsuleFollowHeadset()
    {
        character.height = rig.cameraInRigSpaceHeight + height;
        Vector3 capCenter = transform.InverseTransformVector(rig.cameraGameObject.transform.position);
        character.center = new Vector3(capCenter.x, character.height/2 + character.skinWidth, capCenter.z);  
    }

    bool CheckIfGrounded()
    {
        Vector3 rayStart = transform.TransformPoint(character.center);
        float rayLength = character.center.y + 0.01f;
        bool hasHit = Physics.SphereCast(rayStart, character.radius, Vector3.down, out RaycastHit hitInfo, rayLength, groundLayer);
        return hasHit;
    }


    public void IncreaseSpeed()
    {

        speed += 0.5f;

        //Button Click to increase the speed 0.5f
    }

    public void DecreaseSpeed()
    {
        speed -= 0.5f;
        //button click to decrease the speed 0.5f
    }
}
