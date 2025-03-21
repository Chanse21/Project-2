using UnityEngine;

public class Growing : MonoBehaviour
{
    public float growFactor = 1.5f; // How much to increase the scale
    public float shrinkFactor = 0.5f; // How much to decrease the scale
    private Vector3 minimumscale, desiredscale;
    private int ms, ds;

    
    void Start()
    {
        Vector3 ms = minimumscale;
        Vector3 ds = desiredscale;
        ms = new Vector3 (1f, 1f, 1f);
        ds = new Vector3 (0.5f, 0.5f, 0.5f);
    }

    void Update()
    {
        Vector3 minimumscale = transform.localScale;
        Vector3 desiredscale = transform.localScale;
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GrowObject")) // Check if the colliding object has the "GrowObject" tag
        {
            transform.localScale *= growFactor; // Increase the scale
        }
        else if (collision.gameObject.CompareTag("ShrinkObject")) // Check if the colliding object has the "ShrinkObject" tag
        {
            transform.localScale *= shrinkFactor; // Decrease the scale
        }

    }

   
}
