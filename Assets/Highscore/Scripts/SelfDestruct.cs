﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public void DestructSelf()
    {
        Destroy(gameObject);
    }
}