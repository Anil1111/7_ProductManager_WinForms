using System.ComponentModel.DataAnnotations;
using System;

namespace AplikacjaWindows
{
	[MetadataType(typeof(TowaryMetadata))]
	public partial class Towary
	{
	}

	[MetadataType(typeof(CenyMetadata))]
	public partial class Ceny
	{
	}

	[MetadataType(typeof(CennikiMetadata))]
	public partial class Cenniki
	{
	}
}
