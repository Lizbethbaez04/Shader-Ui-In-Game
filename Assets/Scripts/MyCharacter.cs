using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacter : MonoBehaviour
{
    Renderer render;
    [SerializeField]
    float ColorPower = 1f;

    private void Start()
    {
        render = GetComponent<Renderer>();

    }

    private void Update()
    {
        render.material.SetFloat("_ColorPower", ColorPower);
    }
}
