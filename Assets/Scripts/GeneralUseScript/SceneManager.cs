using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public void MoveThisAmountForward(int amount) {
        int currentSceneIndex = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
        int newSceneIndex = currentSceneIndex + amount;
        UnityEngine.SceneManagement.SceneManager.LoadScene(newSceneIndex);
    }

    public void GoToThisScene(int index) {
        UnityEngine.SceneManagement.SceneManager.LoadScene(index);
    }

    public void GoToThisScene(string name) {
        UnityEngine.SceneManagement.SceneManager.LoadScene(name);
    }

    public void GoToMenu() {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

    public void GoToTutorial() {
        UnityEngine.SceneManagement.SceneManager.LoadScene(4);
    }

    public void Quit() {
        Application.Quit();
    }

    public void PlayAgain() {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
}
