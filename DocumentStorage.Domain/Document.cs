using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentStorage.Domain
{
    public class Document
    {
		public String Name
		{
			get;

			set;
		}

		public DocumentType Type
		{
			get;

			set;
		}		
    }
}
