/*
 * Created by SharpDevelop.
 * User: Saboteur
 * Date: 7/29/2015
 * Time: 1:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace SimpleRand
{
	/// <summary>
	/// Description of SaveData.
	/// </summary>
	 [System.Serializable]
	public class SaveData
	{
		public List<SimpleRand.Category> categories = new List<SimpleRand.Category>();
		public SaveData(List<SimpleRand.Category> categoryList)
		{
			categories = categoryList;
		}
	}
}
