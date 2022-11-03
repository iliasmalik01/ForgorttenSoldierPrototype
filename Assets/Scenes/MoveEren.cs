using UnityEngine;

public class MoveEren : MonoBehaviour
{
   
   public float speed = .1f;
   // Update is called once per frame
    void Update()
    {
        float xDirection = Input.GetAxis("Horizontal"); //getaxis will detect ad and assign number based on it a = -1 d = 1 etc
        float zDirection = Input.GetAxis("Vertical"); //getaxis will detect ws and assign number

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        transform.position += moveDirection * speed;
    }
}
