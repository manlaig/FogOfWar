using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMover : MonoBehaviour
{
	[SerializeField] float speed;

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0f, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        Camera.main.gameObject.transform.position = new Vector3(transform.position.x, 50, transform.position.z);
    }
}
