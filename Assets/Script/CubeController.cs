using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    MyVRControllerManager VRController;

    private void Awake()
    {
        VRController = MyVRControllerManager.instance;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (VRController.devAvailable)
        {
            transform.rotation = new Quaternion(
                -VRController.devData.angle[1],
                VRController.devData.angle[2],
                -VRController.devData.angle[0],
                VRController.devData.angle[3]
            );
        }


    }
}
