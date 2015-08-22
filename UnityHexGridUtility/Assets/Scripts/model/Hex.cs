using UnityEngine;
using System.Collections;

public class Hex : IGridObject {

	public int x{ get; private set; }
	public int y{ get; private set; }
	public int z{ get; private set; }

	public Hex( int col, int row )
	{
		Vector3 cubePos = HexUtilities.OffsetToCube( col, row );
		x = (int)cubePos.x;
		y = (int)cubePos.y;
		z = (int)cubePos.z;
	}

	public Hex( int x, int y, int z )
	{
		this.x = x;
		this.y = y;
		this.z = z;
	}

}
