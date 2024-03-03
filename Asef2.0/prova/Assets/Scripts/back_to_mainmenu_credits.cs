using UnityEngine;
using UnityEngine.SceneManagement;

public class back_to_mainmenu_credits : MonoBehaviour {

	public void return_main_menu_credits () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex - 10);
	}

}
