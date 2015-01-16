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
	/// <summary>
	/// Replaces any special HTML characters with the correct text representation of that character.
	/// </summary>
	public static void ReplaceSpecialChars(StringBuilder str)
	{
		foreach (KeyValuePair<char, string> replacement in textToHTMLSpecialChars)
			str.Replace(replacement.Key.ToString(), replacement.Value);
	}
	public static void AddCodeSampleElement(int tabLevel, bool useLITag, string codeText, StringBuilder outHTML)
	{
		StringBuilder codeT = new StringBuilder(codeText);

		//First replace any special characters.
		ReplaceSpecialChars(codeT);

		//Next, replace the line breaks with HTML-formatted breaks.
		ReplaceLineBreaks(codeT, "<br />" + System.Environment.NewLine);
		//Now replace extended spaces with "&emsp;" symbols.
		for (int i = 0; i < codeT.Length; ++i)
		{
			if (codeT[i] == ' ')
			{
				int j = i + 1;
				while (j < codeT.Length && codeT[j] == ' ')
					j += 1;

				int nSpaces = (j - i) - 1;
				if (nSpaces > 1)
				{
					StringBuilder spaceText = new StringBuilder("");
					for (j = 0; j < nSpaces; ++j)
						spaceText.Append("&emsp;");

					codeT.Remove(i, nSpaces);
					codeT.Insert(i, spaceText.ToString());
				}
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

	/// <summary>
	/// Replaces all line breaks in the given StringBuilder with the given text.
	/// </summary>
	public static void ReplaceLineBreaks(StringBuilder toReplace, string replacementString)
	{
		foreach (char c in System.Environment.NewLine)
			toReplace.Replace(c.ToString(), replacementString);
	}
}