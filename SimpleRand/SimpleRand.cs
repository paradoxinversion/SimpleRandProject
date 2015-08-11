/*
 * Created by SharpDevelop.
 * User: Saboteur
 * Date: 7/28/2015
 * Time: 7:53 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
namespace SimpleRand
{
	/// <summary>
	/// Description of SimpleRand.
	/// </summary>
	public sealed class SimpleRand
	{
		private static SimpleRand instance = new SimpleRand();
		
		public static SimpleRand Instance {
			get {
				return instance;
			}
		}
		
		public List<string> currentList = new List<string>();
		public List<Category> categories = new List<Category>();
		public Category currentCategory;
		public Random srRand;
		public int categoriesCreated = 0;
		public string path;
		public SaveData data;
		private SimpleRand()
		{
			
		}
		public void GetPath()
		{
			srRand = new Random();
			path = AppDomain.CurrentDomain.BaseDirectory;
			
			System.Diagnostics.Debug.WriteLine(path);
			if (File.Exists(path+ "/SimpleRandDef.rand"))
			{
				LoadData();
			}
			
		}
		public List<string> SetCurrentList(List<string> list)
		{
			currentList = list;
			return currentList;
		}
		
		public void SaveData()
		{
			SaveData saveData = new SaveData(categories);
			IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			System.IO.Stream stream = new System.IO.FileStream(path+ "/SimpleRandDef.rand", System.IO.FileMode.Create, System.IO.FileAccess.Write,System.IO.FileShare.None);
			formatter.Serialize(stream, saveData);
			stream.Close();
		}
		
		public void LoadData()
		{
			
			IFormatter formatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
			System.IO.Stream stream = new System.IO.FileStream(path + "/SimpleRandDef.rand", System.IO.FileMode.Open, System.IO.FileAccess.Read, System.IO.FileShare.Read);
			SaveData saveData = (SaveData) formatter.Deserialize(stream);
			stream.Close();
			categories = saveData.categories;
			
		}	
		
		[System.Serializable]
		public class Category
		{
			public string categoryName;
			public string CategoryName
			{
				get
				{
					return categoryName;
				
				}
			
			
			}
			public List<string> categoryOptions = new List<string>();
			public Category()
			{
			}
			
			public string SetCategoryName(string newName)
			{
				categoryName = newName;
				return categoryName;
			}
			
			/// <summary>
			/// Takes all text found in a string (the multiline options string) and adds it to a list by line
			/// </summary>
			/// <param name="itemText"></param>
			/// <returns></returns>
			public List<string> UpdateCategory(string itemText)
			{
				categoryOptions = new List<string>();
				using (StringReader sr = new StringReader(itemText))
				{
					string line;
					while ((line = sr.ReadLine()) != null)
					{
						categoryOptions.Add(line);
					}
				}
				return categoryOptions;
			}
			
			/// <summary>
			/// Load category options int a string
			/// </summary>
			/// <returns>The category options as a string, seperated by line</returns>
			public string LoadOptionsToString()
			{
				string options = string.Empty;
				foreach (string option in categoryOptions)
				{
					options += option + Environment.NewLine;
				}
				return options;
			}
		}
		
	}
}
