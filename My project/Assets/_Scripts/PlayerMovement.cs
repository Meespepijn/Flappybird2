using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float shootStrength = 3;
    public float rotationForce = 5;
    public Rigidbody2D rbFrans;
    public Vector2 shootRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown("space"))
        {

            float rotationZ = transform.eulerAngles.z * Mathf.Deg2Rad;

            shootRotation = new Vector2(-Mathf.Sin(rotationZ), Mathf.Cos(rotationZ));

            rbFrans.AddForce(shootRotation * shootStrength, ForceMode2D.Impulse);

            rbFrans.AddTorque(rotationForce * 0.1f, ForceMode2D.Impulse);



        }
    }
}
