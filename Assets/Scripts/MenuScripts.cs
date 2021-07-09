using UnityEngine;
using UnityEngine.SceneManagement;

namespace RetroAesthetics.Demos {

	public class MenuScripts : MonoBehaviour {
		public SceneField loadingScene;
		public SceneField levelScene1;
		public SceneField levelScene2;

		public bool fadeInMenu = true;
		public bool fadeOutMenu = true;

		private RetroCameraEffect _cameraEffect;
		private AsyncOperation _loadingSceneAsync;

		void Start() {
			if (fadeInMenu) {
				_cameraEffect = GameObject.FindObjectOfType<RetroCameraEffect>();
				if (_cameraEffect != null) {
					_cameraEffect.FadeIn();
				}
			}
		}
		public void Exitt() {
			Application.Quit();
		}

		virtual public void StartArcadeArcade() {
			if (levelScene1 != null) {
				if (_cameraEffect != null) {
					if (loadingScene != null) {
						_loadingSceneAsync = SceneManager.LoadSceneAsync(loadingScene);
						if (_loadingSceneAsync == null) {
							Debug.LogWarning(string.Format(
								"Please add scene `{0}` to the built scenes in the Build Settings.",
								loadingScene.SceneName));
							return;
						}
						_loadingSceneAsync.allowSceneActivation = false; 
					}
				
					_cameraEffect.FadeOut(0.5f, LoadNextScene1);
				} else {
					LoadNextScene1();
				}
			} else {
				Debug.LogWarning("Level scene is not set.");
			}
		}

		virtual public void StartStudioStudio() {
			if (levelScene2 != null) {
				if (_cameraEffect != null) {
					if (loadingScene != null) {
						_loadingSceneAsync = SceneManager.LoadSceneAsync(loadingScene);
						if (_loadingSceneAsync == null) {
							Debug.LogWarning(string.Format(
								"Please add scene `{0}` to the built scenes in the Build Settings.",
								loadingScene.SceneName));
							return;
						}
						_loadingSceneAsync.allowSceneActivation = false; 
					}
				
					_cameraEffect.FadeOut(0.5f, LoadNextScene2);
				} else {
					LoadNextScene2();
				}
			} else {
				Debug.LogWarning("Level scene is not set.");
			}
		}

		private void LoadNextScene1() {
			if (_loadingSceneAsync != null) {
				_loadingSceneAsync.allowSceneActivation = true;
			}
			SceneManager.LoadSceneAsync(levelScene1);
		}

		private void LoadNextScene2() {
			if (_loadingSceneAsync != null) {
				_loadingSceneAsync.allowSceneActivation = true;
			}
			SceneManager.LoadSceneAsync(levelScene2);
		}
	}
}
