using UnityEngine;
using UnityEngine.InputSystem;

public class Move : MonoBehaviour
{
   public float speed = 5f;




    void Start()
    {
        
    }



    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
