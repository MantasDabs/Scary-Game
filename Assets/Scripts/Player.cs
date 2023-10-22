using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private void Update()
    {
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;


        GetComponent<Rigidbody2D>().MovePosition(mousePosition);
    }


    private void OnCollisionEnter2D(Collision2D other)
    {

        if (other.gameObject.name.Contains("Wall"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}