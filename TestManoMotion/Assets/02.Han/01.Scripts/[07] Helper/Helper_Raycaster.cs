﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helper_Raycaster : MonoBehaviour
{
    public bool isRaycastable = false;
    Transform handTr;
    Transform camTr;

    InteractablePhoto curPhoto;
    // Update is called once per frame
    private void Start()
    {
        handTr = GameManager.instance.hand.transform;
        camTr = Camera.main.transform;
    }
    void Update()
    {
        if (isRaycastable == false) return;
        Ray ray = new Ray(handTr.position, (camTr.position - handTr.position));
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 10f, 1 << 8))
        {
            Debug.Log("너는 사진이다");
            var a = hit.transform.GetComponent<InteractablePhoto>();
            if (curPhoto == a) return;
            curPhoto.ProcessCollisionExit();
            curPhoto = a;
            curPhoto.ProcessCollisionEnter();
        }
    }
}