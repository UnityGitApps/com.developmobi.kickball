using UnityEngine.SceneManagement;

using UnityEngine.UI;
using UnityEngine;

public class LoadSceneBtn : MonoBehaviour
{
    [SerializeField] int sceneIndex;

    private void Start()
    {
        var btn = GetComponent<Button>();
        btn.onClick.AddListener(() =>
        {
            LoadLevel(sceneIndex);
        });
    }

    public static void LoadLevel(int id)
    {
        SceneManager.LoadScene(id);
    }
}
