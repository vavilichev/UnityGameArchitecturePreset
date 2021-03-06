﻿using UnityEngine;
using UnityEngine.UI;
using VavilichevGD.Architecture.UI.Utils;

namespace VavilichevGD.Architecture.UI.Example {
	public class UIScreenGameExample : UIScreen {

		[SerializeField] private Button buttonExit;
		
		private void OnEnable() {
			this.buttonExit.AddListener(this.OnExamplePopupButtonClick);
		}

		private void OnDisable() {
			this.buttonExit.RemoveListener(this.OnExamplePopupButtonClick);
		}

		#region EVENTS

		private void OnExamplePopupButtonClick() {
			this.uiController.ShowUIElement<UIPopupExitExample>();
		}

		#endregion
	}
}