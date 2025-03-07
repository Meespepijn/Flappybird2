using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMouseMovement : MonoBehaviour
{
    public Rigidbody2D rbFrans;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 direction = (mousePosition - transform.position).normalized;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        rbFrans.rotation = angle - 90;


    }
}
