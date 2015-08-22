using UnityEngine;
using System.Collections;

public enum GridOrientation
{
	FLAT,
	POINTY
}

public enum GridLayout
{
	CUBE,
	EVENROW,
	ODDROW,
	EVENCOL,
	ODDCOL
}

public interface IGridController {

	GridOrientation Orientation{ get; }
	GridLayout Layout{ get; }

}
