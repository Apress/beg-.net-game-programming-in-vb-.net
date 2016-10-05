using System;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;
using System.Drawing;

namespace Apress.GameProgramming.DrawTextWorkAround
{
	public struct FontFix
	{
		private Microsoft.DirectX.Direct3D.Font textFont; // Used to draw the text
		private Color color; // Color to draw the text
		private System.Drawing.Point point; // Where to draw the text

		public FontFix(Microsoft.DirectX.Direct3D.Font f)
		{
			textFont = f;
			color = Color.White;
			point = System.Drawing.Point.Empty;
		}

		public void DrawText(string text)
		{
			if (textFont == null)
			{
				throw new InvalidOperationException("You cannot draw text.  There is no font object.");
			}
			// Create the rectangle to draw to
			System.Drawing.Rectangle rect = new System.Drawing.Rectangle(point, System.Drawing.Size.Empty);
			textFont.DrawText(null, text, rect, 
				DrawTextFormat.NoClip | DrawTextFormat.ExpandTabs | DrawTextFormat.WordBreak, color);
		}

		public void DrawText(string Text, System.Drawing.Rectangle Rectangle, Color TextColor)
		{
			if (textFont == null)
			{
				throw new InvalidOperationException("You cannot draw text.  There is no font object.");
			}
			// Create the rectangle to draw to
			System.Drawing.Rectangle rect = new System.Drawing.Rectangle(point, System.Drawing.Size.Empty);
			textFont.DrawText(null, Text, Rectangle, 
				DrawTextFormat.NoClip | DrawTextFormat.ExpandTabs | DrawTextFormat.WordBreak, TextColor);
		}


	}

}