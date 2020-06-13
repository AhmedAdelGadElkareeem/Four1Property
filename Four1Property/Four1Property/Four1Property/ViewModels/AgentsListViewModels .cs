using Four1Property.DataSource;
using Four1Property.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Four1Property.ViewModels
{
    public class AgentsListViewModels : BaseViewModel
	{

		private ObservableCollection<Agent> agent;

		public ObservableCollection<Agent> Agent
		{
			get { return agent; }
			set
			{
                agent = value;
			}
		}

		public AgentsListViewModels()
		{
            Agent = new ObservableCollection<Agent>();

			AgentsListViewModels _context = new AgentsListViewModels();

			foreach (var agent in _context.Agent)
			{
				Agent.Add(agent);
			}

		}


	}
}
