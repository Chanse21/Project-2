using UnityEngine;

public class Growing : MonoBehaviour
{
    public float growFactor = 2.5f; // How much to increase the scale
    public float shrinkFactor = 0.1f; // How much to decrease the scale
    private Vector3 minimumscale, maximumscale;

    
    void Start()
    {
       
        minimumscale = new Vector3 (.1f, .1f, .1f);
        maximumscale = new Vector3 (4f, 4f, 4f);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GrowObject")) // Check if the colliding object has the "GrowObject" tag
        {
            if ((transform.localScale * growFactor).magnitude < maximumscale.magnitude)
            {
                transform.localScale *= growFactor; // Increase the scale
            }
        }
        else if (collision.gameObject.CompareTag("ShrinkObject")) // Check if the colliding object has the "ShrinkObject" tag
        {
            if ((transform.localScale * shrinkFactor).magnitude > minimumscale.magnitude)
            {
                transform.localScale *= shrinkFactor; // Decrease the scale
            }
        }

    }

   
}
