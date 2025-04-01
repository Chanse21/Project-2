using UnityEngine;

public class SectionTrigger : MonoBehaviour
{

    public GameObject RoadSection;

        public Transform SpawnPosition;

         

 private void OnTriggerEnter(Collider other)
    {

    if (other.gameObject.CompareTag("Player"))
        {
            Instantiate(RoadSection,SpawnPosition.position, Quaternion.identity);
        }
    }
}
