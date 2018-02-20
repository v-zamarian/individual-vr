﻿// Victor Zamarian
// 2/20/18

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTrigger : MonoBehaviour {
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.layer == LayerMask.NameToLayer("Object")) {
            
            if (other.gameObject.transform.parent != null) {
                Destroy(other.gameObject.transform.parent.gameObject);
            } else {
                Destroy(other.gameObject);
            }
        }
    }
}
