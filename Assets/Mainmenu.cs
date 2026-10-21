using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void LoadLevel(int id)
    {
        SceneManager.LoadSceneAsync(id);
    }

}