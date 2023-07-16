using System.Collections;
using UnityEngine;

public class Loading : MonoBehaviour
{
    [SerializeField] float duration;


    private IEnumerator Start()
    {
        yield return new WaitForSeconds(duration);
        LoadSceneBtn.LoadLevel(2);
    }
}
