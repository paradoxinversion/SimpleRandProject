/*
 * Created by SharpDevelop.
 * User: Saboteur
 * Date: 7/28/2015
 * Time: 7:45 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleRand
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public string path;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			SimpleRand.Instance.GetPath();
			BindCategoryListData();
			if (SimpleRand.Instance.categories.Count > 0)
			{
				optionsTextInput.Enabled = categoryNameInput.Enabled = true;
				deleteCategoryButton.Enabled = true;
				randomizeButton.Enabled = true;
				changeNameButton.Enabled = true;
			}
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void BindCategoryListData()
		{
			categoryListBox.DataSource = null;
			categoryListBox.DataSource = SimpleRand.Instance.categories;
			categoryListBox.DisplayMember = "CategoryName";
			//categoryListBox.ValueMember = "categoryOptions";
		}
		void AddCategoryButtonClick(object sender, EventArgs e)
		{
			
			SimpleRand.Instance.categoriesCreated++;
			SimpleRand.Category newCategory = new SimpleRand.Category();
			newCategory.SetCategoryName("Category " + SimpleRand.Instance.categoriesCreated);
//			if (!string.IsNullOrEmpty(optionsTextInput.Text))
//			{
//				newCategory.UpdateCategory(optionsTextInput.Text);
//			}
			SimpleRand.Instance.categories.Add(newCategory);
			

			BindCategoryListData();
			SimpleRand.Instance.currentCategory = newCategory;
			optionsTextInput.Text = string.Empty;
			categoryListBox.SelectedIndex = SimpleRand.Instance.categories.IndexOf(SimpleRand.Instance.currentCategory);
			categoryNameInput.Enabled = true;
			optionsTextInput.Enabled = true;
			//SimpleRand.Instance.SaveData();
			deleteCategoryButton.Enabled = true;
			randomizeButton.Enabled = true;
			changeNameButton.Enabled = true;
		}

		void RandomizeButtonClick(object sender, EventArgs e)
		{
			if (SimpleRand.Instance.currentCategory != null)
			{
				int choiceIndex = SimpleRand.Instance.srRand.Next(0, SimpleRand.Instance.currentCategory.categoryOptions.Count);
				string stringChoice = SimpleRand.Instance.currentCategory.categoryOptions[choiceIndex];
				outputTextBox.Text += stringChoice + Environment.NewLine;
			}
		}
		void OptionsTextInputTextChanged(object sender, EventArgs e)
		{
			if (SimpleRand.Instance.currentCategory != null)
			{
				SimpleRand.Instance.currentCategory.UpdateCategory(optionsTextInput.Text);
			}
		}
		
		void CategoryListBoxSelectedIndexChanged(object sender, EventArgs e)
		{
			int index = categoryListBox.SelectedIndex;
			if (categoryListBox.SelectedIndex > -1)
			{

				SimpleRand.Instance.currentCategory = SimpleRand.Instance.categories[index];
				optionsTextInput.Text = SimpleRand.Instance.currentCategory.LoadOptionsToString();
				categoryNameInput.Text = SimpleRand.Instance.currentCategory.categoryName;
			}
		}
		void ChangeNameButtonClick(object sender, EventArgs e)
		{
			SimpleRand.Instance.currentCategory.categoryName = categoryNameInput.Text;
			BindCategoryListData();
		}
		void DeleteCategoryButtonClick(object sender, EventArgs e)
		{
			
				SimpleRand.Instance.categories.Remove(SimpleRand.Instance.currentCategory);
				
				BindCategoryListData();
				deleteCategoryButton.Enabled = Convert.ToBoolean(SimpleRand.Instance.categories.Count);
				if (SimpleRand.Instance.categories.Count == 0)
				{
					randomizeButton.Enabled = false;
					changeNameButton.Enabled = false;
				}
				else
				{
					SimpleRand.Instance.currentCategory = SimpleRand.Instance.categories[0];
				}
			
		}
		void SaveDataButtonClick(object sender, EventArgs e)
		{
			SimpleRand.Instance.SaveData();
		}
		void ClearOutputButtonClick(object sender, EventArgs e)
		{
			outputTextBox.Text = string.Empty;
		}
		void EditOutputCheckBoxCheckedChanged(object sender, EventArgs e)
		{
			if (editOutputCheckBox.Checked)
			{
				outputTextBox.ReadOnly = false;
			}
			else
			{
				outputTextBox.ReadOnly = true;
			}
		}
	}
		
}
