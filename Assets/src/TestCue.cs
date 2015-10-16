using UnityEngine;
using System.Collections;

public class TestCue : MonoBehaviour
{

    // Use this for initialization
    private void Start()
    {

    }

    // Update is called once per frame
    private void Update()
    {

    }

    private void OnMouseDown()
    {
        Rigidbody rigidbody = this.GetComponent<Rigidbody>();
        rigidbody.AddForce(new Vector3(0,0,1000));
    }
}
