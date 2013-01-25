using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentStorage.Domain
{
	public class DocumentType
	{
		public Guid ID
		{
			get;

			set;
		}
		
		public String Description
		{
			get;

			set;
		}

		public TypeCategory Category
		{
			get;

			set;
		}

		
	}
}
