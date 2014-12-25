using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;


/// <summary>
/// Generates commonly-used string types.
/// </summary>
public static class StringGenerators
{
	public static void AddTabs(int nTabs, StringBuilder outHTML)
	{
		for (int i = 0; i < nTabs; ++i)
			outHTML.Append('\t');
	}


	/// <summary>
	/// A dictionary that indexes special characters to their HTML equivalents.
	/// Order is important here (the '&' char must be replaced first so as to not conflict
	///	    with later replacements, which all use '&'), so a list is used instead of a dictionary.
	/// </summary>
	private static List<KeyValuePair<char, string>> textToHTMLSpecialChars = new List<KeyValuePair<char, string>>()
	{
		new KeyValuePair<char, string>('&', "&amp;"),
		new KeyValuePair<char, string>('<', "&lt;"),
		new KeyValuePair<char, string>('>', "&gt;"),
	};
	public static void AddCodeSampleElement(int tabLevel, bool useLITag, string codeText, StringBuilder outHTML)
	{
		StringBuilder codeT = new StringBuilder(codeText);

		//First replace any special characters.
		foreach (KeyValuePair<char, string> replacement in textToHTMLSpecialChars)
			codeT.Replace(replacement.Key.ToString(), replacement.Value);

		//Next, replace the spacing at the beginning of each line with the HTML spacing element.
		bool startingLine = true;
		for (int i = 0; i < codeT.Length; ++i)
		{
			if (startingLine)
			{
				if (codeT[i] == ' ')
				{
					codeT.Remove(i, 1);
					codeT.Insert(i, "&emsp;");
				}
				else
				{
					startingLine = false;
				}
			}
			
			if (codeT.ToString().Substring(i, System.Environment.NewLine.Length) ==
				System.Environment.NewLine)
			{
				codeT.Insert(i, "<br />");
				startingLine = true;
			}
		}

		//Finally, output the code text into an HTML code sample div.
		AddTabs(tabLevel, outHTML);
		if (useLITag)
			outHTML.AppendLine("<li><div class=\"CodeSample\"><code>");
		else
			outHTML.AppendLine("<div class=\"CodeSample\"><code>");
		outHTML.AppendLine(codeT.ToString());
		AddTabs(tabLevel, outHTML);
		if (useLITag)
			outHTML.AppendLine("</code></div></li>");
		else
			outHTML.AppendLine("</code></div>");
	}
}