﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followobjects : MonoBehaviour
{
    public Transform theobject;

    public Vector3 offset;
    private void LateUpdate()
    {
        transform.position = theobject.position + offset;
    }
}
