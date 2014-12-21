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
	/// <summary>
	/// TODO: Rename to "DataDefinition".
	/// </summary>
	public partial class MemberFieldDefinition : ItemHTMLDefinition
	{
		public MemberFieldDefinition()
		{
			InitializeComponent();
		}
		public MemberFieldDefinition(ItemHTMLData data)
			: this()
		{
			SetData(data);
		}

		protected override void AddDefinition(StringBuilder sbOut)
		{
			sbOut.Append(AccessModifierDropdown.SelectedItem.ToString());
			sbOut.Append(" ");
			sbOut.Append(ItemTypeText.Text);
			sbOut.Append(" ");
			sbOut.Append(ItemNameText.Text);
		}
	}
}
