using UnityEngine;
using System.Collections;

public enum GridType
{
	SQUARE,
	HEX
}


public class GridManager : MonoBehaviour {

	//Declare Singleton
	private static GridManager _instance;
	public static GridManager instance
	{
		get{
			return _instance;
		}
	}

	public GridController gridController;
	public static GridController GridController
	{
		get
		{
			return _instance.gridController;
		}
	}

	void Awake()
	{
		_instance = this;

		if( gridController == null )
		{
			Debug.LogError("No IGridController assigned or found in scene.");
		}
	}

}
