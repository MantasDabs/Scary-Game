using UnityEngine;

public class Wall : MonoBehaviour
{

    public Transform spawnPoint;


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = spawnPoint.position;
        }
    }
}
