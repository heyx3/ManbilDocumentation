using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTMLGenerator
{
	public partial class DataDefinition : ItemHTMLDefinition
	{
		public DataDefinition()
		{
			InitializeComponent();
		}
		public DataDefinition(ItemHTMLData data)
			: this()
		{
			SetData(data);
		}

		protected override void AddDefinition(string className, StringBuilder sbOut)
		{
			if (AccessModifierDropdown.SelectedItem == null)
				sbOut.Append("ERROR_NO_ACCESS_MODIFIER");
			else
				sbOut.Append(AccessModifierDropdown.SelectedItem.ToString());

			sbOut.Append(" ");
			sbOut.Append(ItemTypeText.Text);
			sbOut.Append(" ");
			sbOut.Append(ItemNameText.Text);
		}
	}
}
