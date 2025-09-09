using UnityEngine;

public class Finish : MonoBehaviour
{
    public float winDistance = 1f;
    public GameObject winUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        if (winUI != null)
            winUI.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player == null)
            return;

        float dx = player.transform.position.x - transform.position.x;
        float dy = player.transform.position.y - transform.position.y;

        float distSqr = dx * dx + dy * dy;
        if (distSqr < winDistance * winDistance)
        {
            if (winUI != null)
                winUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
