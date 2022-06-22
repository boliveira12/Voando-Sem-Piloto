using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeMovment : MonoBehaviour
{
    public int speed = 5;
    public GameObject paisOrigem;
    public GameObject paisDestino;

    void Start()
    {
        paisOrigem = GameObject.Find(SelectPais.origem);
        transform.position = paisOrigem.transform.position;
        paisDestino = GameObject.Find(SelectPais.destino);
    }

    void Update()
    {
        Vector3 difference = transform.position - paisDestino.transform.position;
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rotationZ+90);
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
}
