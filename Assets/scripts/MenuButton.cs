using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
	[SerializeField] MenuButtonController menuButtonController;
	[SerializeField] Animator animator;
	[SerializeField] AnimatorFunctions animatorFunctions;
	[SerializeField] int thisIndex;

    // Update is called once per frame
    void Update()
    {
		if(menuButtonController.index == thisIndex)
		{
			animator.SetBool ("active", true);
			if(Input.GetAxis ("Submit") == 1){
				animator.SetBool ("press", true);
				loadScene();
			}else if (animator.GetBool ("press")){
				animator.SetBool ("press", false);
				animatorFunctions.disableOnce = true;
			}
		}else{
			animator.SetBool ("active", false);
		}
    }

	void loadScene()
	{
		if (menuButtonController.index == 0)
		{
			SceneManager.LoadScene("Game Scene");
		}
	}
}
