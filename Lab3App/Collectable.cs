using System;
using System.Collections.Generic;
namespace Lab3App
{
	internal abstract class Collectable : Displayable

	{
        public Collectable() { }


        public CollectionBoard CB{ get; set; }
		public string Description { get; set; }
		public abstract void AddMe(List<Collectable> collectables);
		public abstract void Display();
		
	}
}

