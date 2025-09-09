using UnityEngine;
using UnityEngine.SceneManagement;

public class NoGo : MonoBehaviour
{
    public float warnDistance = 2f;
    public float failDistance = 1f;
    public Color normalColor = Color.white;
    public Color warnColor = Color.red;

    private SpriteRenderer sr;

    private Vector3 startPos;
    private float shakeTime;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        startPos = transform.position;
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
        if (distSqr < warnDistance * warnDistance)
        {
            sr.color = warnColor;
            shakeTime += Time.deltaTime * 20f;

            float offsetX = Mathf.Sin(shakeTime) * 0.1f;
            float offsetY = Mathf.Cos(shakeTime) * 0.1f;

            transform.position = new Vector3(startPos.x + offsetX, startPos.y + offsetY, startPos.z);
        }
        else
        {
            sr.color = normalColor;
            transform.position = startPos;
        }

        if (distSqr < failDistance * failDistance)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
