using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDamagePopup : MonoBehaviour
{
    // public GameObject damagePopup;

    void Start()
    {
        Destroy(gameObject, 5);
    }
}
