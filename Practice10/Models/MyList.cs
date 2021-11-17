using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Models
{
	public class MyList<T> : Collection<T>, IComparer<T> where T : IComparable<T>
	{
		public int Compare(T? x, T? y)
		{
			return x.CompareTo(y);
		}
		protected override void ClearItems()
		{
			base.ClearItems();
		}
		protected override void InsertItem(int index, T item)
		{
			int i = 0;
			for (i = 0; i < Count && Items[i].CompareTo(item) < 0; i++) {
			}
			base.InsertItem(i, item);
		}
		protected override void RemoveItem(int index)
		{
			base.RemoveItem(index);
		}
		protected override void SetItem(int index, T item)
		{
			base.SetItem(index, item);
		}
	}
}
