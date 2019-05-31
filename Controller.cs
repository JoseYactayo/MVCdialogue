using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        Speed = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, Speed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (Input.GetKey(KeyCode.E))
            OpenDialog();
        if (Input.GetKey(KeyCode.Space))
            ContinueDialog();
        if (Input.GetKey(KeyCode.E) && Dialog1.gameObject.SetActive(true))
            CloseDialog();
        if (Input.GetKey(KeyCode.E) && Dialog2.gameObject.SetActive(true))
            CloseDialog();
        if (Input.GetKey(KeyCode.E) && Dialog3.gameObject.SetActive(true))
            CloseDialog();
    }
}
