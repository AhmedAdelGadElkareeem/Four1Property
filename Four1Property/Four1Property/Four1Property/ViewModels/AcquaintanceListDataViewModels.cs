using Four1Property.DataSource;
using Four1Property.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms.Extended;

namespace Four1Property.ViewModels
{
    public class AcquaintanceListDataViewModels : BaseViewModel
	{

		private InfiniteScrollCollection<Property> property;

		public InfiniteScrollCollection<Property> Property
		{
			get { return property; }
			set
			{
				property = value;
			}
		}

		public AcquaintanceListDataViewModels()
		{
			Property = new InfiniteScrollCollection<Property>();

			AcquaintanceListData _context = new AcquaintanceListData();

			foreach (var property in _context.Property)
			{
				Property.Add(property);
			}

		}


	}
}
