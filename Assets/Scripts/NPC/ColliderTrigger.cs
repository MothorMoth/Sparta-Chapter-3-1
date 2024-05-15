using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{
    public GameObject dialogButton;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dialogButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            dialogButton.SetActive(false);
        }
    }
}
