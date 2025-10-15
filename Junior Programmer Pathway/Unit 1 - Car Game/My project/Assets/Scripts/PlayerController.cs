using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float turnSpeed = 15;
    // Update is called once per frame
    void Update()
    {
        var xInp = Input.GetAxisRaw("Horizontal");
        var yInp = Input.GetAxisRaw("Vertical");
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed * yInp);
        transform.Rotate(Vector3.up * xInp * turnSpeed * Time.deltaTime);
    }
}
