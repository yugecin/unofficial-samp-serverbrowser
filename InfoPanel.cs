﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace yugecin.sampbrowser {

	public class InfoPanel : Panel {

		protected override void OnPaint( PaintEventArgs e )
		{
			base.OnPaint( e );
			e.Graphics.DrawLine( Pens.Black, new Point( 0, 7 ), new Point( 0, Height - 2 ) );
			e.Graphics.DrawLine( Pens.Black, new Point( 0, 6 ), new Point( Width - 1, 6 ) );
			e.Graphics.DrawLine( Pens.Black, new Point( 240, 6 ), new Point( 240, Height - 1 ) );
			e.Graphics.DrawLine( Pens.Black, new Point( 496, 16 ), new Point( 496, Height - 7 ) );
			e.Graphics.DrawLine( Pens.Black, new Point( Width - 1, 7 ), new Point( Width - 1, Height - 2 ) );
			e.Graphics.DrawLine( Pens.Black, new Point( 0, Height - 1 ), new Point( Width - 1, Height - 1 ) );
		}

	}

}
