﻿using System.Windows.Forms;

namespace yugecin.sampbrowser
{
	class Loader
	{

		public static void Main()
		{
			Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
#if DEBUGBUILD
			Application.Run( new frmMain( new TestServerProvider() ) );
#else
			Application.Run( new frmMain( new GamestateServerProvider() ) );
#endif
#if WITHLAUNCHER
			MLauncher launcher = new MLauncher();
			launcher.Launch();
#if DEBUGBUILD
			System.Console.WriteLine( "with launcher" );
#endif
#endif
		}

	}
}
