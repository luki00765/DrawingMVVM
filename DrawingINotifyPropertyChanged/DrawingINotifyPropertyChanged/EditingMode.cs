using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace DrawingINotifyPropertyChanged
{
	public class EditingMode : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private InkCanvasEditingMode _editMode;
		public InkCanvasEditingMode EditMode
		{
			get { return _editMode; }
			set
			{
				_editMode = value;
				if (PropertyChanged != null)
					PropertyChanged(this, new PropertyChangedEventArgs("EditMode"));
			}
		}

		private string _text;

		public string Text
		{
			get { return _text; }
			set
			{
				_text = value;
				if (PropertyChanged != null)
					PropertyChanged(this, new PropertyChangedEventArgs("Text"));
			}
		}

		public EditingMode()
		{
			EditMode = InkCanvasEditingMode.Ink;
			Text = "Ink";
		}
	}
}
