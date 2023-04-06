using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color[] colors; // Array of colors to choose from
    private int currentIndex; // Index of the current color

    void Start()
    {
        // Choose a random color for the game object
        currentIndex = Random.Range(0, colors.Length);
        GetComponent<Renderer>().material.color = colors[currentIndex];
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Choose another random color for the game object
            int newIndex = Random.Range(0, colors.Length);
            while (newIndex == currentIndex)
            {
                // Make sure the new color is different from the current color
                newIndex = Random.Range(0, colors.Length);
            }
            currentIndex = newIndex;
            GetComponent<Renderer>().material.color = colors[currentIndex];
        }
    }
}
