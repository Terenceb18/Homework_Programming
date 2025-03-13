using UnityEngine;

public class PlayerDie : MonoBehaviour
{
    public GameObject endPanal;
    private string Enemy = "Enemy";

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == Enemy)
        {
            endPanal.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
