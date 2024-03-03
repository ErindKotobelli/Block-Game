using UnityEngine;
using UnityEngine.SceneManagement;
public class MENU : MonoBehaviour {

	// Use this for initialization
	public void StartGame () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
	
	public void Controls_game_tutorial () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 11);
	}
	public void return_main_menu () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 11);
	}
	public void return_main_menu_credits () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 6);
	}
	public void return_main_menu_leve1 () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 2);
	}
	public void return_main_menu_leve2 () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 4);
	}
	public void levelsmenu () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 12);
	}
	public void return_level1 () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 11);
	}
	public void return_leve2 () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 9);
	}
	public void return_leve3 () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 7);
	}
	public void return_leve4 () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 5);
	}
	public void return_leve5 () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 3);
	}

	public void return_levelsmenu () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 12);
	}
	public void return_main_menu_leve3 () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 6);
	}
	public void return_main_menu_leve4 () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 8);
	}

}


