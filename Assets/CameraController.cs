using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public GameObject mainCamera;      
    public GameObject subCamera;        


    
    void Start()
    {
        
        mainCamera = GameObject.Find("MainCamera");
        subCamera = GameObject.Find("SubCamera");

        
        subCamera.SetActive(false);
    }


    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 各カメラオブジェクトの有効フラグを逆転(true→false,false→true)させる
            mainCamera.SetActive(!mainCamera.activeSelf);
            subCamera.SetActive(!subCamera.activeSelf);
        }

        /*
        if (Input.GetKey(KeyCode.Space))
        {
            subCamera.SetActive(true);
            mainCamera.SetActive(false);
        }
        else
        {
            mainCamera.SetActive(true);
            subCamera.SetActive(false);
        }
        */
    }
}