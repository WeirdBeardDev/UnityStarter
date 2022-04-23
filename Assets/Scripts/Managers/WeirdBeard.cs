/*
 * This work by Jason "Aj" Comfort (https://weirdbearddev.com) is licensed under 
 * CC BY-SA 4.0. To view a copy of this license, visit https://creativecommons.org/licenses/by-sa/4.0
*/

using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace WeirdBeardDev
{
	public class WeirdBeard : Singleton<WeirdBeard>
	{
		#region Members
		private const string DNAME = nameof(WeirdBeard);
		#endregion Members

		#region Properties
		#endregion Properties

		#region MonoBehaviours
		protected override void Awake()
		{
			base.Awake();
			Log(DNAME, "starting the game...");
		}
		protected override void OnApplicationQuit()
		{
			base.OnApplicationQuit();
			// FIX Android, iOS, and WebGL don't use this method
			// TODO research how each system triggers the app exit
			QuitGame();
		}
		#endregion MonoBehaviours

		#region Methods
		public void QuitGame()
		{
			Log(DNAME, "quitting the game.");
			Application.Quit();
		}
		[Conditional("ENABLE_LOGS")]
		public static void Log(string className, string text) => print($"{className}: {text}");
		#endregion Methods

		#region Helpers
		#endregion Helpers
	}
}