using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Restart : MonoBehaviour
{
    // Tulis Kode disini
    public void onClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        // SceneManager.LoadScene("Day 2");
        Time.timeScale = 1f;
    }
}
