using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tap_Tap_Change : MonoBehaviour
{
    [SerializeField] private GameObject shape_1;
    [SerializeField] private GameObject shape_2;
    [SerializeField] private GameObject shape_3;
    [SerializeField] private GameObject shape_4;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("touch");
        }
    }
}
