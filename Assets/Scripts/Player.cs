using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 2f;

    // Update is called once per frame
    private void Update()
    {
        float x = 0;
        float y = 0;

        if (Input.GetKey(KeyCode.W)) 
            y = 1;
        if (Input.GetKey(KeyCode.S)) 
            y = -1;
        if (Input.GetKey(KeyCode.D)) 
            x = 1;
        if (Input.GetKey(KeyCode.A)) 
            x = -1;

        transform.position = new Vector3
        (
            transform.position.x + x * speed * Time.deltaTime,
            transform.position.y + y * speed * Time.deltaTime,
            transform.position.z
        );
    }
}
